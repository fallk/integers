using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A029332
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,1L,2L,1L,1L,1L,3L,2L,2L,3L,4L,3L,3L,4L,6L,5L,5L,6L,8L,7L,7L,8L,11L,10L,10L,11L,14L,13L,13L,15L,18L,17L,17L,19L,23L,21L,22L,24L,28L,27L,27L,30L,34L,33L,34L,36L,41L,40L,41L,44L,49L,48L,49L,52L,58L,57L,58L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029332Inst : IEnumerable<long>
{
public static readonly long[] Value=A029332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029332.Bytes);
public long this[int i]=>Value[i];

public static A029332Inst Instance=new A029332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029333
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,1L,1L,2L,1L,1L,2L,2L,3L,2L,3L,3L,4L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,9L,10L,10L,12L,12L,13L,14L,15L,16L,16L,18L,19L,20L,21L,22L,24L,25L,26L,27L,29L,31L,32L,33L,35L,37L,39L,40L,42L,44L,46L,48L,50L,52L,54L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029333Inst : IEnumerable<long>
{
public static readonly long[] Value=A029333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029333.Bytes);
public long this[int i]=>Value[i];

public static A029333Inst Instance=new A029333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029334
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,2L,1L,2L,1L,3L,3L,2L,3L,3L,4L,5L,4L,5L,4L,7L,7L,6L,7L,8L,9L,10L,9L,11L,10L,13L,14L,13L,14L,15L,17L,19L,17L,20L,19L,23L,24L,23L,25L,26L,29L,31L,29L,33L,32L,37L,38L,38L,40L,41L,45L,48L,46L,50L,50L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029334Inst : IEnumerable<long>
{
public static readonly long[] Value=A029334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029334.Bytes);
public long this[int i]=>Value[i];

public static A029334Inst Instance=new A029334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029335
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,2L,2L,1L,2L,3L,3L,2L,3L,4L,4L,4L,5L,5L,5L,6L,7L,7L,7L,8L,9L,9L,10L,11L,11L,12L,13L,14L,14L,15L,17L,17L,18L,19L,21L,21L,22L,24L,25L,26L,27L,29L,30L,31L,33L,35L,36L,37L,39L,41L,43L,44L,46L,48L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029335Inst : IEnumerable<long>
{
public static readonly long[] Value=A029335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029335.Bytes);
public long this[int i]=>Value[i];

public static A029335Inst Instance=new A029335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029336
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,3L,1L,2L,2L,3L,3L,2L,4L,4L,4L,4L,4L,7L,5L,6L,6L,8L,8L,7L,9L,10L,10L,10L,11L,14L,12L,13L,14L,17L,16L,16L,18L,20L,20L,20L,22L,25L,24L,25L,26L,30L,29L,30L,32L,35L,35L,35L,38L,42L,41L,42L,44L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029336Inst : IEnumerable<long>
{
public static readonly long[] Value=A029336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029336.Bytes);
public long this[int i]=>Value[i];

public static A029336Inst Instance=new A029336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029337
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,2L,2L,1L,0L,2L,3L,2L,1L,3L,4L,4L,2L,4L,5L,5L,4L,6L,7L,7L,6L,8L,9L,9L,8L,11L,12L,12L,11L,14L,15L,15L,14L,18L,19L,19L,18L,22L,24L,23L,22L,27L,29L,29L,27L,32L,35L,35L,33L,38L,41L,42L,40L,45L,48L,49L,48L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029337Inst : IEnumerable<long>
{
public static readonly long[] Value=A029337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029337.Bytes);
public long this[int i]=>Value[i];

public static A029337Inst Instance=new A029337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029338
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,2L,1L,2L,0L,2L,2L,2L,2L,3L,2L,4L,2L,6L,3L,4L,4L,7L,6L,6L,4L,10L,7L,10L,6L,11L,10L,12L,10L,14L,11L,16L,12L,20L,14L,18L,16L,23L,20L,22L,18L,29L,23L,30L,22L,32L,29L,34L,30L,38L,32L,42L,34L,48L,38L,46L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029338Inst : IEnumerable<long>
{
public static readonly long[] Value=A029338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029338.Bytes);
public long this[int i]=>Value[i];

public static A029338Inst Instance=new A029338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029339
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,2L,1L,1L,1L,2L,2L,1L,2L,4L,2L,2L,3L,5L,4L,3L,4L,7L,5L,5L,6L,8L,7L,7L,8L,11L,9L,9L,11L,13L,12L,12L,13L,17L,15L,15L,17L,20L,19L,19L,20L,25L,23L,23L,25L,29L,28L,28L,30L,35L,33L,33L,36L,41L,39L,39L,42L,48L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029339Inst : IEnumerable<long>
{
public static readonly long[] Value=A029339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029339.Bytes);
public long this[int i]=>Value[i];

public static A029339Inst Instance=new A029339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029340
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,2L,1L,1L,0L,3L,2L,1L,1L,4L,3L,2L,1L,6L,4L,3L,2L,8L,6L,4L,3L,10L,8L,6L,4L,13L,10L,8L,6L,16L,13L,10L,8L,20L,16L,13L,10L,24L,20L,16L,13L,29L,24L,20L,16L,34L,29L,24L,20L,40L,34L,29L,24L,47L,40L,34L,29L,54L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029340Inst : IEnumerable<long>
{
public static readonly long[] Value=A029340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029340.Bytes);
public long this[int i]=>Value[i];

public static A029340Inst Instance=new A029340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029341
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,1L,2L,2L,0L,1L,2L,3L,2L,1L,2L,4L,4L,4L,2L,4L,5L,6L,5L,4L,6L,8L,8L,8L,6L,9L,10L,11L,10L,10L,12L,14L,14L,15L,13L,16L,17L,19L,19L,18L,20L,23L,24L,25L,22L,26L,28L,31L,30L,29L,32L,36L,37L,38L,35L,40L,43L,46L,45L,44L,48L,53L,54L,55L,52L,59L,62L,65L,64L,64L,69L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029341Inst : IEnumerable<long>
{
public static readonly long[] Value=A029341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029341.Bytes);
public long this[int i]=>Value[i];

public static A029341Inst Instance=new A029341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029342
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,1L,2L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,4L,3L,4L,4L,5L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,11L,11L,12L,12L,14L,14L,15L,15L,17L,18L,18L,19L,20L,22L,22L,23L,24L,26L,27L,28L,29L,30L,32L,33L,35L,35L,37L,39L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029342Inst : IEnumerable<long>
{
public static readonly long[] Value=A029342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029342.Bytes);
public long this[int i]=>Value[i];

public static A029342Inst Instance=new A029342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029343
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,2L,2L,2L,1L,2L,3L,3L,2L,3L,4L,4L,3L,5L,5L,5L,5L,6L,7L,7L,6L,8L,9L,9L,8L,11L,11L,11L,11L,13L,14L,14L,13L,16L,18L,17L,16L,20L,21L,21L,20L,23L,25L,26L,24L,27L,30L,30L,29L,33L,34L,35L,35L,38L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029343Inst : IEnumerable<long>
{
public static readonly long[] Value=A029343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029343.Bytes);
public long this[int i]=>Value[i];

public static A029343Inst Instance=new A029343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029344
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,2L,1L,1L,1L,2L,3L,2L,1L,2L,3L,5L,3L,3L,3L,5L,6L,5L,4L,5L,6L,9L,7L,7L,7L,9L,11L,10L,9L,10L,11L,15L,13L,13L,13L,16L,18L,17L,16L,18L,19L,23L,21L,22L,22L,25L,28L,27L,26L,28L,30L,35L,32L,33L,34L,38L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029344Inst : IEnumerable<long>
{
public static readonly long[] Value=A029344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029344.Bytes);
public long this[int i]=>Value[i];

public static A029344Inst Instance=new A029344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029345
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,2L,0L,2L,1L,2L,2L,2L,2L,2L,2L,5L,2L,4L,2L,6L,5L,4L,4L,6L,6L,8L,4L,9L,6L,10L,8L,10L,9L,10L,10L,15L,10L,14L,10L,18L,15L,16L,14L,19L,18L,22L,16L,24L,19L,26L,22L,27L,24L,28L,26L,35L,27L,34L,28L,40L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029345Inst : IEnumerable<long>
{
public static readonly long[] Value=A029345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029345.Bytes);
public long this[int i]=>Value[i];

public static A029345Inst Instance=new A029345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029346
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,2L,1L,1L,2L,3L,2L,1L,2L,4L,3L,3L,3L,5L,4L,4L,5L,6L,5L,5L,6L,8L,7L,7L,8L,10L,9L,9L,10L,12L,11L,11L,12L,15L,14L,14L,15L,18L,17L,17L,18L,21L,20L,20L,22L,25L,24L,24L,26L,30L,28L,28L,30L,34L,33L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029346Inst : IEnumerable<long>
{
public static readonly long[] Value=A029346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029346.Bytes);
public long this[int i]=>Value[i];

public static A029346Inst Instance=new A029346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029347
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,2L,0L,1L,1L,3L,1L,3L,2L,4L,1L,4L,3L,6L,3L,6L,4L,8L,4L,8L,6L,11L,6L,11L,8L,14L,8L,14L,11L,18L,11L,18L,14L,22L,14L,23L,18L,27L,18L,28L,22L,33L,23L,34L,27L,39L,28L,41L,33L,47L,34L,48L,39L,55L,41L,57L,47L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029347Inst : IEnumerable<long>
{
public static readonly long[] Value=A029347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029347.Bytes);
public long this[int i]=>Value[i];

public static A029347Inst Instance=new A029347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029348
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,2L,4L,3L,4L,4L,5L,4L,6L,6L,6L,7L,8L,7L,9L,9L,10L,10L,12L,11L,14L,13L,14L,15L,17L,16L,19L,19L,20L,21L,23L,22L,26L,26L,27L,28L,31L,30L,34L,34L,36L,37L,40L,39L,44L,44L,46L,48L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029348Inst : IEnumerable<long>
{
public static readonly long[] Value=A029348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029348.Bytes);
public long this[int i]=>Value[i];

public static A029348Inst Instance=new A029348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029349
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,2L,1L,2L,1L,3L,1L,3L,2L,4L,2L,5L,3L,5L,3L,7L,4L,7L,5L,9L,5L,10L,7L,11L,7L,13L,9L,14L,10L,16L,11L,18L,13L,20L,14L,22L,16L,24L,18L,27L,20L,29L,22L,32L,24L,35L,27L,38L,29L,41L,32L,45L,35L,48L,38L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029349Inst : IEnumerable<long>
{
public static readonly long[] Value=A029349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029349.Bytes);
public long this[int i]=>Value[i];

public static A029349Inst Instance=new A029349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029350
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,2L,2L,1L,2L,2L,2L,2L,4L,3L,3L,3L,5L,4L,5L,5L,6L,5L,7L,7L,8L,7L,9L,9L,10L,10L,12L,11L,12L,13L,15L,14L,16L,16L,18L,17L,20L,20L,22L,21L,24L,24L,26L,26L,29L,29L,31L,31L,34L,34L,37L,37L,40L,40L,43L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029350Inst : IEnumerable<long>
{
public static readonly long[] Value=A029350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029350.Bytes);
public long this[int i]=>Value[i];

public static A029350Inst Instance=new A029350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029351
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,3L,1L,2L,1L,3L,1L,4L,3L,4L,2L,4L,3L,7L,4L,6L,4L,8L,4L,9L,7L,10L,6L,10L,8L,14L,9L,13L,10L,16L,10L,18L,14L,19L,13L,20L,16L,25L,18L,24L,19L,28L,20L,31L,25L,33L,24L,34L,28L,41L,31L,40L,33L,45L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029351Inst : IEnumerable<long>
{
public static readonly long[] Value=A029351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029351.Bytes);
public long this[int i]=>Value[i];

public static A029351Inst Instance=new A029351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029352
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,2L,1L,1L,0L,3L,1L,2L,1L,4L,2L,4L,1L,5L,3L,5L,2L,8L,4L,7L,4L,9L,5L,10L,5L,12L,8L,12L,7L,16L,9L,15L,10L,19L,12L,20L,12L,23L,16L,23L,15L,29L,19L,28L,20L,33L,23L,35L,23L,39L,29L,40L,28L,47L,33L,47L,35L,53L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029352Inst : IEnumerable<long>
{
public static readonly long[] Value=A029352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029352.Bytes);
public long this[int i]=>Value[i];

public static A029352Inst Instance=new A029352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029353
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,2L,0L,1L,1L,3L,0L,2L,1L,4L,1L,3L,2L,5L,1L,5L,3L,7L,2L,6L,4L,9L,3L,9L,5L,11L,5L,11L,7L,14L,6L,14L,9L,17L,9L,17L,11L,21L,11L,21L,14L,25L,14L,25L,17L,30L,17L,30L,21L,35L,21L,35L,25L,41L,25L,41L,30L,47L,30L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029353Inst : IEnumerable<long>
{
public static readonly long[] Value=A029353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029353.Bytes);
public long this[int i]=>Value[i];

public static A029353Inst Instance=new A029353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029354
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,2L,0L,2L,1L,2L,1L,3L,1L,4L,2L,4L,2L,5L,2L,6L,3L,6L,4L,8L,4L,9L,5L,9L,6L,11L,6L,13L,8L,13L,9L,16L,9L,17L,11L,18L,13L,21L,13L,23L,16L,24L,17L,27L,18L,30L,21L,31L,23L,35L,24L,38L,27L,39L,30L,44L,31L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029354Inst : IEnumerable<long>
{
public static readonly long[] Value=A029354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029354.Bytes);
public long this[int i]=>Value[i];

public static A029354Inst Instance=new A029354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029355
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,3L,3L,4L,3L,5L,3L,5L,5L,6L,5L,7L,6L,7L,8L,8L,8L,10L,9L,10L,11L,12L,11L,14L,12L,15L,15L,16L,15L,19L,17L,19L,20L,21L,21L,24L,23L,25L,26L,27L,27L,31L,29L,32L,33L,35L,34L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029355Inst : IEnumerable<long>
{
public static readonly long[] Value=A029355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029355.Bytes);
public long this[int i]=>Value[i];

public static A029355Inst Instance=new A029355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029356
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,3L,1L,1L,1L,3L,1L,4L,1L,3L,3L,4L,1L,7L,3L,4L,4L,7L,3L,9L,4L,7L,7L,9L,4L,14L,7L,9L,9L,14L,7L,17L,9L,14L,14L,17L,9L,24L,14L,17L,17L,24L,14L,29L,17L,24L,24L,29L,17L,38L,24L,29L,29L,38L,24L,45L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029356Inst : IEnumerable<long>
{
public static readonly long[] Value=A029356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029356.Bytes);
public long this[int i]=>Value[i];

public static A029356Inst Instance=new A029356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029373
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,1L,3L,0L,0L,1L,4L,0L,0L,2L,5L,0L,1L,3L,7L,0L,1L,4L,8L,0L,2L,5L,10L,1L,3L,7L,12L,1L,4L,8L,14L,2L,5L,10L,17L,3L,7L,12L,20L,4L,8L,14L,23L,5L,10L,17L,27L,7L,12L,20L,31L,8L,14L,23L,35L,10L,17L,27L,40L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029373Inst : IEnumerable<long>
{
public static readonly long[] Value=A029373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029373.Bytes);
public long this[int i]=>Value[i];

public static A029373Inst Instance=new A029373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029374
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,2L,3L,2L,3L,2L,3L,3L,4L,4L,5L,5L,5L,5L,5L,5L,6L,6L,7L,7L,9L,8L,9L,8L,10L,9L,10L,10L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,18L,18L,20L,19L,21L,21L,23L,22L,24L,24L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029374Inst : IEnumerable<long>
{
public static readonly long[] Value=A029374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029374.Bytes);
public long this[int i]=>Value[i];

public static A029374Inst Instance=new A029374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029375
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,2L,1L,1L,0L,2L,1L,2L,1L,3L,2L,3L,1L,4L,2L,3L,2L,5L,3L,5L,3L,6L,4L,6L,3L,8L,5L,7L,5L,10L,6L,9L,6L,11L,8L,11L,7L,14L,10L,13L,9L,16L,11L,16L,11L,18L,14L,19L,13L,22L,16L,21L,16L,25L,18L,25L,19L,28L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029375Inst : IEnumerable<long>
{
public static readonly long[] Value=A029375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029375.Bytes);
public long this[int i]=>Value[i];

public static A029375Inst Instance=new A029375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029376
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,2L,1L,0L,1L,2L,1L,1L,1L,3L,2L,2L,2L,4L,2L,2L,3L,4L,3L,3L,4L,5L,5L,4L,5L,7L,5L,5L,6L,8L,6L,7L,7L,10L,9L,8L,9L,12L,10L,9L,11L,13L,12L,12L,13L,16L,15L,14L,15L,19L,16L,16L,18L,21L,19L,20L,21L,24L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029376Inst : IEnumerable<long>
{
public static readonly long[] Value=A029376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029376.Bytes);
public long this[int i]=>Value[i];

public static A029376Inst Instance=new A029376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029377
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,0L,1L,1L,3L,1L,3L,2L,4L,1L,3L,2L,4L,1L,4L,3L,6L,3L,6L,4L,7L,3L,6L,4L,8L,4L,8L,6L,11L,6L,10L,7L,12L,6L,11L,8L,14L,8L,14L,11L,17L,10L,16L,12L,19L,11L,18L,14L,22L,14L,22L,17L,25L,16L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029377Inst : IEnumerable<long>
{
public static readonly long[] Value=A029377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029377.Bytes);
public long this[int i]=>Value[i];

public static A029377Inst Instance=new A029377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029378
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,11L,12L,12L,13L,13L,15L,15L,17L,17L,18L,19L,20L,21L,23L,23L,25L,25L,27L,28L,30L,31L,33L,33L,35L,36L,39L,40L,42L,43L,45L,46L,49L,50L,53L,54L,57L,58L,61L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029378Inst : IEnumerable<long>
{
public static readonly long[] Value=A029378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029378.Bytes);
public long this[int i]=>Value[i];

public static A029378Inst Instance=new A029378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029379
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,3L,3L,4L,3L,4L,5L,5L,5L,6L,6L,6L,8L,7L,8L,9L,9L,10L,11L,11L,11L,13L,13L,14L,16L,15L,16L,18L,18L,19L,21L,21L,22L,24L,24L,25L,28L,28L,29L,31L,31L,33L,36L,36L,37L,40L,40L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029379Inst : IEnumerable<long>
{
public static readonly long[] Value=A029379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029379.Bytes);
public long this[int i]=>Value[i];

public static A029379Inst Instance=new A029379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029380
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,2L,1L,2L,1L,1L,2L,2L,3L,2L,2L,4L,3L,4L,3L,4L,5L,5L,6L,5L,5L,8L,7L,8L,7L,8L,10L,10L,11L,10L,10L,14L,13L,15L,13L,14L,17L,17L,19L,18L,18L,22L,21L,24L,22L,24L,27L,27L,29L,28L,29L,34L,33L,36L,34L,36L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029380Inst : IEnumerable<long>
{
public static readonly long[] Value=A029380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029380.Bytes);
public long this[int i]=>Value[i];

public static A029380Inst Instance=new A029380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029381
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,2L,2L,1L,1L,1L,2L,3L,3L,2L,2L,3L,4L,4L,4L,4L,4L,5L,6L,6L,6L,6L,7L,8L,8L,9L,9L,9L,10L,11L,12L,12L,13L,13L,14L,15L,16L,17L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,36L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029381Inst : IEnumerable<long>
{
public static readonly long[] Value=A029381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029381.Bytes);
public long this[int i]=>Value[i];

public static A029381Inst Instance=new A029381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029382
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,3L,1L,1L,1L,1L,3L,3L,3L,2L,2L,3L,3L,6L,4L,4L,4L,4L,6L,7L,7L,6L,6L,7L,8L,11L,9L,9L,9L,10L,12L,14L,13L,12L,13L,14L,16L,19L,17L,17L,17L,19L,21L,24L,23L,22L,23L,24L,27L,31L,29L,29L,29L,31L,34L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029382Inst : IEnumerable<long>
{
public static readonly long[] Value=A029382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029382.Bytes);
public long this[int i]=>Value[i];

public static A029382Inst Instance=new A029382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029383
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,2L,3L,3L,3L,4L,5L,4L,5L,5L,5L,6L,7L,6L,8L,8L,8L,9L,10L,9L,11L,11L,12L,13L,14L,13L,15L,16L,16L,17L,19L,18L,21L,21L,21L,23L,25L,24L,27L,27L,28L,30L,32L,31L,34L,35L,36L,38L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029383Inst : IEnumerable<long>
{
public static readonly long[] Value=A029383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029383.Bytes);
public long this[int i]=>Value[i];

public static A029383Inst Instance=new A029383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029384
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,2L,1L,1L,1L,1L,2L,3L,1L,3L,1L,4L,3L,3L,3L,4L,4L,6L,3L,6L,4L,8L,6L,7L,6L,8L,8L,11L,7L,11L,8L,14L,11L,13L,11L,14L,14L,18L,13L,19L,14L,22L,18L,21L,19L,23L,22L,28L,21L,29L,23L,33L,28L,32L,29L,35L,33L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029384Inst : IEnumerable<long>
{
public static readonly long[] Value=A029384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029384.Bytes);
public long this[int i]=>Value[i];

public static A029384Inst Instance=new A029384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029385
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,2L,1L,1L,1L,1L,3L,2L,2L,2L,2L,3L,4L,3L,4L,3L,4L,5L,5L,5L,6L,5L,7L,7L,7L,8L,8L,8L,10L,9L,11L,11L,11L,12L,13L,13L,15L,14L,16L,16L,17L,18L,19L,19L,21L,21L,23L,23L,24L,25L,27L,27L,29L,29L,31L,32L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029385Inst : IEnumerable<long>
{
public static readonly long[] Value=A029385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029385.Bytes);
public long this[int i]=>Value[i];

public static A029385Inst Instance=new A029385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029386
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,3L,2L,3L,3L,5L,3L,4L,3L,5L,5L,7L,4L,7L,5L,7L,7L,10L,7L,9L,7L,11L,10L,13L,9L,13L,11L,14L,13L,18L,13L,17L,14L,19L,18L,22L,17L,23L,19L,24L,22L,29L,23L,28L,24L,31L,29L,35L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029386Inst : IEnumerable<long>
{
public static readonly long[] Value=A029386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029386.Bytes);
public long this[int i]=>Value[i];

public static A029386Inst Instance=new A029386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029387
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,2L,1L,1L,0L,1L,3L,2L,1L,2L,2L,4L,3L,2L,2L,4L,5L,4L,4L,4L,5L,8L,5L,5L,6L,7L,9L,9L,7L,8L,10L,12L,10L,11L,10L,12L,16L,14L,13L,15L,15L,19L,18L,17L,17L,21L,23L,22L,22L,22L,24L,30L,26L,26L,28L,30L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029387Inst : IEnumerable<long>
{
public static readonly long[] Value=A029387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029387.Bytes);
public long this[int i]=>Value[i];

public static A029387Inst Instance=new A029387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029388
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,2L,1L,0L,1L,2L,2L,2L,2L,1L,3L,3L,3L,3L,3L,3L,4L,5L,4L,5L,5L,5L,6L,7L,6L,7L,8L,7L,9L,9L,9L,10L,11L,10L,12L,13L,12L,14L,14L,14L,16L,17L,16L,18L,19L,19L,21L,21L,21L,23L,25L,24L,26L,27L,27L,30L,31L,30L,32L,34L,34L,37L,38L,37L,40L,42L,42L,45L,46L,45L,49L,51L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029388Inst : IEnumerable<long>
{
public static readonly long[] Value=A029388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029388.Bytes);
public long this[int i]=>Value[i];

public static A029388Inst Instance=new A029388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029405
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,3L,5L,5L,5L,5L,6L,6L,6L,6L,7L,8L,8L,7L,9L,10L,9L,9L,11L,11L,12L,11L,12L,14L,14L,13L,15L,16L,16L,16L,18L,18L,19L,19L,20L,22L,22L,21L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029405Inst : IEnumerable<long>
{
public static readonly long[] Value=A029405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029405.Bytes);
public long this[int i]=>Value[i];

public static A029405Inst Instance=new A029405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029406
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,1L,0L,2L,2L,0L,2L,1L,3L,3L,1L,2L,2L,3L,4L,2L,3L,3L,5L,5L,4L,4L,4L,6L,6L,5L,6L,5L,9L,8L,7L,8L,7L,10L,10L,8L,11L,9L,13L,13L,11L,13L,12L,15L,16L,13L,16L,15L,19L,19L,17L,19L,19L,22L,23L,20L,23L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029406Inst : IEnumerable<long>
{
public static readonly long[] Value=A029406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029406.Bytes);
public long this[int i]=>Value[i];

public static A029406Inst Instance=new A029406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029407
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,2L,0L,1L,1L,0L,2L,1L,1L,2L,0L,4L,1L,2L,2L,2L,4L,2L,2L,4L,2L,6L,2L,5L,4L,4L,6L,5L,5L,6L,4L,10L,5L,8L,6L,8L,10L,8L,8L,11L,8L,14L,8L,13L,11L,12L,14L,14L,13L,16L,12L,21L,14L,18L,16L,19L,21L,20L,18L,24L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029407Inst : IEnumerable<long>
{
public static readonly long[] Value=A029407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029407.Bytes);
public long this[int i]=>Value[i];

public static A029407Inst Instance=new A029407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029408
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,2L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,3L,3L,5L,4L,4L,5L,5L,5L,5L,5L,7L,6L,6L,7L,8L,8L,8L,8L,10L,9L,9L,10L,11L,11L,11L,12L,14L,13L,13L,14L,16L,15L,15L,16L,18L,18L,18L,19L,21L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029408Inst : IEnumerable<long>
{
public static readonly long[] Value=A029408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029408.Bytes);
public long this[int i]=>Value[i];

public static A029408Inst Instance=new A029408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029409
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,2L,1L,0L,0L,1L,2L,1L,0L,1L,2L,4L,2L,1L,1L,2L,4L,2L,2L,2L,4L,6L,4L,3L,3L,4L,6L,5L,4L,5L,6L,9L,7L,6L,6L,7L,10L,8L,8L,8L,10L,13L,11L,10L,10L,12L,15L,13L,12L,13L,15L,19L,16L,15L,16L,18L,22L,19L,18L,19L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029409Inst : IEnumerable<long>
{
public static readonly long[] Value=A029409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029409.Bytes);
public long this[int i]=>Value[i];

public static A029409Inst Instance=new A029409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029410
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,1L,2L,3L,1L,2L,1L,3L,3L,1L,3L,2L,4L,5L,2L,4L,3L,5L,5L,4L,5L,4L,7L,7L,5L,7L,5L,8L,9L,7L,8L,8L,10L,11L,9L,10L,9L,13L,13L,11L,13L,12L,15L,17L,13L,15L,15L,18L,19L,17L,18L,18L,22L,23L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029410Inst : IEnumerable<long>
{
public static readonly long[] Value=A029410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029410.Bytes);
public long this[int i]=>Value[i];

public static A029410Inst Instance=new A029410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029411
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,3L,2L,3L,3L,3L,4L,4L,4L,4L,5L,4L,5L,5L,5L,6L,6L,6L,7L,8L,7L,8L,8L,8L,9L,9L,9L,10L,11L,11L,12L,12L,12L,13L,14L,13L,14L,15L,15L,17L,17L,17L,18L,19L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029411Inst : IEnumerable<long>
{
public static readonly long[] Value=A029411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029411.Bytes);
public long this[int i]=>Value[i];

public static A029411Inst Instance=new A029411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029412
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,1L,1L,0L,0L,2L,1L,1L,0L,0L,3L,2L,3L,1L,1L,3L,2L,3L,1L,1L,4L,3L,5L,3L,3L,5L,4L,5L,3L,3L,6L,5L,7L,5L,6L,8L,7L,8L,6L,6L,9L,8L,10L,8L,9L,12L,11L,12L,10L,10L,14L,12L,14L,12L,13L,17L,16L,17L,15L,15L,20L,18L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029412Inst : IEnumerable<long>
{
public static readonly long[] Value=A029412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029412.Bytes);
public long this[int i]=>Value[i];

public static A029412Inst Instance=new A029412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029413
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,2L,2L,2L,1L,2L,1L,2L,3L,3L,3L,4L,3L,3L,4L,4L,4L,6L,5L,6L,6L,6L,6L,8L,7L,8L,9L,9L,9L,11L,10L,11L,12L,12L,12L,15L,14L,15L,16L,16L,16L,19L,18L,20L,21L,21L,21L,24L,23L,25L,27L,27L,27L,30L,29L,31L,33L,34L,34L,38L,36L,38L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029413Inst : IEnumerable<long>
{
public static readonly long[] Value=A029413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029413.Bytes);
public long this[int i]=>Value[i];

public static A029413Inst Instance=new A029413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029414
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,2L,1L,2L,1L,2L,1L,3L,2L,3L,2L,4L,2L,4L,3L,5L,3L,6L,4L,6L,4L,7L,5L,8L,6L,9L,6L,10L,7L,11L,8L,12L,9L,13L,10L,15L,11L,16L,12L,17L,13L,19L,15L,21L,16L,22L,17L,24L,19L,26L,21L,28L,22L,30L,24L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029414Inst : IEnumerable<long>
{
public static readonly long[] Value=A029414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029414.Bytes);
public long this[int i]=>Value[i];

public static A029414Inst Instance=new A029414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029415
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L,4L,4L,5L,4L,5L,5L,5L,6L,7L,6L,7L,7L,8L,8L,9L,9L,10L,9L,11L,11L,12L,12L,13L,13L,14L,14L,16L,16L,17L,17L,18L,18L,20L,20L,22L,22L,23L,23L,25L,25L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029415Inst : IEnumerable<long>
{
public static readonly long[] Value=A029415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029415.Bytes);
public long this[int i]=>Value[i];

public static A029415Inst Instance=new A029415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029416
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,2L,1L,2L,1L,1L,0L,2L,2L,3L,2L,2L,1L,4L,2L,4L,3L,4L,2L,5L,4L,6L,4L,5L,4L,8L,5L,8L,6L,8L,5L,10L,8L,11L,8L,10L,8L,14L,10L,14L,11L,14L,10L,17L,14L,19L,14L,17L,14L,22L,17L,23L,19L,23L,17L,26L,22L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029416Inst : IEnumerable<long>
{
public static readonly long[] Value=A029416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029416.Bytes);
public long this[int i]=>Value[i];

public static A029416Inst Instance=new A029416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029417
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,4L,4L,3L,5L,4L,4L,5L,6L,5L,7L,7L,6L,7L,8L,7L,9L,9L,9L,10L,11L,10L,12L,12L,12L,13L,14L,13L,16L,16L,16L,17L,18L,17L,20L,20L,20L,22L,23L,22L,25L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029417Inst : IEnumerable<long>
{
public static readonly long[] Value=A029417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029417.Bytes);
public long this[int i]=>Value[i];

public static A029417Inst Instance=new A029417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029418
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,2L,2L,2L,3L,3L,2L,4L,3L,4L,4L,4L,4L,5L,5L,5L,7L,5L,6L,7L,7L,7L,9L,8L,8L,10L,9L,10L,11L,11L,11L,13L,12L,13L,15L,14L,15L,16L,16L,16L,19L,18L,19L,21L,20L,21L,23L,23L,23L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029418Inst : IEnumerable<long>
{
public static readonly long[] Value=A029418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029418.Bytes);
public long this[int i]=>Value[i];

public static A029418Inst Instance=new A029418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029419
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,2L,1L,1L,1L,1L,0L,3L,2L,1L,3L,1L,1L,4L,3L,2L,4L,3L,1L,6L,4L,3L,6L,4L,3L,8L,6L,4L,8L,6L,4L,11L,8L,6L,11L,8L,6L,14L,11L,8L,14L,11L,8L,18L,14L,11L,18L,14L,11L,22L,18L,14L,23L,18L,14L,27L,22L,18L,28L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029419Inst : IEnumerable<long>
{
public static readonly long[] Value=A029419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029419.Bytes);
public long this[int i]=>Value[i];

public static A029419Inst Instance=new A029419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029420
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,2L,2L,1L,2L,2L,2L,2L,3L,2L,2L,3L,4L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,8L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,17L,17L,18L,18L,19L,19L,21L,21L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029420Inst : IEnumerable<long>
{
public static readonly long[] Value=A029420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029420.Bytes);
public long this[int i]=>Value[i];

public static A029420Inst Instance=new A029420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029629
{
public static readonly long[] Value={ 8L,11L,14L,26L,17L,40L,20L,57L,90L,23L,77L,147L,26L,100L,224L,322L,29L,126L,324L,546L,32L,155L,450L,870L,1176L,35L,187L,605L,1320L,2046L,38L,222L,792L,1925L,3366L,4356L,41L,260L,1014L,2717L,5291L,7722L,44L,301L,1274L,3731L,8008L,13013L,16302L,47L,345L,1575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029629Inst : IEnumerable<long>
{
public static readonly long[] Value=A029629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029629.Bytes);
public long this[int i]=>Value[i];

public static A029629Inst Instance=new A029629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029630
{
public static readonly long[] Value={ 3L,3L,3L,3L,11L,3L,3L,17L,3L,57L,3L,23L,77L,147L,3L,3L,29L,3L,155L,3L,35L,187L,605L,3L,1925L,3L,41L,2717L,5291L,3L,301L,3731L,13013L,3L,47L,345L,1575L,5005L,11739L,21021L,29315L,3L,3L,53L,3L,495L,3L,59L,551L,3249L,3L,16815L,3L,65L,20615L,73017L,3L,737L,25025L,276507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029630Inst : IEnumerable<long>
{
public static readonly long[] Value=A029630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029630.Bytes);
public long this[int i]=>Value[i];

public static A029630Inst Instance=new A029630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029631
{
public static readonly long[] Value={ 8L,14L,26L,40L,20L,90L,26L,100L,224L,322L,126L,324L,546L,32L,450L,870L,1176L,1320L,2046L,38L,222L,792L,3366L,4356L,260L,1014L,7722L,44L,1274L,8008L,16302L,50L,392L,1920L,6580L,16744L,32760L,50336L,61490L,442L,2312L,8500L,23324L,49504L,83096L,111826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029631Inst : IEnumerable<long>
{
public static readonly long[] Value=A029631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029631.Bytes);
public long this[int i]=>Value[i];

public static A029631Inst Instance=new A029631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029632
{
public static readonly long[] Value={ 2L,2L,7L,2L,9L,2L,24L,11L,2L,35L,13L,2L,85L,48L,15L,2L,133L,63L,17L,2L,308L,196L,80L,19L,2L,504L,276L,99L,21L,2L,1134L,780L,375L,120L,23L,2L,1914L,1155L,495L,143L,25L,2L,4224L,3069L,1650L,638L,168L,27L,2L,7293L,4719L,2288L,806L,195L,29L,2L,15873L,12012L,7007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029632Inst : IEnumerable<long>
{
public static readonly long[] Value=A029632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029632.Bytes);
public long this[int i]=>Value[i];

public static A029632Inst Instance=new A029632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029633
{
public static readonly long[] Value={ 7L,9L,24L,11L,35L,13L,85L,48L,15L,133L,63L,17L,308L,196L,80L,19L,504L,276L,99L,21L,1134L,780L,375L,120L,23L,1914L,1155L,495L,143L,25L,4224L,3069L,1650L,638L,168L,27L,7293L,4719L,2288L,806L,195L,29L,15873L,12012L,7007L,3094L,1001L,224L,31L,27885L,19019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029633Inst : IEnumerable<long>
{
public static readonly long[] Value=A029633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029633.Bytes);
public long this[int i]=>Value[i];

public static A029633Inst Instance=new A029633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029634
{
public static readonly long[] Value={ 7L,9L,11L,35L,13L,85L,15L,133L,63L,17L,19L,99L,21L,375L,23L,1155L,495L,143L,25L,3069L,27L,7293L,4719L,195L,29L,15873L,7007L,1001L,31L,27885L,19019L,10101L,4095L,1225L,255L,33L,35L,323L,37L,2091L,39L,10659L,2451L,399L,41L,45543L,43L,169575L,58653L,483L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029634Inst : IEnumerable<long>
{
public static readonly long[] Value=A029634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029634.Bytes);
public long this[int i]=>Value[i];

public static A029634Inst Instance=new A029634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029635
{
public static readonly long[] Value={ 2L,1L,2L,1L,3L,2L,1L,4L,5L,2L,1L,5L,9L,7L,2L,1L,6L,14L,16L,9L,2L,1L,7L,20L,30L,25L,11L,2L,1L,8L,27L,50L,55L,36L,13L,2L,1L,9L,35L,77L,105L,91L,49L,15L,2L,1L,10L,44L,112L,182L,196L,140L,64L,17L,2L,1L,11L,54L,156L,294L,378L,336L,204L,81L,19L,2L,1L,12L,65L,210L,450L,672L,714L,540L,285L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029635Inst : IEnumerable<long>
{
public static readonly long[] Value=A029635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029635.Bytes);
public long this[int i]=>Value[i];

public static A029635Inst Instance=new A029635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029636
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,7L,6L,14L,16L,20L,30L,25L,11L,8L,27L,50L,55L,36L,13L,35L,77L,105L,91L,49L,15L,10L,44L,112L,182L,196L,140L,64L,17L,54L,156L,294L,378L,336L,204L,81L,19L,12L,65L,210L,450L,672L,714L,540L,285L,100L,21L,275L,660L,1122L,1386L,1254L,825L,385L,121L,23L,90L,352L,935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029636Inst : IEnumerable<long>
{
public static readonly long[] Value=A029636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029636.Bytes);
public long this[int i]=>Value[i];

public static A029636Inst Instance=new A029636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029637
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,4L,5L,1L,5L,9L,7L,1L,6L,14L,16L,9L,1L,7L,20L,30L,25L,11L,1L,8L,27L,50L,55L,36L,13L,1L,9L,35L,77L,105L,91L,49L,15L,1L,10L,44L,112L,182L,196L,140L,64L,17L,1L,11L,54L,156L,294L,378L,336L,204L,81L,19L,1L,12L,65L,210L,450L,672L,714L,540L,285L,100L,21L,1L,13L,77L,275L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029637Inst : IEnumerable<long>
{
public static readonly long[] Value=A029637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029637.Bytes);
public long this[int i]=>Value[i];

public static A029637Inst Instance=new A029637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029638
{
public static readonly long[] Value={ 2L,3L,2L,4L,5L,2L,5L,9L,7L,2L,6L,14L,16L,9L,2L,7L,20L,30L,25L,11L,2L,8L,27L,50L,55L,36L,13L,2L,9L,35L,77L,105L,91L,49L,15L,2L,10L,44L,112L,182L,196L,140L,64L,17L,2L,11L,54L,156L,294L,378L,336L,204L,81L,19L,2L,12L,65L,210L,450L,672L,714L,540L,285L,100L,21L,2L,13L,77L,275L,660L,1122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029638Inst : IEnumerable<long>
{
public static readonly long[] Value=A029638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029638.Bytes);
public long this[int i]=>Value[i];

public static A029638Inst Instance=new A029638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029639
{
public static readonly long[] Value={ 3L,5L,5L,9L,7L,9L,7L,25L,11L,27L,55L,13L,9L,35L,77L,105L,91L,49L,15L,17L,11L,81L,19L,65L,285L,21L,13L,77L,275L,825L,385L,121L,23L,935L,2079L,25L,15L,1287L,2717L,4719L,3289L,169L,27L,119L,1729L,7007L,9867L,5005L,819L,29L,17L,135L,665L,2275L,5733L,11011L,16445L,19305L,17875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029639Inst : IEnumerable<long>
{
public static readonly long[] Value=A029639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029639.Bytes);
public long this[int i]=>Value[i];

public static A029639Inst Instance=new A029639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029640
{
public static readonly long[] Value={ 2L,2L,4L,2L,2L,6L,14L,16L,2L,20L,30L,2L,8L,50L,36L,2L,2L,10L,44L,112L,182L,196L,140L,64L,2L,54L,156L,294L,378L,336L,204L,2L,12L,210L,450L,672L,714L,540L,100L,2L,660L,1122L,1386L,1254L,2L,14L,90L,352L,1782L,2508L,2640L,1210L,506L,144L,2L,104L,442L,4290L,5148L,1716L,650L,2L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029640Inst : IEnumerable<long>
{
public static readonly long[] Value=A029640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029640.Bytes);
public long this[int i]=>Value[i];

public static A029640Inst Instance=new A029640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029641
{
public static readonly long[] Value={ 4L,6L,14L,16L,20L,30L,8L,50L,36L,10L,44L,112L,182L,196L,140L,64L,54L,156L,294L,378L,336L,204L,12L,210L,450L,672L,714L,540L,100L,660L,1122L,1386L,1254L,14L,90L,352L,1782L,2508L,2640L,1210L,506L,144L,104L,442L,4290L,5148L,1716L,650L,16L,546L,4004L,9438L,8008L,2366L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029641Inst : IEnumerable<long>
{
public static readonly long[] Value=A029641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029641.Bytes);
public long this[int i]=>Value[i];

public static A029641Inst Instance=new A029641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029642
{
public static readonly long[] Value={ 1L,3L,5L,9L,7L,25L,11L,27L,55L,13L,35L,77L,105L,91L,49L,15L,17L,81L,19L,65L,285L,21L,275L,825L,385L,121L,23L,935L,2079L,1287L,2717L,4719L,3289L,169L,119L,1729L,7007L,9867L,5005L,819L,29L,135L,665L,2275L,5733L,11011L,16445L,19305L,17875L,13013L,7371L,3185L,1015L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029642Inst : IEnumerable<long>
{
public static readonly long[] Value=A029642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029642.Bytes);
public long this[int i]=>Value[i];

public static A029642Inst Instance=new A029642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029643
{
public static readonly long[] Value={ 2L,2L,2L,2L,16L,2L,2L,36L,2L,2L,196L,140L,64L,2L,336L,204L,2L,714L,540L,100L,2L,1254L,2L,2640L,1210L,506L,144L,2L,1716L,650L,2L,8008L,2366L,196L,2L,2L,37180L,30888L,20384L,10556L,4200L,1240L,256L,2L,68068L,51272L,30940L,14756L,5440L,1496L,2L,140998L,119340L,82212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029643Inst : IEnumerable<long>
{
public static readonly long[] Value=A029643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029643.Bytes);
public long this[int i]=>Value[i];

public static A029643Inst Instance=new A029643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029644
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,5L,1L,6L,14L,1L,7L,20L,1L,8L,27L,50L,1L,9L,35L,77L,1L,10L,44L,112L,182L,1L,11L,54L,156L,294L,1L,12L,65L,210L,450L,672L,1L,13L,77L,275L,660L,1122L,1L,14L,90L,352L,935L,1782L,2508L,1L,15L,104L,442L,1287L,2717L,4290L,1L,16L,119L,546L,1729L,4004L,7007L,9438L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029644Inst : IEnumerable<long>
{
public static readonly long[] Value=A029644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029644.Bytes);
public long this[int i]=>Value[i];

public static A029644Inst Instance=new A029644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029661
{
public static readonly long[] Value={ 4L,14L,6L,20L,50L,8L,182L,112L,44L,10L,294L,156L,54L,672L,450L,210L,12L,1122L,660L,2508L,1782L,352L,90L,14L,4290L,442L,104L,9438L,4004L,546L,16L,35750L,27456L,16744L,8008L,2940L,800L,152L,18L,63206L,44200L,24752L,10948L,3740L,952L,170L,136136L,107406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029661Inst : IEnumerable<long>
{
public static readonly long[] Value=A029661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029661.Bytes);
public long this[int i]=>Value[i];

public static A029661Inst Instance=new A029661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029662
{
public static readonly long[] Value={ 2L,2L,2L,5L,2L,7L,2L,9L,16L,2L,11L,25L,2L,13L,36L,55L,2L,15L,49L,91L,2L,17L,64L,140L,196L,2L,19L,81L,204L,336L,2L,21L,100L,285L,540L,714L,2L,23L,121L,385L,825L,1254L,2L,25L,144L,506L,1210L,2079L,2640L,2L,27L,169L,650L,1716L,3289L,4719L,2L,29L,196L,819L,2366L,5005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029662Inst : IEnumerable<long>
{
public static readonly long[] Value=A029662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029662.Bytes);
public long this[int i]=>Value[i];

public static A029662Inst Instance=new A029662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029663
{
public static readonly long[] Value={ 4L,5L,14L,6L,20L,7L,50L,27L,8L,77L,35L,9L,182L,112L,44L,10L,294L,156L,54L,11L,672L,450L,210L,65L,12L,1122L,660L,275L,77L,13L,2508L,1782L,935L,352L,90L,14L,4290L,2717L,1287L,442L,104L,15L,9438L,7007L,4004L,1729L,546L,119L,16L,16445L,11011L,5733L,2275L,665L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029663Inst : IEnumerable<long>
{
public static readonly long[] Value=A029663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029663.Bytes);
public long this[int i]=>Value[i];

public static A029663Inst Instance=new A029663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029664
{
public static readonly long[] Value={ 5L,7L,9L,11L,25L,13L,55L,15L,49L,91L,17L,19L,81L,21L,285L,23L,121L,385L,825L,25L,2079L,27L,169L,3289L,4719L,29L,819L,5005L,9867L,31L,225L,1015L,3185L,7371L,13013L,17875L,33L,35L,289L,37L,1785L,39L,361L,2109L,8721L,41L,35853L,43L,441L,46683L,128877L,45L,3311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029664Inst : IEnumerable<long>
{
public static readonly long[] Value=A029664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029664.Bytes);
public long this[int i]=>Value[i];

public static A029664Inst Instance=new A029664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029665
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,16L,2L,2L,36L,2L,2L,64L,140L,196L,2L,204L,336L,2L,100L,540L,714L,2L,1254L,2L,144L,506L,1210L,2640L,2L,650L,1716L,2L,196L,2366L,8008L,2L,2L,256L,1240L,4200L,10556L,20384L,30888L,37180L,2L,1496L,5440L,14756L,30940L,51272L,68068L,2L,324L,6936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029665Inst : IEnumerable<long>
{
public static readonly long[] Value=A029665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029665.Bytes);
public long this[int i]=>Value[i];

public static A029665Inst Instance=new A029665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029666
{
public static readonly long[] Value={ 1L,1L,4L,1L,5L,1L,14L,6L,1L,20L,7L,1L,50L,27L,8L,1L,77L,35L,9L,1L,182L,112L,44L,10L,1L,294L,156L,54L,11L,1L,672L,450L,210L,65L,12L,1L,1122L,660L,275L,77L,13L,1L,2508L,1782L,935L,352L,90L,14L,1L,4290L,2717L,1287L,442L,104L,15L,1L,9438L,7007L,4004L,1729L,546L,119L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029666Inst : IEnumerable<long>
{
public static readonly long[] Value=A029666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029666.Bytes);
public long this[int i]=>Value[i];

public static A029666Inst Instance=new A029666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029667
{
public static readonly long[] Value={ 5L,7L,9L,16L,11L,25L,13L,36L,55L,15L,49L,91L,17L,64L,140L,196L,19L,81L,204L,336L,21L,100L,285L,540L,714L,23L,121L,385L,825L,1254L,25L,144L,506L,1210L,2079L,2640L,27L,169L,650L,1716L,3289L,4719L,29L,196L,819L,2366L,5005L,8008L,9867L,31L,225L,1015L,3185L,7371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029667Inst : IEnumerable<long>
{
public static readonly long[] Value=A029667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029667.Bytes);
public long this[int i]=>Value[i];

public static A029667Inst Instance=new A029667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029668
{
public static readonly long[] Value={ 5L,7L,27L,77L,35L,9L,11L,65L,275L,77L,13L,935L,2717L,1287L,15L,7007L,1729L,119L,16445L,11011L,5733L,2275L,665L,135L,17L,19L,189L,1311L,209L,21L,7125L,32319L,8645L,23L,127281L,10395L,275L,447051L,168245L,51359L,12397L,2277L,299L,25L,1427679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029668Inst : IEnumerable<long>
{
public static readonly long[] Value=A029668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029668.Bytes);
public long this[int i]=>Value[i];

public static A029668Inst Instance=new A029668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029669
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,1L,7L,9L,5L,1L,9L,1L,11L,25L,7L,1L,13L,55L,27L,1L,15L,49L,91L,105L,77L,35L,9L,1L,17L,1L,19L,81L,11L,1L,21L,285L,65L,1L,23L,121L,385L,825L,275L,77L,13L,1L,25L,2079L,935L,1L,27L,169L,3289L,4719L,2717L,1287L,15L,1L,29L,819L,5005L,9867L,7007L,1729L,119L,1L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029669Inst : IEnumerable<long>
{
public static readonly long[] Value=A029669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029669.Bytes);
public long this[int i]=>Value[i];

public static A029669Inst Instance=new A029669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029670
{
public static readonly long[] Value={ 1L,0L,2L,6L,4L,4L,0L,4L,10L,2L,2L,12L,10L,0L,6L,8L,8L,6L,6L,8L,12L,4L,4L,16L,8L,6L,0L,22L,12L,4L,6L,4L,26L,4L,0L,26L,18L,4L,8L,0L,6L,4L,10L,22L,28L,8L,4L,20L,22L,6L,10L,22L,0L,12L,4L,8L,18L,8L,8L,32L,24L,4L,8L,20L,20L,2L,4L,28L,26L,4L,4L,20L,30L,4L,10L,24L,16L,12L,2L,8L,36L,12L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029670Inst : IEnumerable<long>
{
public static readonly long[] Value=A029670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029670.Bytes);
public long this[int i]=>Value[i];

public static A029670Inst Instance=new A029670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029671
{
public static readonly long[] Value={ 1L,2L,6L,8L,6L,8L,4L,8L,18L,10L,4L,20L,16L,0L,12L,16L,14L,16L,18L,12L,24L,8L,12L,32L,12L,14L,2L,32L,20L,16L,16L,8L,42L,16L,8L,40L,30L,16L,28L,0L,12L,12L,24L,32L,40L,24L,8L,40L,32L,14L,30L,32L,0L,40L,16L,16L,36L,24L,20L,44L,40L,8L,28L,40L,30L,4L,16L,44L,48L,16L,16L,40L,54L,12L,28L,40L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029671Inst : IEnumerable<long>
{
public static readonly long[] Value=A029671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029671.Bytes);
public long this[int i]=>Value[i];

public static A029671Inst Instance=new A029671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029672
{
public static readonly long[] Value={ 1L,0L,2L,8L,2L,0L,6L,8L,6L,0L,4L,8L,12L,0L,4L,24L,2L,0L,14L,8L,0L,0L,8L,16L,18L,0L,4L,32L,12L,0L,16L,8L,6L,0L,4L,16L,14L,0L,8L,32L,12L,0L,24L,24L,12L,0L,8L,16L,12L,0L,10L,48L,0L,0L,18L,16L,12L,0L,12L,8L,36L,0L,12L,56L,2L,0L,16L,24L,12L,0L,8L,16L,42L,0L,12L,40L,12L,0L,36L,24L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029672Inst : IEnumerable<long>
{
public static readonly long[] Value=A029672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029672.Bytes);
public long this[int i]=>Value[i];

public static A029672Inst Instance=new A029672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029673
{
public static readonly long[] Value={ 1L,2L,10L,4L,10L,2L,16L,4L,26L,10L,0L,12L,20L,4L,36L,0L,26L,12L,30L,4L,10L,8L,32L,20L,32L,2L,40L,16L,20L,20L,12L,8L,58L,8L,20L,0L,50L,12L,64L,16L,0L,16L,40L,12L,60L,6L,36L,20L,52L,14L,10L,16L,20L,28L,64L,4L,84L,16L,40L,20L,0L,12L,72L,20L,58L,0L,40L,12L,60L,16L,16L,32L,78L,12L,80L,4L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029673Inst : IEnumerable<long>
{
public static readonly long[] Value=A029673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029673.Bytes);
public long this[int i]=>Value[i];

public static A029673Inst Instance=new A029673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029674
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029674Inst : IEnumerable<long>
{
public static readonly long[] Value=A029674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029674.Bytes);
public long this[int i]=>Value[i];

public static A029674Inst Instance=new A029674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029675
{
public static readonly long[] Value={ 0L,3L,4L,5L,8L,9L,11L,12L,15L,16L,19L,20L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,36L,37L,39L,41L,43L,44L,45L,48L,49L,51L,52L,53L,55L,56L,57L,59L,60L,61L,63L,64L,65L,67L,68L,69L,71L,72L,75L,76L,77L,79L,80L,81L,83L,84L,85L,87L,88L,89L,91L,92L,93L,95L,96L,97L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029675Inst : IEnumerable<long>
{
public static readonly long[] Value=A029675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029675.Bytes);
public long this[int i]=>Value[i];

public static A029675Inst Instance=new A029675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029676
{
public static readonly long[] Value={ 1L,0L,0L,4L,4L,2L,2L,4L,2L,2L,4L,6L,6L,2L,2L,2L,12L,2L,0L,14L,6L,2L,2L,4L,10L,6L,2L,14L,8L,0L,2L,12L,4L,2L,8L,8L,14L,4L,4L,8L,14L,2L,4L,14L,12L,8L,6L,2L,12L,8L,2L,16L,10L,2L,6L,16L,10L,0L,0L,16L,12L,10L,2L,12L,24L,2L,6L,20L,10L,6L,6L,8L,8L,4L,4L,24L,30L,2L,6L,14L,14L,8L,8L,12L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029676Inst : IEnumerable<long>
{
public static readonly long[] Value=A029676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029676.Bytes);
public long this[int i]=>Value[i];

public static A029676Inst Instance=new A029676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029709
{
public static readonly long[] Value={ 4L,6L,8L,12L,14L,19L,22L,25L,27L,29L,31L,38L,44L,48L,50L,59L,63L,65L,70L,75L,78L,85L,88L,90L,93L,95L,112L,117L,122L,131L,134L,136L,143L,147L,149L,151L,153L,155L,159L,163L,169L,181L,183L,198L,207L,211L,213L,224L,226L,229L,235L,237L,244L,247L,249L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029709Inst : IEnumerable<long>
{
public static readonly long[] Value=A029709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029709.Bytes);
public long this[int i]=>Value[i];

public static A029709Inst Instance=new A029709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029710
{
public static readonly long[] Value={ 7L,13L,19L,37L,43L,67L,79L,97L,103L,109L,127L,163L,193L,223L,229L,277L,307L,313L,349L,379L,397L,439L,457L,463L,487L,499L,613L,643L,673L,739L,757L,769L,823L,853L,859L,877L,883L,907L,937L,967L,1009L,1087L,1093L,1213L,1279L,1297L,1303L,1423L,1429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029710Inst : IEnumerable<long>
{
public static readonly long[] Value=A029710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029710.Bytes);
public long this[int i]=>Value[i];

public static A029710Inst Instance=new A029710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029711
{
public static readonly BigInteger[] Value={ 1L,1L,9L,85L,1033L,15641L,279961L,5764837L,134217777L,3486784465L,100000000081L,3138428376821L,106993205379193L,3937376385699433L,155568095557812393L,6568408355712890821L,BigInteger.Parse("295147905179352826081"),BigInteger.Parse("14063084452067724991265"),BigInteger.Parse("708235345355337676357921") };
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
public class A029711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A029711.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A029711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A029711Inst Instance=new A029711Inst();

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