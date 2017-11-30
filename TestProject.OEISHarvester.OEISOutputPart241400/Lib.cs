using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A029152
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,3L,1L,3L,4L,3L,4L,7L,4L,7L,9L,7L,9L,14L,9L,14L,17L,14L,17L,24L,17L,24L,29L,24L,29L,38L,29L,38L,45L,38L,45L,57L,45L,57L,66L,57L,66L,81L,66L,81L,93L,81L,93L,111L,93L,111L,126L,111L,126L,148L,126L,148L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029152Inst : IEnumerable<long>
{
public static readonly long[] Value=A029152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029152.Bytes);
public long this[int i]=>Value[i];

public static A029152Inst Instance=new A029152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029153
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,3L,1L,3L,3L,4L,3L,7L,4L,7L,7L,9L,7L,13L,9L,14L,13L,17L,14L,22L,17L,24L,22L,28L,24L,35L,28L,38L,35L,43L,38L,52L,43L,56L,52L,63L,56L,74L,63L,79L,74L,88L,79L,101L,88L,108L,101L,119L,108L,134L,119L,143L,134L,156L,143L,174L,156L,185L,174L,200L,185L,221L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029153Inst : IEnumerable<long>
{
public static readonly long[] Value=A029153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029153.Bytes);
public long this[int i]=>Value[i];

public static A029153Inst Instance=new A029153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029154
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,3L,1L,3L,3L,3L,4L,6L,4L,7L,7L,7L,9L,11L,9L,13L,13L,14L,16L,19L,17L,22L,22L,24L,26L,30L,28L,34L,35L,37L,40L,45L,43L,50L,52L,54L,58L,64L,62L,71L,73L,76L,81L,88L,86L,97L,99L,103L,109L,117L,116L,128L,131L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029154Inst : IEnumerable<long>
{
public static readonly long[] Value=A029154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029154.Bytes);
public long this[int i]=>Value[i];

public static A029154Inst Instance=new A029154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029155
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,3L,1L,3L,3L,3L,3L,7L,3L,7L,7L,7L,7L,13L,7L,13L,13L,13L,13L,22L,13L,22L,22L,22L,22L,34L,22L,34L,34L,34L,34L,50L,34L,50L,50L,50L,50L,70L,50L,70L,70L,70L,70L,95L,70L,95L,95L,95L,95L,125L,95L,125L,125L,125L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029155Inst : IEnumerable<long>
{
public static readonly long[] Value=A029155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029155.Bytes);
public long this[int i]=>Value[i];

public static A029155Inst Instance=new A029155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029156
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,7L,7L,9L,9L,11L,11L,13L,14L,16L,17L,20L,20L,23L,24L,27L,28L,32L,33L,37L,38L,42L,44L,48L,50L,55L,57L,62L,64L,70L,72L,78L,81L,87L,90L,97L,100L,107L,111L,118L,122L,130L,134L,143L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029156Inst : IEnumerable<long>
{
public static readonly long[] Value=A029156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029156.Bytes);
public long this[int i]=>Value[i];

public static A029156Inst Instance=new A029156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029157
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,2L,2L,4L,3L,4L,5L,5L,6L,7L,8L,8L,11L,10L,12L,14L,14L,16L,18L,19L,20L,24L,24L,26L,30L,30L,33L,36L,38L,40L,45L,46L,49L,54L,55L,59L,64L,66L,70L,76L,78L,82L,89L,91L,96L,103L,106L,111L,119L,122L,128L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029157Inst : IEnumerable<long>
{
public static readonly long[] Value=A029157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029157.Bytes);
public long this[int i]=>Value[i];

public static A029157Inst Instance=new A029157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029158
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,2L,2L,3L,4L,3L,5L,5L,6L,6L,8L,8L,9L,10L,12L,12L,14L,15L,17L,17L,20L,21L,23L,24L,28L,28L,31L,33L,36L,37L,41L,43L,46L,48L,53L,54L,59L,61L,66L,68L,73L,76L,81L,84L,90L,93L,99L,102L,109L,112L,119L,123L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029158Inst : IEnumerable<long>
{
public static readonly long[] Value=A029158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029158.Bytes);
public long this[int i]=>Value[i];

public static A029158Inst Instance=new A029158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029159
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,6L,6L,7L,8L,9L,9L,11L,12L,13L,14L,16L,17L,18L,20L,22L,23L,25L,27L,29L,31L,33L,36L,38L,40L,43L,46L,48L,51L,55L,57L,61L,64L,68L,71L,75L,79L,83L,87L,91L,96L,100L,105L,110L,115L,120L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029159Inst : IEnumerable<long>
{
public static readonly long[] Value=A029159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029159.Bytes);
public long this[int i]=>Value[i];

public static A029159Inst Instance=new A029159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029160
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,5L,4L,6L,6L,7L,7L,9L,9L,10L,12L,12L,13L,16L,15L,18L,19L,21L,21L,25L,25L,27L,30L,31L,33L,37L,37L,41L,43L,46L,47L,53L,53L,57L,61L,63L,66L,72L,73L,78L,82L,86L,88L,96L,97L,103L,108L,112L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029160Inst : IEnumerable<long>
{
public static readonly long[] Value=A029160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029160.Bytes);
public long this[int i]=>Value[i];

public static A029160Inst Instance=new A029160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029161
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,3L,3L,3L,4L,5L,4L,6L,6L,7L,8L,10L,9L,12L,12L,13L,14L,17L,16L,20L,21L,22L,24L,27L,26L,31L,32L,34L,37L,41L,40L,46L,47L,50L,53L,58L,58L,65L,67L,70L,74L,80L,80L,88L,91L,95L,100L,107L,107L,117L,120L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029161Inst : IEnumerable<long>
{
public static readonly long[] Value=A029161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029161.Bytes);
public long this[int i]=>Value[i];

public static A029161Inst Instance=new A029161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029162
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,3L,2L,4L,3L,5L,4L,6L,5L,8L,6L,10L,8L,12L,10L,14L,12L,17L,14L,20L,17L,23L,20L,27L,23L,31L,27L,35L,31L,40L,35L,45L,40L,51L,45L,57L,51L,63L,57L,70L,63L,78L,70L,86L,78L,94L,86L,103L,94L,113L,103L,123L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029162Inst : IEnumerable<long>
{
public static readonly long[] Value=A029162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029162.Bytes);
public long this[int i]=>Value[i];

public static A029162Inst Instance=new A029162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029163
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,3L,2L,3L,4L,4L,4L,6L,5L,7L,7L,8L,9L,10L,10L,13L,12L,15L,15L,17L,18L,20L,20L,24L,23L,27L,28L,30L,32L,35L,35L,40L,40L,44L,46L,49L,51L,56L,56L,62L,63L,68L,70L,75L,77L,83L,84L,91L,93L,99L,102L,108L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029163Inst : IEnumerable<long>
{
public static readonly long[] Value=A029163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029163.Bytes);
public long this[int i]=>Value[i];

public static A029163Inst Instance=new A029163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029164
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,3L,2L,3L,3L,5L,3L,6L,5L,7L,6L,9L,7L,11L,9L,12L,11L,16L,12L,18L,16L,20L,18L,24L,20L,28L,24L,30L,28L,36L,30L,40L,36L,44L,40L,50L,44L,56L,50L,60L,56L,69L,60L,75L,69L,81L,75L,90L,81L,99L,90L,105L,99L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029164Inst : IEnumerable<long>
{
public static readonly long[] Value=A029164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029164.Bytes);
public long this[int i]=>Value[i];

public static A029164Inst Instance=new A029164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029197
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,2L,1L,2L,1L,3L,3L,4L,3L,4L,4L,6L,6L,7L,6L,8L,8L,11L,10L,12L,11L,14L,14L,17L,16L,19L,18L,22L,22L,25L,25L,28L,28L,32L,32L,36L,36L,40L,40L,45L,45L,50L,50L,55L,55L,61L,61L,67L,67L,73L,74L,80L,81L,87L,88L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029197Inst : IEnumerable<long>
{
public static readonly long[] Value=A029197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029197.Bytes);
public long this[int i]=>Value[i];

public static A029197Inst Instance=new A029197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029198
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,2L,1L,2L,1L,3L,2L,5L,2L,5L,3L,6L,5L,8L,5L,9L,6L,11L,8L,14L,9L,15L,11L,17L,14L,21L,15L,23L,17L,26L,21L,31L,23L,33L,26L,37L,31L,43L,33L,46L,37L,51L,43L,58L,46L,62L,51L,68L,58L,76L,62L,81L,68L,88L,76L,98L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029198Inst : IEnumerable<long>
{
public static readonly long[] Value=A029198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029198.Bytes);
public long this[int i]=>Value[i];

public static A029198Inst Instance=new A029198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029199
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,2L,2L,2L,3L,2L,4L,3L,5L,5L,6L,6L,7L,7L,9L,9L,11L,11L,13L,13L,15L,15L,18L,18L,21L,21L,24L,24L,27L,28L,31L,32L,35L,36L,40L,40L,45L,45L,50L,51L,55L,57L,61L,63L,68L,69L,75L,76L,82L,84L,90L,92L,98L,100L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029199Inst : IEnumerable<long>
{
public static readonly long[] Value=A029199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029199.Bytes);
public long this[int i]=>Value[i];

public static A029199Inst Instance=new A029199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029200
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,2L,1L,3L,2L,3L,3L,3L,5L,4L,6L,5L,7L,7L,8L,9L,9L,11L,11L,13L,13L,15L,16L,17L,19L,19L,22L,22L,25L,26L,28L,30L,31L,34L,35L,38L,40L,42L,45L,47L,50L,52L,55L,58L,61L,64L,67L,70L,74L,77L,81L,84L,88L,92L,96L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029200Inst : IEnumerable<long>
{
public static readonly long[] Value=A029200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029200.Bytes);
public long this[int i]=>Value[i];

public static A029200Inst Instance=new A029200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029201
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,2L,1L,2L,3L,2L,4L,2L,5L,4L,5L,6L,5L,7L,8L,8L,10L,8L,12L,11L,13L,14L,14L,16L,18L,18L,21L,19L,24L,24L,26L,28L,28L,31L,34L,34L,39L,36L,43L,43L,46L,49L,49L,54L,57L,58L,64L,61L,70L,70L,75L,78L,79L,85L,89L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029201Inst : IEnumerable<long>
{
public static readonly long[] Value=A029201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029201.Bytes);
public long this[int i]=>Value[i];

public static A029201Inst Instance=new A029201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029202
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,2L,1L,2L,2L,3L,3L,3L,4L,4L,5L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,21L,23L,24L,26L,27L,29L,31L,32L,35L,36L,39L,40L,43L,45L,47L,50L,52L,55L,57L,60L,63L,66L,69L,72L,75L,78L,82L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029202Inst : IEnumerable<long>
{
public static readonly long[] Value=A029202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029202.Bytes);
public long this[int i]=>Value[i];

public static A029202Inst Instance=new A029202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029203
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,2L,1L,2L,2L,2L,4L,2L,5L,3L,5L,5L,5L,7L,6L,8L,8L,8L,11L,9L,13L,11L,14L,14L,15L,17L,17L,19L,20L,21L,24L,23L,27L,26L,30L,30L,33L,34L,36L,38L,40L,42L,45L,46L,50L,50L,55L,55L,60L,61L,65L,67L,70L,73L,77L,79L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029203Inst : IEnumerable<long>
{
public static readonly long[] Value=A029203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029203.Bytes);
public long this[int i]=>Value[i];

public static A029203Inst Instance=new A029203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029204
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,2L,2L,3L,2L,3L,3L,4L,4L,5L,5L,7L,6L,8L,7L,9L,9L,11L,11L,13L,13L,15L,15L,17L,17L,20L,20L,23L,23L,26L,26L,29L,29L,33L,33L,37L,37L,41L,42L,45L,46L,50L,51L,56L,56L,61L,62L,67L,68L,73L,74L,80L,81L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029204Inst : IEnumerable<long>
{
public static readonly long[] Value=A029204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029204.Bytes);
public long this[int i]=>Value[i];

public static A029204Inst Instance=new A029204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029205
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,4L,1L,4L,2L,4L,4L,5L,4L,7L,4L,10L,5L,10L,7L,11L,10L,13L,10L,16L,11L,20L,13L,21L,16L,23L,20L,26L,21L,30L,23L,36L,26L,38L,30L,41L,36L,45L,38L,51L,41L,59L,45L,62L,51L,66L,59L,72L,62L,80L,66L,90L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029205Inst : IEnumerable<long>
{
public static readonly long[] Value=A029205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029205.Bytes);
public long this[int i]=>Value[i];

public static A029205Inst Instance=new A029205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029206
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,3L,2L,3L,3L,3L,4L,5L,4L,6L,5L,7L,7L,8L,8L,10L,9L,12L,11L,13L,13L,15L,15L,18L,17L,20L,20L,22L,23L,25L,25L,29L,28L,32L,32L,35L,36L,39L,39L,44L,43L,48L,48L,52L,53L,57L,58L,63L,63L,68L,69L,74L,75L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029206Inst : IEnumerable<long>
{
public static readonly long[] Value=A029206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029206.Bytes);
public long this[int i]=>Value[i];

public static A029206Inst Instance=new A029206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029207
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,3L,1L,4L,2L,4L,3L,5L,4L,6L,4L,8L,5L,9L,6L,11L,8L,12L,9L,14L,11L,16L,12L,19L,14L,21L,16L,24L,19L,26L,21L,30L,24L,33L,26L,37L,30L,40L,33L,45L,37L,49L,40L,54L,45L,58L,49L,64L,54L,69L,58L,76L,64L,81L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029207Inst : IEnumerable<long>
{
public static readonly long[] Value=A029207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029207.Bytes);
public long this[int i]=>Value[i];

public static A029207Inst Instance=new A029207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029208
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,2L,3L,2L,3L,2L,4L,4L,4L,4L,5L,6L,8L,6L,8L,7L,10L,10L,10L,11L,12L,14L,16L,14L,17L,16L,20L,20L,21L,22L,24L,26L,29L,27L,31L,30L,35L,36L,37L,39L,41L,44L,48L,46L,51L,50L,57L,58L,60L,62L,65L,69L,74L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029208Inst : IEnumerable<long>
{
public static readonly long[] Value=A029208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029208.Bytes);
public long this[int i]=>Value[i];

public static A029208Inst Instance=new A029208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029209
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,2L,2L,3L,2L,3L,3L,4L,4L,4L,5L,5L,7L,6L,8L,7L,9L,9L,10L,11L,11L,13L,13L,15L,15L,17L,17L,19L,20L,21L,23L,23L,26L,26L,29L,29L,32L,33L,35L,37L,38L,41L,42L,45L,46L,49L,51L,54L,56L,58L,61L,63L,67L,68L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029209Inst : IEnumerable<long>
{
public static readonly long[] Value=A029209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029209.Bytes);
public long this[int i]=>Value[i];

public static A029209Inst Instance=new A029209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029210
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,2L,2L,2L,3L,2L,4L,3L,4L,4L,5L,5L,6L,6L,7L,7L,9L,8L,10L,10L,11L,12L,13L,13L,15L,15L,17L,17L,20L,19L,22L,22L,24L,25L,27L,27L,30L,31L,33L,34L,37L,37L,41L,41L,44L,45L,49L,49L,53L,54L,57L,59L,63L,63L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029210Inst : IEnumerable<long>
{
public static readonly long[] Value=A029210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029210.Bytes);
public long this[int i]=>Value[i];

public static A029210Inst Instance=new A029210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029211
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,3L,2L,3L,2L,3L,4L,4L,4L,4L,4L,7L,6L,8L,6L,8L,9L,10L,10L,10L,10L,14L,13L,16L,14L,16L,18L,19L,20L,20L,20L,25L,24L,28L,26L,29L,31L,33L,34L,35L,35L,41L,40L,45L,43L,47L,50L,52L,54L,55L,56L,63L,62L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029211Inst : IEnumerable<long>
{
public static readonly long[] Value=A029211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029211.Bytes);
public long this[int i]=>Value[i];

public static A029211Inst Instance=new A029211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029212
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,3L,1L,4L,1L,4L,3L,4L,4L,4L,4L,7L,4L,9L,4L,10L,7L,10L,9L,10L,10L,14L,10L,17L,10L,19L,14L,20L,17L,20L,19L,25L,20L,29L,20L,32L,25L,34L,29L,35L,32L,41L,34L,46L,35L,50L,41L,53L,46L,55L,50L,63L,53L,69L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029212Inst : IEnumerable<long>
{
public static readonly long[] Value=A029212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029212.Bytes);
public long this[int i]=>Value[i];

public static A029212Inst Instance=new A029212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029277
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,0L,1L,2L,1L,2L,4L,1L,2L,5L,2L,4L,7L,2L,5L,8L,4L,7L,11L,5L,8L,13L,7L,11L,17L,8L,13L,19L,11L,17L,24L,13L,19L,27L,17L,24L,33L,19L,27L,37L,24L,33L,44L,27L,37L,49L,33L,44L,57L,37L,49L,63L,44L,57L,73L,49L,63L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029277Inst : IEnumerable<long>
{
public static readonly long[] Value=A029277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029277.Bytes);
public long this[int i]=>Value[i];

public static A029277Inst Instance=new A029277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029278
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,2L,1L,2L,2L,2L,3L,3L,4L,4L,4L,5L,5L,6L,7L,7L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,20L,21L,22L,24L,25L,27L,28L,30L,32L,33L,36L,37L,39L,42L,43L,46L,48L,50L,53L,55L,58L,61L,63L,66L,69L,72L,75L,78L,82L,85L,88L,92L,95L,99L,103L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029278Inst : IEnumerable<long>
{
public static readonly long[] Value=A029278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029278.Bytes);
public long this[int i]=>Value[i];

public static A029278Inst Instance=new A029278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029279
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,3L,1L,2L,3L,2L,4L,3L,4L,4L,4L,7L,5L,6L,7L,7L,9L,8L,10L,10L,10L,14L,12L,13L,15L,15L,18L,17L,19L,20L,20L,25L,23L,25L,27L,27L,32L,30L,33L,35L,35L,41L,39L,42L,44L,45L,51L,49L,53L,55L,56L,63L,61L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029279Inst : IEnumerable<long>
{
public static readonly long[] Value=A029279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029279.Bytes);
public long this[int i]=>Value[i];

public static A029279Inst Instance=new A029279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029280
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,6L,6L,6L,7L,8L,8L,9L,10L,10L,11L,12L,13L,14L,14L,16L,17L,17L,19L,20L,21L,22L,24L,25L,26L,28L,29L,31L,32L,34L,36L,37L,39L,41L,43L,45L,47L,49L,51L,53L,56L,58L,60L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029280Inst : IEnumerable<long>
{
public static readonly long[] Value=A029280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029280.Bytes);
public long this[int i]=>Value[i];

public static A029280Inst Instance=new A029280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029281
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,2L,1L,3L,2L,2L,4L,2L,4L,4L,4L,5L,5L,6L,5L,8L,7L,7L,10L,8L,10L,11L,11L,12L,13L,14L,14L,17L,16L,17L,20L,19L,21L,23L,23L,24L,27L,27L,28L,32L,31L,33L,36L,36L,38L,41L,42L,43L,47L,47L,49L,54L,53L,56L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029281Inst : IEnumerable<long>
{
public static readonly long[] Value=A029281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029281.Bytes);
public long this[int i]=>Value[i];

public static A029281Inst Instance=new A029281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029282
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,2L,2L,1L,2L,2L,2L,3L,3L,3L,4L,5L,4L,5L,6L,5L,7L,8L,7L,9L,10L,9L,11L,12L,11L,14L,15L,14L,17L,18L,17L,20L,21L,21L,24L,25L,25L,28L,30L,29L,32L,35L,34L,38L,40L,39L,44L,46L,45L,50L,52L,52L,57L,59L,59L,64L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029282Inst : IEnumerable<long>
{
public static readonly long[] Value=A029282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029282.Bytes);
public long this[int i]=>Value[i];

public static A029282Inst Instance=new A029282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029283
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,2L,1L,2L,2L,1L,3L,2L,3L,4L,2L,5L,4L,5L,6L,4L,7L,7L,7L,9L,7L,10L,10L,11L,12L,11L,14L,14L,15L,17L,15L,19L,19L,21L,22L,21L,25L,25L,27L,29L,27L,33L,32L,35L,37L,35L,41L,41L,43L,47L,44L,51L,51L,54L,57L,55L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029283Inst : IEnumerable<long>
{
public static readonly long[] Value=A029283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029283.Bytes);
public long this[int i]=>Value[i];

public static A029283Inst Instance=new A029283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029284
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,2L,1L,1L,3L,1L,2L,3L,2L,4L,3L,3L,5L,4L,5L,6L,5L,7L,7L,7L,9L,8L,9L,11L,10L,12L,13L,12L,15L,15L,15L,18L,17L,19L,21L,20L,23L,24L,24L,27L,27L,29L,31L,31L,34L,35L,36L,39L,40L,42L,44L,45L,48L,50L,51L,54L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029284Inst : IEnumerable<long>
{
public static readonly long[] Value=A029284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029284.Bytes);
public long this[int i]=>Value[i];

public static A029284Inst Instance=new A029284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029285
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,2L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,3L,5L,5L,4L,6L,7L,6L,7L,8L,8L,9L,10L,9L,12L,12L,11L,14L,15L,14L,16L,17L,18L,19L,20L,20L,23L,24L,23L,26L,29L,27L,30L,32L,32L,35L,36L,36L,41L,41L,41L,45L,48L,47L,50L,53L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029285Inst : IEnumerable<long>
{
public static readonly long[] Value=A029285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029285.Bytes);
public long this[int i]=>Value[i];

public static A029285Inst Instance=new A029285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029286
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,2L,2L,1L,2L,2L,2L,4L,2L,2L,5L,4L,5L,5L,4L,6L,7L,7L,6L,8L,9L,9L,12L,9L,10L,14L,12L,14L,15L,14L,17L,19L,19L,18L,21L,22L,22L,27L,24L,25L,31L,29L,32L,33L,32L,36L,39L,40L,39L,43L,45L,46L,52L,48L,50L,58L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029286Inst : IEnumerable<long>
{
public static readonly long[] Value=A029286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029286.Bytes);
public long this[int i]=>Value[i];

public static A029286Inst Instance=new A029286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029287
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,2L,1L,2L,2L,1L,3L,3L,2L,3L,4L,3L,5L,5L,4L,6L,6L,6L,7L,8L,7L,9L,10L,9L,11L,12L,11L,13L,15L,13L,16L,17L,16L,19L,20L,19L,22L,24L,22L,26L,27L,26L,30L,31L,30L,34L,36L,35L,39L,40L,40L,44L,46L,45L,49L,52L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029287Inst : IEnumerable<long>
{
public static readonly long[] Value=A029287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029287.Bytes);
public long this[int i]=>Value[i];

public static A029287Inst Instance=new A029287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029288
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,2L,1L,1L,3L,1L,2L,4L,1L,3L,5L,2L,4L,6L,3L,5L,8L,4L,6L,10L,5L,8L,12L,6L,10L,14L,8L,12L,17L,10L,14L,20L,12L,17L,23L,14L,20L,27L,17L,23L,31L,20L,27L,35L,23L,31L,40L,27L,35L,45L,31L,40L,51L,35L,45L,57L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029288Inst : IEnumerable<long>
{
public static readonly long[] Value=A029288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029288.Bytes);
public long this[int i]=>Value[i];

public static A029288Inst Instance=new A029288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029289
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L,3L,3L,2L,3L,3L,5L,5L,4L,5L,5L,7L,7L,6L,7L,7L,10L,10L,9L,11L,10L,13L,14L,12L,14L,14L,17L,18L,17L,19L,19L,22L,23L,22L,24L,24L,28L,29L,28L,31L,31L,35L,36L,35L,38L,38L,43L,44L,43L,47L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029289Inst : IEnumerable<long>
{
public static readonly long[] Value=A029289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029289.Bytes);
public long this[int i]=>Value[i];

public static A029289Inst Instance=new A029289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029290
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,2L,1L,2L,2L,1L,4L,2L,2L,4L,2L,5L,4L,4L,5L,5L,7L,5L,7L,7L,6L,11L,7L,9L,11L,9L,13L,12L,12L,13L,14L,17L,14L,18L,17L,17L,23L,19L,21L,24L,22L,27L,26L,27L,28L,30L,33L,31L,35L,35L,35L,43L,38L,41L,45L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029290Inst : IEnumerable<long>
{
public static readonly long[] Value=A029290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029290.Bytes);
public long this[int i]=>Value[i];

public static A029290Inst Instance=new A029290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029291
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,2L,2L,1L,2L,3L,2L,3L,3L,2L,4L,4L,4L,5L,5L,5L,6L,7L,6L,7L,8L,7L,9L,10L,9L,11L,12L,11L,13L,14L,13L,15L,16L,15L,18L,19L,18L,21L,22L,21L,24L,25L,24L,27L,28L,28L,31L,32L,32L,35L,37L,36L,39L,41L,40L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029291Inst : IEnumerable<long>
{
public static readonly long[] Value=A029291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029291.Bytes);
public long this[int i]=>Value[i];

public static A029291Inst Instance=new A029291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029292
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,1L,1L,2L,1L,1L,3L,2L,3L,4L,3L,3L,5L,4L,5L,7L,6L,6L,9L,7L,8L,11L,10L,10L,14L,12L,13L,16L,15L,16L,20L,18L,20L,23L,22L,23L,28L,26L,28L,32L,31L,32L,38L,36L,38L,43L,42L,43L,50L,48L,51L,56L,55L,57L,64L,62L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029292Inst : IEnumerable<long>
{
public static readonly long[] Value=A029292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029292.Bytes);
public long this[int i]=>Value[i];

public static A029292Inst Instance=new A029292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029309
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,3L,2L,2L,3L,3L,3L,4L,4L,4L,6L,4L,5L,7L,6L,6L,8L,8L,8L,9L,9L,10L,12L,10L,12L,14L,13L,13L,16L,16L,16L,18L,18L,19L,22L,20L,22L,25L,24L,24L,28L,28L,29L,31L,31L,33L,36L,34L,37L,41L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029309Inst : IEnumerable<long>
{
public static readonly long[] Value=A029309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029309.Bytes);
public long this[int i]=>Value[i];

public static A029309Inst Instance=new A029309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029310
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,0L,2L,2L,0L,2L,2L,1L,2L,3L,2L,3L,4L,3L,4L,4L,4L,5L,5L,5L,7L,7L,6L,9L,8L,7L,10L,10L,9L,12L,13L,11L,14L,15L,13L,16L,17L,16L,19L,20L,19L,22L,23L,22L,25L,26L,25L,29L,30L,29L,33L,34L,33L,37L,38L,37L,42L,43L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029310Inst : IEnumerable<long>
{
public static readonly long[] Value=A029310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029310.Bytes);
public long this[int i]=>Value[i];

public static A029310Inst Instance=new A029310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029311
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,0L,2L,1L,1L,2L,1L,2L,2L,2L,2L,4L,2L,3L,5L,3L,4L,5L,5L,4L,7L,6L,6L,8L,7L,8L,9L,9L,9L,12L,10L,11L,14L,12L,13L,16L,15L,15L,19L,17L,18L,21L,20L,21L,24L,23L,24L,28L,26L,28L,31L,30L,31L,35L,34L,35L,40L,38L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029311Inst : IEnumerable<long>
{
public static readonly long[] Value=A029311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029311.Bytes);
public long this[int i]=>Value[i];

public static A029311Inst Instance=new A029311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029312
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,0L,2L,1L,0L,3L,1L,1L,3L,2L,1L,4L,3L,1L,6L,3L,2L,7L,4L,3L,8L,6L,3L,10L,7L,4L,12L,8L,6L,14L,10L,7L,16L,12L,8L,19L,14L,10L,22L,16L,12L,25L,19L,14L,28L,22L,16L,32L,25L,19L,36L,28L,22L,40L,32L,25L,45L,36L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029312Inst : IEnumerable<long>
{
public static readonly long[] Value=A029312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029312.Bytes);
public long this[int i]=>Value[i];

public static A029312Inst Instance=new A029312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029313
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,2L,1L,1L,2L,2L,1L,2L,3L,2L,2L,4L,4L,3L,4L,5L,4L,4L,6L,6L,5L,7L,8L,7L,8L,9L,9L,9L,10L,11L,11L,12L,13L,14L,14L,15L,16L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029313Inst : IEnumerable<long>
{
public static readonly long[] Value=A029313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029313.Bytes);
public long this[int i]=>Value[i];

public static A029313Inst Instance=new A029313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029314
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,2L,0L,2L,2L,1L,2L,2L,2L,2L,3L,3L,3L,4L,3L,5L,4L,4L,6L,5L,5L,7L,7L,6L,8L,9L,7L,10L,10L,9L,11L,12L,11L,13L,14L,13L,15L,16L,15L,18L,18L,18L,20L,21L,20L,23L,24L,23L,26L,27L,26L,30L,30L,30L,33L,34L,33L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029314Inst : IEnumerable<long>
{
public static readonly long[] Value=A029314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029314.Bytes);
public long this[int i]=>Value[i];

public static A029314Inst Instance=new A029314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029315
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,2L,1L,2L,2L,1L,2L,3L,2L,2L,4L,3L,3L,5L,4L,4L,5L,5L,5L,6L,6L,6L,8L,7L,8L,10L,8L,9L,11L,10L,10L,13L,12L,12L,15L,14L,15L,17L,16L,17L,19L,18L,19L,22L,21L,22L,25L,24L,25L,28L,27L,28L,31L,30L,31L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029315Inst : IEnumerable<long>
{
public static readonly long[] Value=A029315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029315.Bytes);
public long this[int i]=>Value[i];

public static A029315Inst Instance=new A029315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029316
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,4L,3L,3L,4L,3L,3L,5L,4L,5L,7L,6L,6L,8L,6L,7L,9L,8L,9L,12L,10L,11L,13L,12L,12L,15L,14L,15L,18L,17L,17L,21L,19L,20L,23L,22L,23L,27L,25L,27L,30L,29L,30L,34L,32L,34L,38L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029316Inst : IEnumerable<long>
{
public static readonly long[] Value=A029316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029316.Bytes);
public long this[int i]=>Value[i];

public static A029316Inst Instance=new A029316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029317
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,1L,2L,0L,2L,2L,0L,2L,2L,1L,3L,3L,2L,4L,3L,3L,4L,4L,4L,5L,6L,5L,6L,7L,6L,7L,9L,7L,9L,11L,8L,11L,12L,10L,13L,14L,12L,16L,16L,14L,18L,18L,17L,20L,21L,20L,23L,24L,23L,26L,27L,26L,29L,31L,29L,33L,35L,33L,37L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029317Inst : IEnumerable<long>
{
public static readonly long[] Value=A029317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029317.Bytes);
public long this[int i]=>Value[i];

public static A029317Inst Instance=new A029317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029318
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,1L,2L,0L,1L,3L,0L,1L,3L,1L,2L,4L,1L,3L,5L,1L,3L,7L,2L,4L,8L,3L,5L,9L,3L,7L,11L,4L,8L,14L,5L,9L,15L,7L,11L,17L,8L,14L,20L,9L,15L,24L,11L,17L,26L,14L,20L,29L,15L,24L,33L,17L,26L,38L,20L,29L,41L,24L,33L,45L,26L,38L,50L,29L,41L,57L,33L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029318Inst : IEnumerable<long>
{
public static readonly long[] Value=A029318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029318.Bytes);
public long this[int i]=>Value[i];

public static A029318Inst Instance=new A029318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029319
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,2L,3L,3L,3L,4L,3L,4L,4L,4L,5L,5L,5L,7L,6L,7L,8L,7L,8L,9L,8L,10L,10L,11L,12L,12L,13L,14L,13L,15L,15L,16L,17L,18L,19L,20L,20L,22L,22L,23L,24L,25L,26L,28L,28L,30L,31L,32L,33L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029319Inst : IEnumerable<long>
{
public static readonly long[] Value=A029319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029319.Bytes);
public long this[int i]=>Value[i];

public static A029319Inst Instance=new A029319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029320
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,3L,2L,3L,3L,3L,3L,5L,3L,4L,5L,5L,4L,7L,5L,7L,7L,7L,7L,10L,7L,9L,10L,11L,9L,13L,11L,13L,13L,14L,13L,18L,14L,17L,18L,19L,17L,22L,19L,23L,22L,24L,23L,29L,24L,28L,29L,31L,28L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029320Inst : IEnumerable<long>
{
public static readonly long[] Value=A029320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029320.Bytes);
public long this[int i]=>Value[i];

public static A029320Inst Instance=new A029320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029321
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,2L,2L,0L,2L,2L,1L,2L,2L,2L,3L,2L,3L,4L,4L,3L,4L,5L,4L,4L,6L,5L,6L,7L,6L,8L,9L,6L,9L,10L,8L,10L,11L,10L,13L,12L,12L,15L,15L,13L,16L,17L,16L,17L,19L,19L,21L,21L,21L,24L,25L,22L,26L,28L,26L,28L,31L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029321Inst : IEnumerable<long>
{
public static readonly long[] Value=A029321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029321.Bytes);
public long this[int i]=>Value[i];

public static A029321Inst Instance=new A029321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029322
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,0L,2L,1L,1L,2L,1L,1L,2L,1L,1L,3L,2L,3L,4L,3L,3L,4L,3L,3L,5L,4L,5L,7L,6L,6L,8L,6L,6L,9L,7L,8L,11L,10L,10L,13L,11L,11L,14L,12L,13L,16L,15L,16L,19L,17L,18L,21L,19L,20L,23L,22L,23L,27L,25L,26L,30L,28L,29L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029322Inst : IEnumerable<long>
{
public static readonly long[] Value=A029322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029322.Bytes);
public long this[int i]=>Value[i];

public static A029322Inst Instance=new A029322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029323
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,0L,2L,1L,0L,3L,1L,0L,3L,1L,0L,4L,2L,1L,5L,3L,1L,6L,3L,1L,7L,4L,2L,9L,5L,3L,10L,6L,3L,12L,7L,4L,14L,9L,5L,16L,10L,6L,18L,12L,7L,21L,14L,9L,23L,16L,10L,26L,18L,12L,29L,21L,14L,33L,23L,16L,36L,26L,18L,40L,29L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029323Inst : IEnumerable<long>
{
public static readonly long[] Value=A029323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029323.Bytes);
public long this[int i]=>Value[i];

public static A029323Inst Instance=new A029323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029324
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,1L,3L,0L,1L,3L,0L,1L,4L,0L,2L,5L,1L,3L,6L,1L,3L,7L,1L,4L,8L,2L,5L,10L,3L,6L,12L,3L,7L,13L,4L,8L,15L,5L,10L,18L,6L,12L,20L,7L,13L,22L,8L,15L,25L,10L,18L,28L,12L,20L,31L,13L,22L,34L,15L,25L,38L,18L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029324Inst : IEnumerable<long>
{
public static readonly long[] Value=A029324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029324.Bytes);
public long this[int i]=>Value[i];

public static A029324Inst Instance=new A029324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029357
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,2L,1L,2L,0L,2L,1L,3L,1L,3L,1L,4L,2L,5L,2L,5L,2L,6L,3L,7L,3L,8L,4L,9L,5L,10L,5L,11L,6L,12L,7L,14L,8L,15L,9L,17L,10L,18L,11L,20L,12L,22L,14L,24L,15L,26L,17L,28L,18L,30L,20L,33L,22L,35L,24L,38L,26L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029357Inst : IEnumerable<long>
{
public static readonly long[] Value=A029357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029357.Bytes);
public long this[int i]=>Value[i];

public static A029357Inst Instance=new A029357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029358
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,3L,0L,1L,1L,3L,1L,3L,1L,3L,1L,4L,3L,6L,1L,4L,3L,7L,3L,7L,3L,7L,4L,9L,6L,11L,4L,9L,7L,13L,7L,13L,7L,14L,9L,16L,11L,19L,9L,17L,13L,22L,13L,22L,14L,24L,16L,26L,19L,30L,17L,28L,22L,34L,22L,35L,24L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029358Inst : IEnumerable<long>
{
public static readonly long[] Value=A029358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029358.Bytes);
public long this[int i]=>Value[i];

public static A029358Inst Instance=new A029358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029359
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,1L,2L,4L,2L,2L,2L,4L,3L,3L,4L,6L,5L,4L,5L,7L,6L,6L,7L,10L,8L,8L,9L,12L,10L,10L,12L,15L,13L,13L,15L,18L,16L,16L,18L,22L,20L,20L,22L,26L,24L,24L,26L,31L,29L,29L,31L,36L,34L,34L,37L,42L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029359Inst : IEnumerable<long>
{
public static readonly long[] Value=A029359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029359.Bytes);
public long this[int i]=>Value[i];

public static A029359Inst Instance=new A029359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029360
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,2L,0L,1L,1L,2L,0L,2L,2L,3L,1L,3L,2L,4L,2L,4L,3L,6L,3L,5L,4L,8L,4L,7L,6L,10L,5L,9L,8L,12L,7L,12L,10L,15L,9L,15L,12L,18L,12L,18L,15L,22L,15L,22L,18L,26L,18L,26L,22L,31L,22L,31L,26L,36L,26L,36L,31L,42L,31L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029360Inst : IEnumerable<long>
{
public static readonly long[] Value=A029360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029360.Bytes);
public long this[int i]=>Value[i];

public static A029360Inst Instance=new A029360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029361
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,2L,2L,0L,1L,3L,3L,0L,2L,4L,3L,1L,4L,5L,4L,2L,5L,6L,5L,4L,7L,7L,7L,6L,8L,9L,9L,8L,10L,11L,12L,10L,12L,14L,15L,12L,15L,17L,18L,15L,18L,21L,21L,18L,22L,25L,25L,22L,26L,29L,29L,26L,31L,34L,34L,31L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029361Inst : IEnumerable<long>
{
public static readonly long[] Value=A029361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029361.Bytes);
public long this[int i]=>Value[i];

public static A029361Inst Instance=new A029361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029362
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,1L,3L,0L,1L,2L,4L,0L,1L,3L,5L,1L,2L,4L,7L,1L,3L,5L,9L,2L,4L,7L,11L,3L,5L,9L,14L,4L,7L,11L,17L,5L,9L,14L,20L,7L,11L,17L,24L,9L,14L,20L,28L,11L,17L,24L,33L,14L,20L,28L,38L,17L,24L,33L,44L,20L,28L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029362Inst : IEnumerable<long>
{
public static readonly long[] Value=A029362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029362.Bytes);
public long this[int i]=>Value[i];

public static A029362Inst Instance=new A029362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029363
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,3L,3L,4L,4L,4L,5L,6L,5L,6L,6L,7L,6L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,14L,14L,15L,15L,17L,17L,18L,18L,20L,20L,22L,22L,24L,24L,26L,26L,28L,28L,30L,31L,33L,33L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029363Inst : IEnumerable<long>
{
public static readonly long[] Value=A029363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029363.Bytes);
public long this[int i]=>Value[i];

public static A029363Inst Instance=new A029363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029364
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,2L,1L,1L,1L,2L,2L,1L,3L,2L,3L,2L,4L,3L,3L,4L,4L,5L,4L,6L,5L,6L,6L,7L,7L,7L,9L,8L,9L,9L,11L,10L,11L,12L,13L,13L,13L,15L,15L,16L,16L,18L,18L,19L,20L,21L,22L,22L,24L,24L,26L,26L,28L,29L,30L,31L,32L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029364Inst : IEnumerable<long>
{
public static readonly long[] Value=A029364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029364.Bytes);
public long this[int i]=>Value[i];

public static A029364Inst Instance=new A029364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029365
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,2L,1L,1L,1L,3L,1L,2L,2L,3L,3L,2L,3L,4L,4L,3L,4L,6L,4L,5L,5L,7L,6L,6L,7L,9L,8L,7L,9L,11L,9L,10L,11L,13L,12L,12L,13L,16L,15L,14L,16L,19L,17L,18L,19L,22L,21L,21L,22L,26L,25L,24L,27L,30L,28L,29L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029365Inst : IEnumerable<long>
{
public static readonly long[] Value=A029365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029365.Bytes);
public long this[int i]=>Value[i];

public static A029365Inst Instance=new A029365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029366
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,2L,1L,0L,2L,2L,1L,1L,3L,2L,2L,3L,4L,2L,3L,4L,4L,3L,5L,5L,5L,5L,7L,6L,6L,7L,8L,7L,8L,9L,10L,9L,11L,11L,12L,11L,13L,13L,14L,14L,16L,16L,17L,17L,19L,19L,20L,20L,22L,22L,24L,24L,26L,26L,28L,28L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029366Inst : IEnumerable<long>
{
public static readonly long[] Value=A029366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029366.Bytes);
public long this[int i]=>Value[i];

public static A029366Inst Instance=new A029366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029367
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,2L,0L,2L,1L,2L,1L,2L,2L,3L,2L,3L,2L,5L,2L,4L,3L,6L,3L,5L,5L,7L,4L,7L,6L,9L,5L,9L,7L,11L,7L,11L,9L,13L,9L,13L,11L,16L,11L,16L,13L,19L,13L,19L,16L,22L,16L,22L,19L,26L,19L,26L,22L,30L,22L,30L,26L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029367Inst : IEnumerable<long>
{
public static readonly long[] Value=A029367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029367.Bytes);
public long this[int i]=>Value[i];

public static A029367Inst Instance=new A029367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029368
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,2L,2L,0L,1L,2L,2L,0L,2L,3L,2L,1L,3L,4L,3L,2L,4L,4L,4L,3L,5L,5L,5L,5L,6L,7L,7L,6L,7L,8L,9L,7L,9L,10L,11L,9L,11L,13L,13L,11L,13L,15L,15L,13L,16L,18L,18L,16L,19L,21L,21L,19L,22L,24L,24L,22L,26L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029368Inst : IEnumerable<long>
{
public static readonly long[] Value=A029368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029368.Bytes);
public long this[int i]=>Value[i];

public static A029368Inst Instance=new A029368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029369
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,2L,1L,1L,0L,2L,1L,1L,0L,3L,2L,3L,1L,4L,2L,3L,1L,5L,3L,5L,3L,7L,4L,6L,3L,8L,5L,8L,5L,11L,7L,10L,6L,13L,8L,12L,8L,16L,11L,15L,10L,19L,13L,18L,12L,22L,16L,22L,15L,26L,19L,26L,18L,30L,22L,30L,22L,35L,26L,35L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029369Inst : IEnumerable<long>
{
public static readonly long[] Value=A029369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029369.Bytes);
public long this[int i]=>Value[i];

public static A029369Inst Instance=new A029369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029370
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,1L,2L,4L,2L,2L,2L,5L,3L,3L,4L,6L,4L,4L,5L,7L,6L,5L,7L,9L,7L,7L,8L,11L,9L,9L,10L,14L,11L,11L,12L,16L,14L,13L,15L,19L,17L,16L,18L,22L,20L,19L,21L,26L,23L,23L,25L,30L,27L,27L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029370Inst : IEnumerable<long>
{
public static readonly long[] Value=A029370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029370.Bytes);
public long this[int i]=>Value[i];

public static A029370Inst Instance=new A029370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029371
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,2L,1L,0L,0L,3L,1L,0L,0L,4L,2L,1L,0L,5L,3L,1L,0L,7L,4L,2L,1L,8L,5L,3L,1L,10L,7L,4L,2L,13L,8L,5L,3L,15L,10L,7L,4L,18L,13L,8L,5L,22L,15L,10L,7L,25L,18L,13L,8L,29L,22L,15L,10L,34L,25L,18L,13L,38L,29L,22L,15L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029371Inst : IEnumerable<long>
{
public static readonly long[] Value=A029371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029371.Bytes);
public long this[int i]=>Value[i];

public static A029371Inst Instance=new A029371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029372
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,1L,1L,2L,0L,1L,1L,3L,0L,2L,2L,4L,1L,3L,2L,5L,1L,4L,3L,6L,2L,6L,4L,8L,3L,7L,5L,9L,4L,9L,6L,12L,6L,11L,8L,14L,7L,13L,9L,17L,9L,16L,12L,20L,11L,19L,14L,23L,13L,22L,17L,27L,16L,26L,20L,31L,19L,30L,23L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029372Inst : IEnumerable<long>
{
public static readonly long[] Value=A029372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029372.Bytes);
public long this[int i]=>Value[i];

public static A029372Inst Instance=new A029372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029437
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,2L,2L,2L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,3L,4L,4L,5L,4L,5L,6L,6L,5L,6L,7L,7L,6L,7L,8L,8L,7L,9L,10L,10L,9L,10L,11L,11L,10L,12L,13L,13L,12L,14L,15L,15L,14L,16L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029437Inst : IEnumerable<long>
{
public static readonly long[] Value=A029437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029437.Bytes);
public long this[int i]=>Value[i];

public static A029437Inst Instance=new A029437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029438
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,2L,1L,2L,2L,1L,1L,1L,2L,1L,3L,3L,3L,3L,3L,3L,2L,3L,3L,4L,4L,5L,5L,5L,5L,5L,5L,5L,6L,6L,7L,7L,8L,8L,8L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,13L,14L,14L,15L,15L,16L,17L,17L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029438Inst : IEnumerable<long>
{
public static readonly long[] Value=A029438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029438.Bytes);
public long this[int i]=>Value[i];

public static A029438Inst Instance=new A029438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029439
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,2L,3L,3L,3L,4L,4L,4L,4L,5L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,7L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,13L,12L,14L,14L,14L,15L,16L,15L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029439Inst : IEnumerable<long>
{
public static readonly long[] Value=A029439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029439.Bytes);
public long this[int i]=>Value[i];

public static A029439Inst Instance=new A029439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029440
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,3L,2L,3L,3L,3L,3L,4L,3L,3L,4L,4L,4L,5L,5L,5L,6L,5L,6L,6L,6L,6L,7L,7L,7L,9L,8L,9L,9L,9L,9L,10L,10L,10L,12L,11L,12L,13L,13L,13L,14L,14L,14L,16L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029440Inst : IEnumerable<long>
{
public static readonly long[] Value=A029440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029440.Bytes);
public long this[int i]=>Value[i];

public static A029440Inst Instance=new A029440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029441
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,2L,3L,3L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,7L,7L,8L,8L,8L,8L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,12L,12L,13L,13L,14L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029441Inst : IEnumerable<long>
{
public static readonly long[] Value=A029441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029441.Bytes);
public long this[int i]=>Value[i];

public static A029441Inst Instance=new A029441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029442
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,2L,2L,2L,1L,1L,0L,1L,1L,2L,3L,3L,3L,3L,2L,2L,2L,2L,3L,4L,4L,5L,4L,5L,4L,4L,4L,5L,5L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L,9L,9L,10L,10L,11L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,21L,21L,22L,22L,23L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029442Inst : IEnumerable<long>
{
public static readonly long[] Value=A029442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029442.Bytes);
public long this[int i]=>Value[i];

public static A029442Inst Instance=new A029442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029443
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,2L,1L,2L,1L,1L,0L,2L,1L,2L,2L,3L,2L,3L,1L,3L,2L,3L,2L,5L,3L,4L,3L,5L,3L,5L,3L,6L,5L,6L,4L,8L,5L,7L,5L,8L,6L,9L,6L,10L,8L,10L,7L,12L,8L,11L,9L,13L,10L,14L,10L,15L,12L,15L,11L,18L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029443Inst : IEnumerable<long>
{
public static readonly long[] Value=A029443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029443.Bytes);
public long this[int i]=>Value[i];

public static A029443Inst Instance=new A029443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029444
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,3L,3L,2L,3L,4L,2L,3L,3L,4L,4L,4L,4L,6L,5L,4L,5L,6L,5L,5L,6L,7L,7L,7L,7L,9L,8L,7L,8L,10L,8L,9L,10L,11L,11L,11L,11L,13L,12L,11L,13L,15L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029444Inst : IEnumerable<long>
{
public static readonly long[] Value=A029444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029444.Bytes);
public long this[int i]=>Value[i];

public static A029444Inst Instance=new A029444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029445
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,2L,1L,2L,1L,2L,0L,1L,1L,2L,1L,3L,2L,4L,2L,3L,2L,3L,1L,3L,2L,5L,3L,5L,4L,6L,3L,5L,3L,6L,3L,6L,5L,8L,5L,8L,6L,9L,5L,8L,6L,10L,6L,10L,8L,12L,8L,12L,9L,13L,8L,13L,10L,15L,10L,15L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029445Inst : IEnumerable<long>
{
public static readonly long[] Value=A029445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029445.Bytes);
public long this[int i]=>Value[i];

public static A029445Inst Instance=new A029445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029446
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,2L,2L,2L,1L,1L,0L,0L,1L,1L,2L,3L,3L,3L,3L,2L,1L,2L,1L,2L,3L,4L,4L,5L,4L,4L,4L,3L,3L,4L,4L,5L,6L,6L,6L,7L,6L,6L,6L,6L,6L,8L,7L,8L,9L,9L,9L,10L,9L,9L,10L,10L,10L,12L,11L,12L,13L,13L,13L,14L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029446Inst : IEnumerable<long>
{
public static readonly long[] Value=A029446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029446.Bytes);
public long this[int i]=>Value[i];

public static A029446Inst Instance=new A029446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029447
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,16L,26L,32L,38L,40L,46L,64L,96L,128L,138L,192L,228L,256L,512L,640L,1024L,2048L,4096L,4192L,4766L,4790L,5142L,5952L,6144L,6866L,8122L,8192L,8448L,10240L,11283L,11392L,12288L,14780L,15360L,15744L,16384L,17408L,20841L,20866L,32768L,58496L,59104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029447Inst : IEnumerable<long>
{
public static readonly long[] Value=A029447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029447.Bytes);
public long this[int i]=>Value[i];

public static A029447Inst Instance=new A029447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029448
{
public static readonly long[] Value={ 1L,3L,4L,9L,12L,27L,72L,81L,104L,216L,219L,243L,324L,729L,756L,972L,2187L,3888L,3921L,6561L,9477L,11664L,16848L,19683L,21156L,22599L,26244L,26811L,29245L,30132L,32805L,37665L,38788L,39852L,40905L,45756L,46965L,47871L,59049L,78732L,80676L,82380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029448Inst : IEnumerable<long>
{
public static readonly long[] Value=A029448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029448.Bytes);
public long this[int i]=>Value[i];

public static A029448Inst Instance=new A029448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029449
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,12L,14L,16L,18L,21L,24L,26L,28L,32L,36L,42L,48L,52L,56L,58L,63L,64L,72L,84L,96L,108L,126L,128L,144L,147L,168L,189L,192L,216L,252L,256L,276L,328L,362L,384L,456L,492L,512L,656L,768L,896L,904L,984L,1024L,1116L,1152L,1211L,1251L,1344L,1536L,1736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029449Inst : IEnumerable<long>
{
public static readonly long[] Value=A029449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029449.Bytes);
public long this[int i]=>Value[i];

public static A029449Inst Instance=new A029449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029450
{
public static readonly long[] Value={ 1L,5L,16L,23L,25L,35L,80L,125L,160L,205L,352L,625L,800L,1120L,1875L,2221L,3125L,6000L,9375L,10000L,11120L,15625L,19184L,21875L,30000L,50000L,55135L,58775L,66800L,71875L,78125L,88000L,88385L,171875L,200000L,390625L,472000L,715189L,734375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029450Inst : IEnumerable<long>
{
public static readonly long[] Value=A029450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029450.Bytes);
public long this[int i]=>Value[i];

public static A029450Inst Instance=new A029450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029451
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,10L,12L,15L,18L,20L,22L,25L,30L,36L,40L,45L,50L,54L,60L,68L,72L,75L,90L,100L,103L,108L,116L,120L,132L,135L,150L,180L,200L,216L,225L,226L,240L,252L,270L,274L,280L,285L,300L,308L,315L,324L,336L,350L,360L,378L,400L,405L,420L,432L,450L,456L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029451Inst : IEnumerable<long>
{
public static readonly long[] Value=A029451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029451.Bytes);
public long this[int i]=>Value[i];

public static A029451Inst Instance=new A029451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029452
{
public static readonly long[] Value={ 1L,3L,7L,12L,21L,28L,44L,49L,60L,61L,63L,81L,84L,91L,97L,108L,140L,147L,180L,189L,196L,204L,212L,243L,252L,303L,308L,324L,343L,349L,376L,392L,441L,504L,831L,1029L,1057L,1176L,1561L,2401L,2744L,3101L,4312L,5096L,6027L,7203L,8232L,10339L,11669L,12936L,13755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029452Inst : IEnumerable<long>
{
public static readonly long[] Value=A029452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029452.Bytes);
public long this[int i]=>Value[i];

public static A029452Inst Instance=new A029452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029453
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,12L,13L,14L,15L,16L,21L,24L,28L,32L,35L,39L,42L,48L,49L,56L,64L,70L,98L,106L,112L,128L,147L,164L,196L,224L,231L,256L,289L,392L,448L,490L,512L,545L,560L,608L,640L,665L,688L,784L,872L,889L,896L,980L,1024L,1064L,1120L,1280L,1520L,1526L,1568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029453Inst : IEnumerable<long>
{
public static readonly long[] Value=A029453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029453.Bytes);
public long this[int i]=>Value[i];

public static A029453Inst Instance=new A029453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029454
{
public static readonly long[] Value={ 1L,3L,9L,27L,33L,47L,51L,64L,81L,97L,135L,153L,192L,243L,405L,576L,729L,933L,1152L,2187L,3456L,6561L,9099L,10368L,19683L,27008L,31104L,59049L,72981L,91584L,108864L,111537L,126021L,137781L,139968L,177147L,260253L,326592L,413343L,419904L,438543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029454Inst : IEnumerable<long>
{
public static readonly long[] Value=A029454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029454.Bytes);
public long this[int i]=>Value[i];

public static A029454Inst Instance=new A029454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029455
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,10L,12L,15L,18L,20L,25L,27L,30L,36L,45L,50L,54L,60L,69L,75L,90L,100L,108L,120L,125L,135L,150L,162L,180L,200L,216L,225L,248L,250L,270L,300L,324L,360L,375L,405L,450L,470L,500L,540L,558L,600L,648L,675L,710L,750L,810L,900L,1000L,1053L,1080L,1116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029455Inst : IEnumerable<long>
{
public static readonly long[] Value=A029455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029455.Bytes);
public long this[int i]=>Value[i];

public static A029455Inst Instance=new A029455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029456
{
public static readonly long[] Value={ 1L,5L,11L,20L,25L,44L,55L,100L,121L,220L,275L,281L,484L,508L,605L,748L,1012L,1100L,1331L,1496L,1573L,1595L,1768L,2200L,3016L,3025L,3400L,4825L,4840L,6655L,7480L,9320L,9515L,10648L,11320L,12760L,14641L,15125L,15400L,15507L,16335L,16456L,17000L,17215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029456Inst : IEnumerable<long>
{
public static readonly long[] Value=A029456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029456.Bytes);
public long this[int i]=>Value[i];

public static A029456Inst Instance=new A029456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029457
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,11L,12L,15L,16L,18L,22L,24L,29L,33L,36L,44L,45L,48L,55L,66L,72L,87L,88L,99L,121L,132L,144L,154L,168L,176L,192L,198L,216L,224L,242L,252L,258L,264L,288L,297L,308L,336L,352L,363L,369L,378L,396L,432L,448L,462L,484L,504L,528L,561L,576L,594L,616L,672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029457Inst : IEnumerable<long>
{
public static readonly long[] Value=A029457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029457.Bytes);
public long this[int i]=>Value[i];

public static A029457Inst Instance=new A029457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029458
{
public static readonly long[] Value={ 1L,3L,9L,13L,15L,16L,39L,48L,65L,169L,208L,240L,377L,400L,507L,603L,624L,720L,1040L,1168L,1200L,1287L,1521L,1833L,1872L,2197L,2592L,2784L,3393L,3744L,4563L,5211L,5408L,6591L,7989L,8299L,11232L,13689L,16224L,16992L,18477L,19643L,19773L,24352L,28561L,37349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029458Inst : IEnumerable<long>
{
public static readonly long[] Value=A029458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029458.Bytes);
public long this[int i]=>Value[i];

public static A029458Inst Instance=new A029458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029459
{
public static readonly long[] Value={ 1L,2L,6L,7L,10L,13L,14L,18L,19L,21L,26L,28L,36L,39L,42L,49L,52L,63L,69L,78L,84L,91L,98L,102L,117L,126L,147L,156L,169L,182L,196L,273L,308L,338L,343L,363L,364L,392L,507L,637L,676L,686L,728L,952L,968L,1029L,1078L,1183L,1274L,1352L,1372L,1573L,1768L,1898L,1911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029459Inst : IEnumerable<long>
{
public static readonly long[] Value=A029459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029459.Bytes);
public long this[int i]=>Value[i];

public static A029459Inst Instance=new A029459Inst();

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