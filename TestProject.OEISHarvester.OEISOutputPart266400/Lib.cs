using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A029389
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,2L,0L,1L,2L,1L,2L,3L,1L,2L,3L,2L,3L,5L,2L,3L,5L,3L,5L,7L,3L,5L,7L,5L,7L,10L,5L,7L,10L,7L,10L,13L,7L,10L,14L,10L,13L,17L,10L,14L,18L,13L,17L,22L,14L,18L,23L,17L,22L,28L,18L,23L,29L,22L,28L,34L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029389Inst : IEnumerable<long>
{
public static readonly long[] Value=A029389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029389.Bytes);
public long this[int i]=>Value[i];

public static A029389Inst Instance=new A029389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029390
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,2L,2L,1L,0L,0L,2L,3L,2L,1L,0L,3L,4L,4L,2L,1L,3L,5L,5L,4L,2L,5L,6L,7L,6L,4L,6L,8L,8L,8L,6L,9L,10L,11L,10L,9L,11L,13L,13L,13L,11L,15L,16L,17L,16L,15L,18L,20L,20L,20L,18L,23L,24L,25L,24L,23L,27L,30L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029390Inst : IEnumerable<long>
{
public static readonly long[] Value=A029390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029390.Bytes);
public long this[int i]=>Value[i];

public static A029390Inst Instance=new A029390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029391
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,2L,1L,2L,0L,0L,2L,2L,2L,2L,0L,3L,2L,4L,2L,3L,3L,3L,4L,4L,3L,7L,3L,6L,4L,6L,7L,8L,6L,6L,6L,11L,8L,12L,6L,9L,11L,13L,12L,13L,9L,15L,13L,18L,13L,17L,15L,18L,18L,20L,17L,25L,18L,24L,20L,25L,25L,29L,24L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029391Inst : IEnumerable<long>
{
public static readonly long[] Value=A029391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029391.Bytes);
public long this[int i]=>Value[i];

public static A029391Inst Instance=new A029391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029392
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,2L,2L,0L,0L,1L,2L,3L,2L,0L,1L,2L,4L,4L,3L,1L,2L,4L,5L,5L,4L,2L,4L,6L,7L,7L,6L,4L,6L,8L,9L,9L,8L,6L,9L,11L,12L,12L,11L,9L,12L,14L,15L,15L,14L,13L,16L,18L,19L,19L,19L,17L,20L,22L,23L,24L,24L,22L,25L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029392Inst : IEnumerable<long>
{
public static readonly long[] Value=A029392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029392.Bytes);
public long this[int i]=>Value[i];

public static A029392Inst Instance=new A029392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029393
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,2L,2L,2L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,4L,5L,5L,6L,6L,7L,7L,7L,8L,8L,9L,9L,10L,11L,11L,12L,12L,13L,14L,14L,15L,16L,17L,18L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,31L,32L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029393Inst : IEnumerable<long>
{
public static readonly long[] Value=A029393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029393.Bytes);
public long this[int i]=>Value[i];

public static A029393Inst Instance=new A029393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029394
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,2L,0L,1L,1L,1L,3L,1L,2L,2L,1L,4L,2L,3L,3L,3L,5L,3L,4L,5L,4L,7L,5L,6L,6L,6L,9L,7L,8L,9L,8L,12L,9L,11L,11L,11L,15L,12L,14L,15L,14L,19L,15L,18L,18L,18L,23L,20L,22L,23L,22L,28L,24L,27L,28L,28L,33L,30L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029394Inst : IEnumerable<long>
{
public static readonly long[] Value=A029394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029394.Bytes);
public long this[int i]=>Value[i];

public static A029394Inst Instance=new A029394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029395
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,8L,8L,8L,10L,9L,10L,11L,11L,12L,12L,13L,14L,14L,15L,16L,16L,17L,18L,19L,20L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029395Inst : IEnumerable<long>
{
public static readonly long[] Value=A029395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029395.Bytes);
public long this[int i]=>Value[i];

public static A029395Inst Instance=new A029395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029396
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,2L,1L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,4L,3L,3L,4L,4L,5L,4L,5L,6L,5L,6L,6L,8L,7L,7L,8L,9L,9L,9L,10L,11L,11L,11L,12L,14L,13L,14L,14L,16L,16L,16L,18L,19L,19L,19L,20L,23L,22L,23L,24L,26L,26L,26L,28L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029396Inst : IEnumerable<long>
{
public static readonly long[] Value=A029396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029396.Bytes);
public long this[int i]=>Value[i];

public static A029396Inst Instance=new A029396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029397
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,1L,0L,2L,2L,1L,2L,1L,3L,3L,2L,2L,2L,4L,4L,3L,4L,4L,5L,6L,4L,5L,5L,7L,8L,6L,8L,7L,9L,10L,8L,10L,9L,12L,13L,11L,13L,12L,15L,16L,14L,16L,15L,19L,20L,18L,20L,19L,23L,24L,22L,24L,24L,28L,29L,27L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029397Inst : IEnumerable<long>
{
public static readonly long[] Value=A029397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029397.Bytes);
public long this[int i]=>Value[i];

public static A029397Inst Instance=new A029397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029398
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,2L,1L,2L,1L,2L,2L,2L,3L,2L,3L,2L,4L,3L,4L,4L,4L,5L,4L,6L,5L,6L,6L,7L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,14L,14L,15L,15L,17L,17L,18L,18L,19L,20L,21L,22L,22L,24L,24L,26L,26L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029398Inst : IEnumerable<long>
{
public static readonly long[] Value=A029398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029398.Bytes);
public long this[int i]=>Value[i];

public static A029398Inst Instance=new A029398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029399
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,2L,0L,2L,1L,1L,2L,1L,3L,1L,3L,2L,2L,4L,2L,4L,3L,4L,4L,4L,5L,4L,6L,5L,6L,7L,6L,7L,7L,8L,8L,9L,9L,9L,11L,10L,11L,12L,12L,13L,13L,14L,14L,16L,16L,16L,18L,17L,19L,20L,20L,21L,22L,23L,23L,25L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029399Inst : IEnumerable<long>
{
public static readonly long[] Value=A029399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029399.Bytes);
public long this[int i]=>Value[i];

public static A029399Inst Instance=new A029399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029400
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,2L,1L,1L,0L,1L,2L,1L,2L,1L,1L,3L,3L,3L,1L,2L,4L,3L,4L,3L,3L,5L,5L,6L,4L,4L,7L,6L,7L,6L,6L,9L,8L,10L,8L,8L,11L,10L,12L,10L,11L,14L,13L,15L,13L,14L,17L,16L,18L,16L,17L,21L,20L,22L,20L,21L,25L,24L,26L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029400Inst : IEnumerable<long>
{
public static readonly long[] Value=A029400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029400.Bytes);
public long this[int i]=>Value[i];

public static A029400Inst Instance=new A029400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029401
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,2L,0L,2L,0L,1L,2L,0L,3L,0L,2L,3L,1L,4L,0L,4L,3L,2L,5L,1L,5L,4L,4L,6L,2L,7L,5L,6L,7L,4L,8L,7L,8L,9L,6L,10L,9L,10L,11L,9L,12L,12L,12L,14L,11L,15L,15L,15L,17L,14L,18L,19L,18L,21L,17L,22L,22L,22L,25L,21L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029401Inst : IEnumerable<long>
{
public static readonly long[] Value=A029401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029401.Bytes);
public long this[int i]=>Value[i];

public static A029401Inst Instance=new A029401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029402
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,2L,0L,1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,3L,3L,4L,3L,4L,4L,5L,5L,5L,6L,5L,6L,6L,7L,7L,7L,8L,8L,9L,9L,10L,10L,10L,11L,11L,12L,12L,13L,14L,14L,15L,15L,16L,17L,17L,18L,18L,19L,20L,21L,22L,22L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029402Inst : IEnumerable<long>
{
public static readonly long[] Value=A029402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029402.Bytes);
public long this[int i]=>Value[i];

public static A029402Inst Instance=new A029402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029403
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,2L,0L,0L,1L,1L,2L,1L,1L,3L,2L,3L,1L,1L,3L,3L,4L,3L,3L,5L,4L,5L,3L,4L,6L,6L,7L,6L,6L,8L,7L,9L,7L,8L,10L,10L,12L,10L,10L,13L,12L,15L,12L,13L,16L,16L,18L,16L,16L,20L,19L,22L,19L,20L,24L,24L,26L,24L,24L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029403Inst : IEnumerable<long>
{
public static readonly long[] Value=A029403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029403.Bytes);
public long this[int i]=>Value[i];

public static A029403Inst Instance=new A029403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029404
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,4L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,6L,8L,8L,8L,9L,9L,10L,10L,10L,11L,12L,12L,13L,13L,14L,15L,15L,16L,16L,17L,18L,19L,19L,20L,21L,22L,23L,23L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029404Inst : IEnumerable<long>
{
public static readonly long[] Value=A029404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029404.Bytes);
public long this[int i]=>Value[i];

public static A029404Inst Instance=new A029404Inst();

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

public static class A029421
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,2L,1L,1L,0L,1L,1L,2L,2L,2L,1L,2L,1L,4L,2L,3L,2L,3L,2L,5L,4L,4L,3L,5L,3L,7L,5L,6L,4L,7L,5L,9L,7L,8L,6L,9L,7L,12L,9L,11L,8L,12L,9L,15L,12L,14L,11L,15L,12L,19L,15L,18L,14L,19L,15L,23L,19L,22L,18L,24L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029421Inst : IEnumerable<long>
{
public static readonly long[] Value=A029421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029421.Bytes);
public long this[int i]=>Value[i];

public static A029421Inst Instance=new A029421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029422
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,2L,1L,1L,0L,0L,1L,3L,2L,1L,1L,1L,2L,4L,3L,2L,1L,2L,3L,5L,4L,3L,3L,3L,5L,7L,5L,4L,4L,5L,6L,9L,7L,6L,6L,7L,9L,11L,9L,8L,8L,9L,11L,14L,12L,11L,11L,12L,14L,17L,15L,14L,14L,15L,17L,21L,19L,18L,18L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029422Inst : IEnumerable<long>
{
public static readonly long[] Value=A029422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029422.Bytes);
public long this[int i]=>Value[i];

public static A029422Inst Instance=new A029422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029423
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,2L,1L,3L,1L,2L,1L,2L,1L,4L,2L,4L,3L,4L,2L,5L,2L,5L,4L,6L,4L,8L,4L,7L,5L,8L,5L,10L,6L,10L,8L,11L,7L,13L,8L,13L,10L,14L,10L,17L,11L,17L,13L,18L,13L,21L,14L,21L,17L,23L,17L,26L,18L,26L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029423Inst : IEnumerable<long>
{
public static readonly long[] Value=A029423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029423.Bytes);
public long this[int i]=>Value[i];

public static A029423Inst Instance=new A029423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029424
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,2L,2L,1L,2L,1L,2L,2L,3L,2L,3L,3L,3L,3L,4L,3L,4L,5L,4L,5L,6L,4L,6L,6L,6L,7L,8L,6L,9L,8L,8L,9L,10L,9L,11L,11L,11L,12L,13L,12L,14L,14L,14L,15L,17L,15L,18L,18L,18L,19L,21L,19L,22L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029424Inst : IEnumerable<long>
{
public static readonly long[] Value=A029424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029424.Bytes);
public long this[int i]=>Value[i];

public static A029424Inst Instance=new A029424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029425
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,2L,0L,1L,1L,1L,1L,3L,0L,2L,2L,1L,1L,5L,1L,3L,3L,2L,2L,6L,1L,5L,5L,3L,3L,9L,2L,6L,6L,5L,5L,11L,3L,9L,9L,6L,6L,15L,5L,11L,11L,9L,9L,18L,6L,15L,15L,11L,11L,23L,9L,18L,18L,15L,15L,27L,11L,23L,23L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029425Inst : IEnumerable<long>
{
public static readonly long[] Value=A029425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029425.Bytes);
public long this[int i]=>Value[i];

public static A029425Inst Instance=new A029425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029426
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,2L,1L,2L,1L,2L,1L,3L,1L,3L,1L,3L,2L,4L,2L,5L,2L,5L,3L,5L,3L,6L,3L,7L,4L,8L,5L,8L,5L,9L,5L,10L,6L,11L,7L,12L,8L,13L,8L,14L,9L,15L,10L,16L,11L,18L,12L,19L,13L,20L,14L,22L,15L,23L,16L,25L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029426Inst : IEnumerable<long>
{
public static readonly long[] Value=A029426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029426.Bytes);
public long this[int i]=>Value[i];

public static A029426Inst Instance=new A029426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029427
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,0L,2L,2L,4L,1L,2L,1L,3L,2L,5L,2L,4L,2L,4L,4L,7L,2L,5L,3L,6L,5L,8L,4L,8L,4L,8L,7L,11L,5L,9L,6L,11L,8L,13L,8L,13L,8L,13L,11L,17L,9L,15L,11L,17L,13L,20L,13L,20L,13L,20L,17L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029427Inst : IEnumerable<long>
{
public static readonly long[] Value=A029427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029427.Bytes);
public long this[int i]=>Value[i];

public static A029427Inst Instance=new A029427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029428
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,3L,3L,3L,4L,3L,3L,4L,3L,3L,5L,4L,5L,6L,6L,5L,7L,5L,6L,7L,7L,7L,9L,8L,9L,10L,9L,9L,11L,10L,11L,12L,12L,12L,15L,13L,14L,15L,15L,15L,18L,16L,17L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029428Inst : IEnumerable<long>
{
public static readonly long[] Value=A029428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029428.Bytes);
public long this[int i]=>Value[i];

public static A029428Inst Instance=new A029428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029429
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,2L,0L,0L,1L,1L,0L,3L,1L,1L,2L,2L,0L,4L,1L,1L,3L,3L,1L,6L,2L,2L,4L,4L,1L,8L,3L,3L,6L,6L,2L,10L,4L,4L,8L,8L,3L,13L,6L,6L,10L,10L,4L,16L,8L,8L,13L,13L,6L,20L,10L,10L,16L,16L,8L,24L,13L,13L,20L,20L,10L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029429Inst : IEnumerable<long>
{
public static readonly long[] Value=A029429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029429.Bytes);
public long this[int i]=>Value[i];

public static A029429Inst Instance=new A029429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029430
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,3L,0L,1L,2L,1L,2L,4L,0L,1L,3L,1L,3L,5L,1L,2L,5L,2L,4L,7L,1L,3L,6L,3L,5L,9L,2L,5L,9L,4L,7L,11L,3L,6L,11L,5L,9L,14L,5L,9L,14L,7L,11L,17L,6L,11L,17L,9L,14L,21L,9L,14L,21L,11L,17L,25L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029430Inst : IEnumerable<long>
{
public static readonly long[] Value=A029430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029430.Bytes);
public long this[int i]=>Value[i];

public static A029430Inst Instance=new A029430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029431
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,2L,0L,0L,0L,1L,1L,2L,0L,1L,1L,3L,2L,3L,0L,1L,1L,3L,2L,4L,1L,3L,3L,5L,3L,5L,1L,3L,3L,6L,4L,7L,3L,6L,5L,8L,5L,8L,3L,7L,6L,10L,7L,11L,6L,10L,8L,12L,8L,13L,7L,12L,10L,15L,11L,17L,10L,15L,12L,18L,13L,20L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029431Inst : IEnumerable<long>
{
public static readonly long[] Value=A029431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029431.Bytes);
public long this[int i]=>Value[i];

public static A029431Inst Instance=new A029431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029432
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,2L,2L,2L,1L,1L,1L,1L,2L,3L,3L,3L,3L,3L,2L,3L,3L,4L,4L,5L,5L,5L,5L,5L,5L,6L,6L,7L,7L,8L,8L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,17L,18L,18L,19L,19L,20L,20L,22L,22L,24L,24L,25L,25L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029432Inst : IEnumerable<long>
{
public static readonly long[] Value=A029432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029432.Bytes);
public long this[int i]=>Value[i];

public static A029432Inst Instance=new A029432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029433
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,4L,4L,4L,4L,5L,4L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,9L,9L,10L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,16L,16L,17L,17L,18L,18L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029433Inst : IEnumerable<long>
{
public static readonly long[] Value=A029433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029433.Bytes);
public long this[int i]=>Value[i];

public static A029433Inst Instance=new A029433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029434
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,3L,2L,2L,2L,3L,2L,3L,3L,4L,4L,3L,4L,5L,4L,4L,5L,6L,5L,6L,6L,7L,7L,6L,7L,9L,8L,8L,9L,10L,9L,10L,10L,12L,12L,11L,12L,14L,13L,13L,15L,16L,15L,16L,16L,18L,18L,18L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029434Inst : IEnumerable<long>
{
public static readonly long[] Value=A029434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029434.Bytes);
public long this[int i]=>Value[i];

public static A029434Inst Instance=new A029434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029435
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,3L,3L,4L,4L,4L,5L,5L,6L,5L,6L,6L,6L,6L,7L,7L,8L,8L,9L,9L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029435Inst : IEnumerable<long>
{
public static readonly long[] Value=A029435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029435.Bytes);
public long this[int i]=>Value[i];

public static A029435Inst Instance=new A029435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029436
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,3L,1L,2L,2L,3L,2L,3L,3L,4L,2L,4L,3L,5L,3L,5L,4L,6L,4L,6L,5L,7L,5L,7L,6L,9L,6L,9L,7L,10L,7L,10L,9L,12L,9L,12L,10L,14L,10L,14L,12L,16L,12L,16L,14L,18L,14L,19L,16L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029436Inst : IEnumerable<long>
{
public static readonly long[] Value=A029436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029436.Bytes);
public long this[int i]=>Value[i];

public static A029436Inst Instance=new A029436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029485
{
public static readonly long[] Value={ 1L,3L,5L,9L,15L,25L,75L,257L,321L,435L,795L,1285L,2313L,8523L,39759L,60855L,91209L,247875L,251385L,2695341L,5095725L,9529505L,12179807L,12341125L,57965805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029485Inst : IEnumerable<long>
{
public static readonly long[] Value=A029485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029485.Bytes);
public long this[int i]=>Value[i];

public static A029485Inst Instance=new A029485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029486
{
public static readonly long[] Value={ 1L,111L,269L,512L,1536L,4499L,4608L,7401L,9216L,23552L,420864L,492544L,3635712L,7943997L,8175681L,11616768L,12344832L,20399616L,49798656L,77196800L,91584000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029486Inst : IEnumerable<long>
{
public static readonly long[] Value=A029486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029486.Bytes);
public long this[int i]=>Value[i];

public static A029486Inst Instance=new A029486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029487
{
public static readonly long[] Value={ 1L,17L,49L,73L,289L,307L,1297L,3013L,8959L,664831L,1399549L,5122561L,8515193L,11012719L,65998063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029487Inst : IEnumerable<long>
{
public static readonly long[] Value=A029487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029487.Bytes);
public long this[int i]=>Value[i];

public static A029487Inst Instance=new A029487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029488
{
public static readonly long[] Value={ 1L,3L,9L,24L,27L,40L,45L,65L,72L,85L,120L,135L,153L,216L,221L,333L,360L,440L,501L,543L,648L,1080L,1240L,1320L,2456L,2493L,3240L,3720L,3960L,4887L,5169L,5427L,6309L,6504L,6981L,7440L,9360L,10320L,11583L,12555L,14391L,16848L,18135L,18255L,22320L,28080L,28183L,28629L,37360L,38313L,51795L,52545L,54405L,59985L,66960L,84240L,89415L,96720L,101520L,118989L,152784L,925520L,3899205L,4756545L,6259240L,9604872L,13659624L,14446344L,17753256L,17784920L,18694341L,19484440L,20518065L,21377495L,23876424L,31787080L,36603495L,60454107L,80052861L,95747177L,98872632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029488Inst : IEnumerable<long>
{
public static readonly long[] Value=A029488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029488.Bytes);
public long this[int i]=>Value[i];

public static A029488Inst Instance=new A029488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029489
{
public static readonly long[] Value={ 1L,19L,41L,61L,67L,251L,331L,361L,401L,25327L,290719L,3113179L,7271623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029489Inst : IEnumerable<long>
{
public static readonly long[] Value=A029489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029489.Bytes);
public long this[int i]=>Value[i];

public static A029489Inst Instance=new A029489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029490
{
public static readonly long[] Value={ 1L,5L,25L,43L,55L,128L,275L,1280L,2816L,5888L,6400L,12800L,28160L,33413L,37376L,129919L,140800L,286025L,352000L,990845L,1050880L,1773725L,2848000L,3581033L,4343680L,4428160L,5624960L,6732160L,7553920L,8497280L,9249995L,9872000L,10938752L,11426176L,14558575L,14569600L,15368320L,18998705L,19312000L,21362275L,24208000L,24934855L,27632000L,32432000L,37022605L,43193216L,51382265L,53717375L,81016375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029490Inst : IEnumerable<long>
{
public static readonly long[] Value=A029490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029490.Bytes);
public long this[int i]=>Value[i];

public static A029490Inst Instance=new A029490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029491
{
public static readonly long[] Value={ 1L,3L,7L,9L,21L,49L,59L,67L,89L,147L,353L,1057L,1773L,4711L,6943L,29691L,40719L,51309L,57533L,116881L,155769L,178311L,207123L,9111701L,9636685L,10090955L,14397327L,21361545L,23023665L,50170565L,55533513L,72268665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029491Inst : IEnumerable<long>
{
public static readonly long[] Value=A029491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029491.Bytes);
public long this[int i]=>Value[i];

public static A029491Inst Instance=new A029491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029492
{
public static readonly long[] Value={ 1L,11L,27L,33L,48L,93L,99L,121L,144L,176L,297L,304L,363L,432L,461L,528L,583L,1936L,2267L,2915L,5808L,12031L,22496L,26983L,31328L,33913L,63861L,81312L,93984L,105888L,108803L,143264L,477103L,1287968L,3511904L,3620768L,7292912L,31740567L,62025997L,63469123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029492Inst : IEnumerable<long>
{
public static readonly long[] Value=A029492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029492.Bytes);
public long this[int i]=>Value[i];

public static A029492Inst Instance=new A029492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029493
{
public static readonly long[] Value={ 1L,23L,49L,73L,79L,91L,97L,139L,349L,511L,529L,553L,577L,20401L,25189L,86227L,92989L,566257L,1321649L,2504263L,11387783L,52584187L,73812233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029493Inst : IEnumerable<long>
{
public static readonly long[] Value=A029493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029493.Bytes);
public long this[int i]=>Value[i];

public static A029493Inst Instance=new A029493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029494
{
public static readonly long[] Value={ 1L,3L,9L,21L,39L,71L,101L,111L,128L,239L,251L,384L,401L,419L,521L,1152L,1664L,4992L,14976L,21617L,23296L,29952L,34437L,36608L,45312L,51183L,92928L,117481L,191232L,225043L,255309L,742144L,910592L,1374464L,4074467L,5427968L,10461747L,10528128L,10897536L,14721408L,15387264L,15529344L,18626688L,20796849L,27863424L,28862509L,32013423L,41722496L,47329152L,52894873L,64367901L,66678144L,68195712L,77870208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029494Inst : IEnumerable<long>
{
public static readonly long[] Value=A029494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029494.Bytes);
public long this[int i]=>Value[i];

public static A029494Inst Instance=new A029494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029495
{
public static readonly long[] Value={ 1L,5L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029495Inst : IEnumerable<long>
{
public static readonly long[] Value=A029495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029495.Bytes);
public long this[int i]=>Value[i];

public static A029495Inst Instance=new A029495Inst();

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