using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A070486
{
public static readonly long[] Value={ 0L,1L,8L,3L,16L,5L,0L,7L,8L,9L,16L,11L,0L,13L,8L,15L,16L,17L,0L,19L,8L,21L,16L,23L,0L,1L,8L,3L,16L,5L,0L,7L,8L,9L,16L,11L,0L,13L,8L,15L,16L,17L,0L,19L,8L,21L,16L,23L,0L,1L,8L,3L,16L,5L,0L,7L,8L,9L,16L,11L,0L,13L,8L,15L,16L,17L,0L,19L,8L,21L,16L,23L,0L,1L,8L,3L,16L,5L,0L,7L,8L,9L,16L,11L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070486Inst : IEnumerable<long>
{
public static readonly long[] Value=A070486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070486.Bytes);
public long this[int i]=>Value[i];

public static A070486Inst Instance=new A070486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070487
{
public static readonly long[] Value={ 0L,1L,8L,2L,14L,0L,16L,18L,12L,4L,0L,6L,3L,22L,19L,0L,21L,13L,7L,9L,0L,11L,23L,17L,24L,0L,1L,8L,2L,14L,0L,16L,18L,12L,4L,0L,6L,3L,22L,19L,0L,21L,13L,7L,9L,0L,11L,23L,17L,24L,0L,1L,8L,2L,14L,0L,16L,18L,12L,4L,0L,6L,3L,22L,19L,0L,21L,13L,7L,9L,0L,11L,23L,17L,24L,0L,1L,8L,2L,14L,0L,16L,18L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070487Inst : IEnumerable<long>
{
public static readonly long[] Value=A070487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070487.Bytes);
public long this[int i]=>Value[i];

public static A070487Inst Instance=new A070487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070488
{
public static readonly long[] Value={ 0L,1L,8L,1L,12L,21L,8L,5L,18L,1L,12L,5L,12L,13L,14L,21L,14L,25L,8L,21L,18L,5L,14L,25L,18L,25L,0L,1L,8L,1L,12L,21L,8L,5L,18L,1L,12L,5L,12L,13L,14L,21L,14L,25L,8L,21L,18L,5L,14L,25L,18L,25L,0L,1L,8L,1L,12L,21L,8L,5L,18L,1L,12L,5L,12L,13L,14L,21L,14L,25L,8L,21L,18L,5L,14L,25L,18L,25L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070488Inst : IEnumerable<long>
{
public static readonly long[] Value=A070488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070488.Bytes);
public long this[int i]=>Value[i];

public static A070488Inst Instance=new A070488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070489
{
public static readonly long[] Value={ 0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L,17L,0L,19L,26L,0L,1L,8L,0L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070489Inst : IEnumerable<long>
{
public static readonly long[] Value=A070489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070489.Bytes);
public long this[int i]=>Value[i];

public static A070489Inst Instance=new A070489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070490
{
public static readonly long[] Value={ 0L,1L,8L,27L,8L,13L,20L,7L,8L,1L,20L,15L,20L,13L,0L,15L,8L,13L,8L,27L,20L,21L,8L,15L,20L,1L,20L,27L,0L,1L,8L,27L,8L,13L,20L,7L,8L,1L,20L,15L,20L,13L,0L,15L,8L,13L,8L,27L,20L,21L,8L,15L,20L,1L,20L,27L,0L,1L,8L,27L,8L,13L,20L,7L,8L,1L,20L,15L,20L,13L,0L,15L,8L,13L,8L,27L,20L,21L,8L,15L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070490Inst : IEnumerable<long>
{
public static readonly long[] Value=A070490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070490.Bytes);
public long this[int i]=>Value[i];

public static A070490Inst Instance=new A070490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070491
{
public static readonly long[] Value={ 0L,1L,8L,27L,6L,9L,13L,24L,19L,4L,14L,26L,17L,22L,18L,11L,7L,12L,3L,15L,25L,10L,5L,16L,20L,23L,2L,21L,28L,0L,1L,8L,27L,6L,9L,13L,24L,19L,4L,14L,26L,17L,22L,18L,11L,7L,12L,3L,15L,25L,10L,5L,16L,20L,23L,2L,21L,28L,0L,1L,8L,27L,6L,9L,13L,24L,19L,4L,14L,26L,17L,22L,18L,11L,7L,12L,3L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070491Inst : IEnumerable<long>
{
public static readonly long[] Value=A070491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070491.Bytes);
public long this[int i]=>Value[i];

public static A070491Inst Instance=new A070491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070492
{
public static readonly long[] Value={ 0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L,12L,19L,20L,21L,28L,17L,24L,25L,26L,3L,22L,29L,0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L,12L,19L,20L,21L,28L,17L,24L,25L,26L,3L,22L,29L,0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070492Inst : IEnumerable<long>
{
public static readonly long[] Value=A070492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070492.Bytes);
public long this[int i]=>Value[i];

public static A070492Inst Instance=new A070492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070493
{
public static readonly long[] Value={ 0L,1L,8L,27L,2L,1L,30L,2L,16L,16L,8L,29L,23L,27L,16L,27L,4L,15L,4L,8L,2L,23L,15L,15L,29L,1L,30L,29L,4L,23L,30L,0L,1L,8L,27L,2L,1L,30L,2L,16L,16L,8L,29L,23L,27L,16L,27L,4L,15L,4L,8L,2L,23L,15L,15L,29L,1L,30L,29L,4L,23L,30L,0L,1L,8L,27L,2L,1L,30L,2L,16L,16L,8L,29L,23L,27L,16L,27L,4L,15L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070493Inst : IEnumerable<long>
{
public static readonly long[] Value=A070493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070493.Bytes);
public long this[int i]=>Value[i];

public static A070493Inst Instance=new A070493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070494
{
public static readonly long[] Value={ 0L,1L,8L,27L,0L,29L,24L,23L,0L,25L,8L,19L,0L,21L,24L,15L,0L,17L,8L,11L,0L,13L,24L,7L,0L,9L,8L,3L,0L,5L,24L,31L,0L,1L,8L,27L,0L,29L,24L,23L,0L,25L,8L,19L,0L,21L,24L,15L,0L,17L,8L,11L,0L,13L,24L,7L,0L,9L,8L,3L,0L,5L,24L,31L,0L,1L,8L,27L,0L,29L,24L,23L,0L,25L,8L,19L,0L,21L,24L,15L,0L,17L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070494Inst : IEnumerable<long>
{
public static readonly long[] Value=A070494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070494.Bytes);
public long this[int i]=>Value[i];

public static A070494Inst Instance=new A070494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070495
{
public static readonly long[] Value={ 0L,1L,8L,27L,31L,26L,18L,13L,17L,3L,10L,11L,12L,19L,5L,9L,4L,29L,24L,28L,14L,21L,22L,23L,30L,16L,20L,15L,7L,2L,6L,25L,32L,0L,1L,8L,27L,31L,26L,18L,13L,17L,3L,10L,11L,12L,19L,5L,9L,4L,29L,24L,28L,14L,21L,22L,23L,30L,16L,20L,15L,7L,2L,6L,25L,32L,0L,1L,8L,27L,31L,26L,18L,13L,17L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070495Inst : IEnumerable<long>
{
public static readonly long[] Value=A070495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070495.Bytes);
public long this[int i]=>Value[i];

public static A070495Inst Instance=new A070495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070496
{
public static readonly long[] Value={ 0L,1L,8L,27L,30L,23L,12L,3L,2L,15L,14L,5L,28L,21L,24L,9L,16L,17L,18L,25L,10L,13L,6L,29L,20L,19L,32L,31L,22L,11L,4L,7L,26L,33L,0L,1L,8L,27L,30L,23L,12L,3L,2L,15L,14L,5L,28L,21L,24L,9L,16L,17L,18L,25L,10L,13L,6L,29L,20L,19L,32L,31L,22L,11L,4L,7L,26L,33L,0L,1L,8L,27L,30L,23L,12L,3L,2L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070496Inst : IEnumerable<long>
{
public static readonly long[] Value=A070496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070496.Bytes);
public long this[int i]=>Value[i];

public static A070496Inst Instance=new A070496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070497
{
public static readonly long[] Value={ 0L,1L,8L,27L,29L,20L,6L,28L,22L,29L,20L,1L,13L,27L,14L,15L,1L,13L,22L,34L,20L,21L,8L,22L,34L,15L,6L,13L,7L,29L,15L,6L,8L,27L,34L,0L,1L,8L,27L,29L,20L,6L,28L,22L,29L,20L,1L,13L,27L,14L,15L,1L,13L,22L,34L,20L,21L,8L,22L,34L,15L,6L,13L,7L,29L,15L,6L,8L,27L,34L,0L,1L,8L,27L,29L,20L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070497Inst : IEnumerable<long>
{
public static readonly long[] Value=A070497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070497.Bytes);
public long this[int i]=>Value[i];

public static A070497Inst Instance=new A070497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070498
{
public static readonly long[] Value={ 0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L,35L,0L,1L,8L,27L,28L,17L,0L,19L,8L,9L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070498Inst : IEnumerable<long>
{
public static readonly long[] Value=A070498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070498.Bytes);
public long this[int i]=>Value[i];

public static A070498Inst Instance=new A070498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070499
{
public static readonly long[] Value={ 0L,1L,8L,27L,27L,14L,31L,10L,31L,26L,1L,36L,26L,14L,6L,8L,26L,29L,23L,14L,8L,11L,29L,31L,23L,11L,1L,36L,11L,6L,27L,6L,23L,10L,10L,29L,36L,0L,1L,8L,27L,27L,14L,31L,10L,31L,26L,1L,36L,26L,14L,6L,8L,26L,29L,23L,14L,8L,11L,29L,31L,23L,11L,1L,36L,11L,6L,27L,6L,23L,10L,10L,29L,36L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070499Inst : IEnumerable<long>
{
public static readonly long[] Value=A070499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070499.Bytes);
public long this[int i]=>Value[i];

public static A070499Inst Instance=new A070499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070516
{
public static readonly long[] Value={ 0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070516Inst : IEnumerable<long>
{
public static readonly long[] Value=A070516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070516.Bytes);
public long this[int i]=>Value[i];

public static A070516Inst Instance=new A070516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070517
{
public static readonly long[] Value={ 0L,1L,3L,3L,9L,1L,9L,9L,1L,9L,3L,3L,1L,0L,1L,3L,3L,9L,1L,9L,9L,1L,9L,3L,3L,1L,0L,1L,3L,3L,9L,1L,9L,9L,1L,9L,3L,3L,1L,0L,1L,3L,3L,9L,1L,9L,9L,1L,9L,3L,3L,1L,0L,1L,3L,3L,9L,1L,9L,9L,1L,9L,3L,3L,1L,0L,1L,3L,3L,9L,1L,9L,9L,1L,9L,3L,3L,1L,0L,1L,3L,3L,9L,1L,9L,9L,1L,9L,3L,3L,1L,0L,1L,3L,3L,9L,1L,9L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070517Inst : IEnumerable<long>
{
public static readonly long[] Value=A070517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070517.Bytes);
public long this[int i]=>Value[i];

public static A070517Inst Instance=new A070517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070518
{
public static readonly BigInteger[] Value={ 0L,3L,13L,17L,781L,31L,137257L,4097L,532171L,9091L,28531167061L,20593L,25239592216021L,7027567L,2392743361L,4294967297L,BigInteger.Parse("51702516367896047761"),34006393L,BigInteger.Parse("109912203092239643840221"),25536159601L,7006306553612521L };
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
public class A070518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070518Inst Instance=new A070518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070519
{
public static readonly long[] Value={ 2L,3L,4L,6L,10L,12L,14L,19L,31L,46L,74L,75L,98L,102L,126L,180L,236L,310L,368L,1770L,1858L,3512L,4878L,5730L,7547L,7990L,8636L,9378L,11262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070519Inst : IEnumerable<long>
{
public static readonly long[] Value=A070519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070519.Bytes);
public long this[int i]=>Value[i];

public static A070519Inst Instance=new A070519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070520
{
public static readonly BigInteger[] Value={ 3L,13L,17L,31L,9091L,20593L,7027567L,BigInteger.Parse("109912203092239643840221"),BigInteger.Parse("568972471024107865287021434301977158534824481"),BigInteger.Parse("3726767253346131780312487317315864271") };
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
public class A070520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070520Inst Instance=new A070520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070521
{
public static readonly BigInteger[] Value={ 2L,7L,121L,5461L,12207031L,2612138803L,38771752331201L,20587884010836553L,BigInteger.Parse("1107867264956562636991"),BigInteger.Parse("11111111111111111111111111111"),BigInteger.Parse("19194342495775048050414684129181") };
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
public class A070521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070521Inst Instance=new A070521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070522
{
public static readonly BigInteger[] Value={ 1L,4L,31L,50L,16105L,157L,25646167L,130322L,148048057L,683705L,846949229880161L,1872793L,BigInteger.Parse("23127577557875340733"),6177695707L,23304888110401L,62259690411362L,BigInteger.Parse("21930887362370823132822661921"),51520147381L };
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
public class A070522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070522Inst Instance=new A070522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070523
{
public static readonly long[] Value={ 3L,6L,7L,14L,19L,31L,34L,66L,93L,307L,402L,421L,600L,848L,1022L,1057L,1906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070523Inst : IEnumerable<long>
{
public static readonly long[] Value=A070523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070523.Bytes);
public long this[int i]=>Value[i];

public static A070523Inst Instance=new A070523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070524
{
public static readonly BigInteger[] Value={ 0L,2L,7L,5L,341L,3L,55987L,257L,46873L,205L,11111111111L,241L,9726655034461L,39991L,14709241L,16777217L,BigInteger.Parse("19676527011956855057"),46441L,BigInteger.Parse("41660902667961039785743"),16519105L,8177824843189L,9090909091L,BigInteger.Parse("357686347714896679177439424707") };
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
public class A070524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070524Inst Instance=new A070524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070525
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,8L,12L,18L,21L,30L,45L,48L,70L,120L,127L,153L,182L,204L,212L,282L,318L,322L,910L,1167L,1177L,1342L,1680L,1963L,2670L,4398L,4655L,8088L,8599L,8808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070525Inst : IEnumerable<long>
{
public static readonly long[] Value=A070525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070525.Bytes);
public long this[int i]=>Value[i];

public static A070525Inst Instance=new A070525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070526
{
public static readonly BigInteger[] Value={ 1L,5L,73L,257L,1082401L,4033L,4432676798593L,4294967297L,18014398643699713L,1098438933505L,BigInteger.Parse("1298708349570020393652962442872833"),281474959933441L,BigInteger.Parse("91355004067076339167413824240109498970069278721") };
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
public class A070526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070526Inst Instance=new A070526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070527
{
public static readonly long[] Value={ 2L,3L,4L,7L,40L,59L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070527Inst : IEnumerable<long>
{
public static readonly long[] Value=A070527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070527.Bytes);
public long this[int i]=>Value[i];

public static A070527Inst Instance=new A070527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070528
{
public static readonly long[] Value={ 3L,6L,8L,12L,12L,64L,12L,48L,20L,48L,12L,256L,24L,48L,128L,192L,12L,640L,6L,384L,256L,288L,6L,2048L,96L,192L,96L,768L,96L,16384L,24L,6144L,128L,192L,384L,5120L,24L,24L,128L,6144L,48L,49152L,48L,4608L,1280L,192L,12L,16384L,48L,3072L,512L,1536L,48L,12288L,768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070528Inst : IEnumerable<long>
{
public static readonly long[] Value=A070528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070528.Bytes);
public long this[int i]=>Value[i];

public static A070528Inst Instance=new A070528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070529
{
public static readonly long[] Value={ 1L,2L,4L,4L,4L,32L,4L,16L,12L,16L,4L,128L,8L,16L,64L,64L,4L,384L,2L,128L,128L,96L,2L,1024L,32L,64L,64L,256L,32L,8192L,8L,2048L,64L,64L,128L,3072L,8L,8L,64L,2048L,16L,24576L,16L,1536L,768L,64L,4L,8192L,16L,1024L,256L,512L,16L,8192L,256L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070529Inst : IEnumerable<long>
{
public static readonly long[] Value=A070529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070529.Bytes);
public long this[int i]=>Value[i];

public static A070529Inst Instance=new A070529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070530
{
public static readonly long[] Value={ 5L,73L,257L,4432676798593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070530Inst : IEnumerable<long>
{
public static readonly long[] Value=A070530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070530.Bytes);
public long this[int i]=>Value[i];

public static A070530Inst Instance=new A070530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070531
{
public static readonly BigInteger[] Value={ 1L,73L,16333L,8030353L,7209986401L,10541813012041L,23227377813664333L,BigInteger.Parse("72925401604382826913"),BigInteger.Parse("312727862321385812968033") };
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
public class A070531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070531Inst Instance=new A070531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070564
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070564Inst : IEnumerable<long>
{
public static readonly long[] Value=A070564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070564.Bytes);
public long this[int i]=>Value[i];

public static A070564Inst Instance=new A070564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070565
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,30L,28L,26L,24L,22L,20L,18L,16L,14L,12L,40L,37L,34L,31L,28L,25L,22L,19L,16L,13L,50L,46L,42L,38L,34L,30L,26L,22L,18L,14L,60L,55L,50L,45L,40L,35L,30L,25L,20L,15L,70L,64L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070565Inst : IEnumerable<long>
{
public static readonly long[] Value=A070565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070565.Bytes);
public long this[int i]=>Value[i];

public static A070565Inst Instance=new A070565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070566
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,49L,53L,57L,59L,61L,67L,71L,73L,79L,83L,87L,89L,93L,97L,101L,103L,107L,109L,113L,117L,121L,127L,131L,137L,139L,145L,149L,151L,157L,163L,167L,169L,173L,177L,179L,181L,189L,191L,193L,197L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070566Inst : IEnumerable<long>
{
public static readonly long[] Value=A070566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070566.Bytes);
public long this[int i]=>Value[i];

public static A070566Inst Instance=new A070566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070567
{
public static readonly long[] Value={ 0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L,0L,1L,16L,9L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070567Inst : IEnumerable<long>
{
public static readonly long[] Value=A070567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070567.Bytes);
public long this[int i]=>Value[i];

public static A070567Inst Instance=new A070567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070568
{
public static readonly long[] Value={ 0L,1L,16L,6L,6L,0L,21L,1L,21L,11L,0L,16L,11L,11L,16L,0L,11L,21L,1L,21L,0L,6L,6L,16L,1L,0L,1L,16L,6L,6L,0L,21L,1L,21L,11L,0L,16L,11L,11L,16L,0L,11L,21L,1L,21L,0L,6L,6L,16L,1L,0L,1L,16L,6L,6L,0L,21L,1L,21L,11L,0L,16L,11L,11L,16L,0L,11L,21L,1L,21L,0L,6L,6L,16L,1L,0L,1L,16L,6L,6L,0L,21L,1L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070568Inst : IEnumerable<long>
{
public static readonly long[] Value=A070568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070568.Bytes);
public long this[int i]=>Value[i];

public static A070568Inst Instance=new A070568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070569
{
public static readonly long[] Value={ 0L,1L,16L,3L,22L,1L,22L,9L,14L,9L,16L,3L,14L,13L,14L,3L,16L,9L,14L,9L,22L,1L,22L,3L,16L,1L,0L,1L,16L,3L,22L,1L,22L,9L,14L,9L,16L,3L,14L,13L,14L,3L,16L,9L,14L,9L,22L,1L,22L,3L,16L,1L,0L,1L,16L,3L,22L,1L,22L,9L,14L,9L,16L,3L,14L,13L,14L,3L,16L,9L,14L,9L,22L,1L,22L,3L,16L,1L,0L,1L,16L,3L,22L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070569Inst : IEnumerable<long>
{
public static readonly long[] Value=A070569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070569.Bytes);
public long this[int i]=>Value[i];

public static A070569Inst Instance=new A070569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070570
{
public static readonly long[] Value={ 0L,1L,16L,0L,13L,4L,0L,25L,19L,0L,10L,7L,0L,22L,22L,0L,7L,10L,0L,19L,25L,0L,4L,13L,0L,16L,1L,0L,1L,16L,0L,13L,4L,0L,25L,19L,0L,10L,7L,0L,22L,22L,0L,7L,10L,0L,19L,25L,0L,4L,13L,0L,16L,1L,0L,1L,16L,0L,13L,4L,0L,25L,19L,0L,10L,7L,0L,22L,22L,0L,7L,10L,0L,19L,25L,0L,4L,13L,0L,16L,1L,0L,1L,16L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070570Inst : IEnumerable<long>
{
public static readonly long[] Value=A070570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070570.Bytes);
public long this[int i]=>Value[i];

public static A070570Inst Instance=new A070570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070571
{
public static readonly long[] Value={ 0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L,4L,9L,8L,21L,8L,9L,4L,25L,16L,1L,0L,1L,16L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070571Inst : IEnumerable<long>
{
public static readonly long[] Value=A070571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070571.Bytes);
public long this[int i]=>Value[i];

public static A070571Inst Instance=new A070571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070572
{
public static readonly long[] Value={ 0L,1L,16L,23L,24L,16L,20L,23L,7L,7L,24L,25L,1L,25L,20L,20L,25L,1L,25L,24L,7L,7L,23L,20L,16L,24L,23L,16L,1L,0L,1L,16L,23L,24L,16L,20L,23L,7L,7L,24L,25L,1L,25L,20L,20L,25L,1L,25L,24L,7L,7L,23L,20L,16L,24L,23L,16L,1L,0L,1L,16L,23L,24L,16L,20L,23L,7L,7L,24L,25L,1L,25L,20L,20L,25L,1L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070572Inst : IEnumerable<long>
{
public static readonly long[] Value=A070572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070572.Bytes);
public long this[int i]=>Value[i];

public static A070572Inst Instance=new A070572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070573
{
public static readonly long[] Value={ 0L,1L,16L,21L,16L,25L,6L,1L,16L,21L,10L,1L,6L,1L,16L,15L,16L,1L,6L,1L,10L,21L,16L,1L,6L,25L,16L,21L,16L,1L,0L,1L,16L,21L,16L,25L,6L,1L,16L,21L,10L,1L,6L,1L,16L,15L,16L,1L,6L,1L,10L,21L,16L,1L,6L,25L,16L,21L,16L,1L,0L,1L,16L,21L,16L,25L,6L,1L,16L,21L,10L,1L,6L,1L,16L,15L,16L,1L,6L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070573Inst : IEnumerable<long>
{
public static readonly long[] Value=A070573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070573.Bytes);
public long this[int i]=>Value[i];

public static A070573Inst Instance=new A070573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070574
{
public static readonly long[] Value={ 0L,1L,16L,19L,8L,5L,25L,14L,4L,20L,18L,9L,28L,10L,7L,2L,2L,7L,10L,28L,9L,18L,20L,4L,14L,25L,5L,8L,19L,16L,1L,0L,1L,16L,19L,8L,5L,25L,14L,4L,20L,18L,9L,28L,10L,7L,2L,2L,7L,10L,28L,9L,18L,20L,4L,14L,25L,5L,8L,19L,16L,1L,0L,1L,16L,19L,8L,5L,25L,14L,4L,20L,18L,9L,28L,10L,7L,2L,2L,7L,10L,28L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070574Inst : IEnumerable<long>
{
public static readonly long[] Value=A070574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070574.Bytes);
public long this[int i]=>Value[i];

public static A070574Inst Instance=new A070574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070575
{
public static readonly long[] Value={ 0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L,0L,17L,16L,1L,0L,1L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070575Inst : IEnumerable<long>
{
public static readonly long[] Value=A070575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070575.Bytes);
public long this[int i]=>Value[i];

public static A070575Inst Instance=new A070575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070576
{
public static readonly long[] Value={ 0L,1L,16L,15L,25L,31L,9L,25L,4L,27L,1L,22L,12L,16L,4L,3L,31L,31L,3L,4L,16L,12L,22L,1L,27L,4L,25L,9L,31L,25L,15L,16L,1L,0L,1L,16L,15L,25L,31L,9L,25L,4L,27L,1L,22L,12L,16L,4L,3L,31L,31L,3L,4L,16L,12L,22L,1L,27L,4L,25L,9L,31L,25L,15L,16L,1L,0L,1L,16L,15L,25L,31L,9L,25L,4L,27L,1L,22L,12L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070576Inst : IEnumerable<long>
{
public static readonly long[] Value=A070576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070576.Bytes);
public long this[int i]=>Value[i];

public static A070576Inst Instance=new A070576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070577
{
public static readonly long[] Value={ 0L,1L,16L,13L,18L,13L,4L,21L,16L,33L,4L,21L,30L,1L,30L,33L,18L,17L,18L,33L,30L,1L,30L,21L,4L,33L,16L,21L,4L,13L,18L,13L,16L,1L,0L,1L,16L,13L,18L,13L,4L,21L,16L,33L,4L,21L,30L,1L,30L,33L,18L,17L,18L,33L,30L,1L,30L,21L,4L,33L,16L,21L,4L,13L,18L,13L,16L,1L,0L,1L,16L,13L,18L,13L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070577Inst : IEnumerable<long>
{
public static readonly long[] Value=A070577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070577.Bytes);
public long this[int i]=>Value[i];

public static A070577Inst Instance=new A070577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070578
{
public static readonly long[] Value={ 0L,1L,16L,11L,11L,30L,1L,21L,1L,16L,25L,11L,16L,1L,21L,15L,16L,11L,11L,16L,15L,21L,1L,16L,11L,25L,16L,1L,21L,1L,30L,11L,11L,16L,1L,0L,1L,16L,11L,11L,30L,1L,21L,1L,16L,25L,11L,16L,1L,21L,15L,16L,11L,11L,16L,15L,21L,1L,16L,11L,25L,16L,1L,21L,1L,30L,11L,11L,16L,1L,0L,1L,16L,11L,11L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070578Inst : IEnumerable<long>
{
public static readonly long[] Value=A070578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070578.Bytes);
public long this[int i]=>Value[i];

public static A070578Inst Instance=new A070578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070579
{
public static readonly long[] Value={ 0L,1L,16L,9L,4L,13L,0L,25L,28L,9L,28L,25L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,25L,28L,9L,28L,25L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,25L,28L,9L,28L,25L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,25L,28L,9L,28L,25L,0L,13L,4L,9L,16L,1L,0L,1L,16L,9L,4L,13L,0L,25L,28L,9L,28L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070579Inst : IEnumerable<long>
{
public static readonly long[] Value=A070579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070579.Bytes);
public long this[int i]=>Value[i];

public static A070579Inst Instance=new A070579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070612
{
public static readonly long[] Value={ 0L,1L,4L,19L,16L,17L,20L,7L,8L,25L,12L,23L,24L,13L,0L,15L,4L,5L,16L,3L,20L,21L,8L,11L,12L,9L,24L,27L,0L,1L,4L,19L,16L,17L,20L,7L,8L,25L,12L,23L,24L,13L,0L,15L,4L,5L,16L,3L,20L,21L,8L,11L,12L,9L,24L,27L,0L,1L,4L,19L,16L,17L,20L,7L,8L,25L,12L,23L,24L,13L,0L,15L,4L,5L,16L,3L,20L,21L,8L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070612Inst : IEnumerable<long>
{
public static readonly long[] Value=A070612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070612.Bytes);
public long this[int i]=>Value[i];

public static A070612Inst Instance=new A070612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070613
{
public static readonly long[] Value={ 0L,1L,3L,11L,9L,22L,4L,16L,27L,5L,8L,14L,12L,6L,19L,10L,23L,17L,15L,21L,24L,2L,13L,25L,7L,20L,18L,26L,28L,0L,1L,3L,11L,9L,22L,4L,16L,27L,5L,8L,14L,12L,6L,19L,10L,23L,17L,15L,21L,24L,2L,13L,25L,7L,20L,18L,26L,28L,0L,1L,3L,11L,9L,22L,4L,16L,27L,5L,8L,14L,12L,6L,19L,10L,23L,17L,15L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070613Inst : IEnumerable<long>
{
public static readonly long[] Value=A070613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070613.Bytes);
public long this[int i]=>Value[i];

public static A070613Inst Instance=new A070613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070614
{
public static readonly long[] Value={ 0L,1L,1L,26L,1L,25L,26L,5L,1L,25L,25L,6L,26L,6L,5L,30L,1L,26L,25L,5L,25L,6L,6L,30L,26L,5L,6L,30L,5L,30L,30L,0L,1L,1L,26L,1L,25L,26L,5L,1L,25L,25L,6L,26L,6L,5L,30L,1L,26L,25L,5L,25L,6L,6L,30L,26L,5L,6L,30L,5L,30L,30L,0L,1L,1L,26L,1L,25L,26L,5L,1L,25L,25L,6L,26L,6L,5L,30L,1L,26L,25L,5L,25L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070614Inst : IEnumerable<long>
{
public static readonly long[] Value=A070614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070614.Bytes);
public long this[int i]=>Value[i];

public static A070614Inst Instance=new A070614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070615
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070615Inst : IEnumerable<long>
{
public static readonly long[] Value=A070615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070615.Bytes);
public long this[int i]=>Value[i];

public static A070615Inst Instance=new A070615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070616
{
public static readonly long[] Value={ 0L,1L,32L,12L,1L,23L,21L,10L,32L,12L,10L,11L,12L,10L,23L,12L,1L,32L,21L,10L,23L,21L,22L,23L,21L,1L,23L,12L,10L,32L,21L,1L,32L,0L,1L,32L,12L,1L,23L,21L,10L,32L,12L,10L,11L,12L,10L,23L,12L,1L,32L,21L,10L,23L,21L,22L,23L,21L,1L,23L,12L,10L,32L,21L,1L,32L,0L,1L,32L,12L,1L,23L,21L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070616Inst : IEnumerable<long>
{
public static readonly long[] Value=A070616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070616.Bytes);
public long this[int i]=>Value[i];

public static A070616Inst Instance=new A070616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070617
{
public static readonly long[] Value={ 0L,1L,32L,5L,4L,31L,24L,11L,26L,25L,6L,27L,20L,13L,12L,19L,16L,17L,18L,15L,22L,21L,14L,7L,28L,9L,8L,23L,10L,3L,30L,29L,2L,33L,0L,1L,32L,5L,4L,31L,24L,11L,26L,25L,6L,27L,20L,13L,12L,19L,16L,17L,18L,15L,22L,21L,14L,7L,28L,9L,8L,23L,10L,3L,30L,29L,2L,33L,0L,1L,32L,5L,4L,31L,24L,11L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070617Inst : IEnumerable<long>
{
public static readonly long[] Value=A070617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070617.Bytes);
public long this[int i]=>Value[i];

public static A070617Inst Instance=new A070617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070618
{
public static readonly long[] Value={ 0L,1L,32L,33L,9L,10L,6L,7L,8L,4L,5L,16L,17L,13L,14L,15L,11L,12L,23L,24L,20L,21L,22L,18L,19L,30L,31L,27L,28L,29L,25L,26L,2L,3L,34L,0L,1L,32L,33L,9L,10L,6L,7L,8L,4L,5L,16L,17L,13L,14L,15L,11L,12L,23L,24L,20L,21L,22L,18L,19L,30L,31L,27L,28L,29L,25L,26L,2L,3L,34L,0L,1L,32L,33L,9L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070618Inst : IEnumerable<long>
{
public static readonly long[] Value=A070618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070618.Bytes);
public long this[int i]=>Value[i];

public static A070618Inst Instance=new A070618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070619
{
public static readonly long[] Value={ 0L,1L,32L,27L,16L,29L,0L,31L,8L,9L,28L,23L,0L,25L,20L,27L,4L,17L,0L,19L,32L,9L,16L,11L,0L,13L,8L,27L,28L,5L,0L,7L,20L,9L,4L,35L,0L,1L,32L,27L,16L,29L,0L,31L,8L,9L,28L,23L,0L,25L,20L,27L,4L,17L,0L,19L,32L,9L,16L,11L,0L,13L,8L,27L,28L,5L,0L,7L,20L,9L,4L,35L,0L,1L,32L,27L,16L,29L,0L,31L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070619Inst : IEnumerable<long>
{
public static readonly long[] Value=A070619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070619.Bytes);
public long this[int i]=>Value[i];

public static A070619Inst Instance=new A070619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070620
{
public static readonly long[] Value={ 0L,1L,32L,21L,25L,17L,6L,9L,23L,34L,26L,27L,7L,35L,29L,24L,33L,19L,15L,22L,18L,4L,13L,8L,2L,30L,10L,11L,3L,14L,28L,31L,20L,12L,16L,5L,36L,0L,1L,32L,21L,25L,17L,6L,9L,23L,34L,26L,27L,7L,35L,29L,24L,33L,19L,15L,22L,18L,4L,13L,8L,2L,30L,10L,11L,3L,14L,28L,31L,20L,12L,16L,5L,36L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070620Inst : IEnumerable<long>
{
public static readonly long[] Value=A070620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070620.Bytes);
public long this[int i]=>Value[i];

public static A070620Inst Instance=new A070620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070621
{
public static readonly long[] Value={ 0L,1L,32L,15L,36L,9L,24L,11L,12L,35L,22L,7L,8L,33L,10L,21L,4L,25L,18L,19L,20L,13L,34L,17L,28L,5L,30L,31L,16L,3L,26L,27L,14L,29L,2L,23L,6L,37L,0L,1L,32L,15L,36L,9L,24L,11L,12L,35L,22L,7L,8L,33L,10L,21L,4L,25L,18L,19L,20L,13L,34L,17L,28L,5L,30L,31L,16L,3L,26L,27L,14L,29L,2L,23L,6L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070621Inst : IEnumerable<long>
{
public static readonly long[] Value=A070621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070621.Bytes);
public long this[int i]=>Value[i];

public static A070621Inst Instance=new A070621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070622
{
public static readonly long[] Value={ 0L,1L,32L,9L,10L,5L,15L,37L,8L,3L,4L,20L,12L,13L,14L,6L,22L,23L,18L,28L,11L,21L,16L,17L,33L,25L,26L,27L,19L,35L,36L,31L,2L,24L,34L,29L,30L,7L,38L,0L,1L,32L,9L,10L,5L,15L,37L,8L,3L,4L,20L,12L,13L,14L,6L,22L,23L,18L,28L,11L,21L,16L,17L,33L,25L,26L,27L,19L,35L,36L,31L,2L,24L,34L,29L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070622Inst : IEnumerable<long>
{
public static readonly long[] Value=A070622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070622.Bytes);
public long this[int i]=>Value[i];

public static A070622Inst Instance=new A070622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070623
{
public static readonly long[] Value={ 0L,1L,32L,3L,24L,5L,16L,7L,8L,9L,0L,11L,32L,13L,24L,15L,16L,17L,8L,19L,0L,21L,32L,23L,24L,25L,16L,27L,8L,29L,0L,31L,32L,33L,24L,35L,16L,37L,8L,39L,0L,1L,32L,3L,24L,5L,16L,7L,8L,9L,0L,11L,32L,13L,24L,15L,16L,17L,8L,19L,0L,21L,32L,23L,24L,25L,16L,27L,8L,29L,0L,31L,32L,33L,24L,35L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070623Inst : IEnumerable<long>
{
public static readonly long[] Value=A070623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070623.Bytes);
public long this[int i]=>Value[i];

public static A070623Inst Instance=new A070623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070624
{
public static readonly long[] Value={ 0L,1L,32L,38L,40L,9L,27L,38L,9L,9L,1L,3L,3L,38L,27L,14L,1L,27L,1L,27L,32L,9L,14L,40L,14L,40L,27L,14L,3L,38L,38L,40L,32L,32L,3L,14L,32L,1L,3L,9L,40L,0L,1L,32L,38L,40L,9L,27L,38L,9L,9L,1L,3L,3L,38L,27L,14L,1L,27L,1L,27L,32L,9L,14L,40L,14L,40L,27L,14L,3L,38L,38L,40L,32L,32L,3L,14L,32L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070624Inst : IEnumerable<long>
{
public static readonly long[] Value=A070624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070624.Bytes);
public long this[int i]=>Value[i];

public static A070624Inst Instance=new A070624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070625
{
public static readonly long[] Value={ 0L,1L,32L,33L,16L,17L,6L,7L,8L,39L,40L,23L,24L,13L,14L,15L,4L,5L,30L,31L,20L,21L,22L,11L,12L,37L,38L,27L,28L,29L,18L,19L,2L,3L,34L,35L,36L,25L,26L,9L,10L,41L,0L,1L,32L,33L,16L,17L,6L,7L,8L,39L,40L,23L,24L,13L,14L,15L,4L,5L,30L,31L,20L,21L,22L,11L,12L,37L,38L,27L,28L,29L,18L,19L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070625Inst : IEnumerable<long>
{
public static readonly long[] Value=A070625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070625.Bytes);
public long this[int i]=>Value[i];

public static A070625Inst Instance=new A070625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070626
{
public static readonly long[] Value={ 0L,1L,32L,28L,35L,29L,36L,37L,2L,10L,25L,16L,34L,31L,23L,38L,21L,40L,19L,30L,26L,4L,39L,17L,13L,24L,3L,22L,5L,20L,12L,9L,27L,18L,33L,41L,6L,7L,14L,8L,15L,11L,42L,0L,1L,32L,28L,35L,29L,36L,37L,2L,10L,25L,16L,34L,31L,23L,38L,21L,40L,19L,30L,26L,4L,39L,17L,13L,24L,3L,22L,5L,20L,12L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070626Inst : IEnumerable<long>
{
public static readonly long[] Value=A070626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070626.Bytes);
public long this[int i]=>Value[i];

public static A070626Inst Instance=new A070626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070627
{
public static readonly long[] Value={ 0L,1L,32L,23L,12L,1L,32L,43L,32L,1L,32L,11L,12L,21L,12L,23L,12L,21L,32L,43L,12L,21L,0L,23L,32L,1L,12L,23L,32L,21L,32L,23L,32L,33L,12L,43L,12L,1L,12L,43L,32L,21L,12L,43L,0L,1L,32L,23L,12L,1L,32L,43L,32L,1L,32L,11L,12L,21L,12L,23L,12L,21L,32L,43L,12L,21L,0L,23L,32L,1L,12L,23L,32L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070627Inst : IEnumerable<long>
{
public static readonly long[] Value=A070627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070627.Bytes);
public long this[int i]=>Value[i];

public static A070627Inst Instance=new A070627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070676
{
public static readonly long[] Value={ 0L,1L,0L,2L,4L,0L,6L,2L,0L,4L,5L,0L,3L,6L,0L,4L,16L,0L,18L,4L,0L,5L,11L,0L,20L,3L,0L,6L,28L,0L,30L,8L,0L,16L,12L,0L,18L,18L,0L,4L,8L,0L,42L,10L,0L,11L,23L,0L,42L,20L,0L,6L,52L,0L,20L,6L,0L,28L,29L,0L,10L,30L,0L,16L,12L,0L,22L,16L,0L,12L,35L,0L,12L,18L,0L,18L,30L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070676Inst : IEnumerable<long>
{
public static readonly long[] Value=A070676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070676.Bytes);
public long this[int i]=>Value[i];

public static A070676Inst Instance=new A070676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070677
{
public static readonly long[] Value={ 0L,1L,2L,1L,0L,2L,6L,2L,6L,0L,5L,2L,4L,6L,0L,4L,16L,6L,9L,0L,6L,5L,22L,2L,0L,4L,18L,6L,14L,0L,3L,8L,10L,16L,0L,6L,36L,9L,4L,0L,20L,6L,42L,5L,0L,22L,46L,4L,42L,0L,16L,4L,52L,18L,0L,6L,18L,14L,29L,0L,30L,3L,6L,16L,0L,10L,22L,16L,22L,0L,5L,6L,72L,36L,0L,9L,30L,4L,39L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070677Inst : IEnumerable<long>
{
public static readonly long[] Value=A070677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070677.Bytes);
public long this[int i]=>Value[i];

public static A070677Inst Instance=new A070677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070678
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,1L,0L,2L,3L,4L,10L,2L,12L,0L,4L,2L,16L,3L,3L,4L,0L,10L,22L,2L,4L,12L,9L,0L,7L,4L,15L,4L,10L,16L,0L,6L,9L,3L,12L,4L,40L,0L,6L,10L,12L,22L,23L,2L,0L,4L,16L,12L,26L,9L,20L,0L,3L,7L,29L,4L,60L,15L,0L,8L,12L,10L,66L,16L,22L,0L,70L,6L,24L,9L,4L,6L,0L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070678Inst : IEnumerable<long>
{
public static readonly long[] Value=A070678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070678.Bytes);
public long this[int i]=>Value[i];

public static A070678Inst Instance=new A070678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070679
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,3L,1L,0L,2L,5L,0L,3L,3L,0L,2L,8L,0L,9L,2L,0L,5L,11L,0L,10L,3L,0L,3L,14L,0L,15L,4L,0L,8L,6L,0L,9L,9L,0L,2L,4L,0L,21L,5L,0L,11L,23L,0L,21L,10L,0L,3L,26L,0L,10L,3L,0L,14L,29L,0L,5L,15L,0L,8L,6L,0L,11L,8L,0L,6L,35L,0L,6L,9L,0L,9L,15L,0L,39L,2L,0L,4L,41L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070679Inst : IEnumerable<long>
{
public static readonly long[] Value=A070679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070679.Bytes);
public long this[int i]=>Value[i];

public static A070679Inst Instance=new A070679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070680
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,2L,3L,2L,6L,1L,0L,2L,12L,3L,2L,4L,16L,6L,3L,2L,6L,0L,22L,2L,5L,12L,18L,6L,28L,2L,30L,8L,0L,16L,3L,6L,6L,3L,12L,2L,40L,6L,7L,0L,6L,22L,46L,4L,21L,5L,16L,12L,26L,18L,0L,6L,6L,28L,58L,2L,4L,30L,6L,16L,12L,0L,66L,16L,22L,3L,70L,6L,72L,6L,10L,6L,0L,12L,39L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070680Inst : IEnumerable<long>
{
public static readonly long[] Value=A070680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070680.Bytes);
public long this[int i]=>Value[i];

public static A070680Inst Instance=new A070680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070681
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,10L,12L,0L,16L,9L,0L,11L,5L,0L,14L,6L,0L,2L,4L,0L,40L,3L,0L,23L,14L,0L,26L,10L,0L,58L,60L,0L,12L,33L,0L,35L,36L,0L,10L,78L,0L,82L,16L,0L,88L,12L,0L,9L,12L,0L,10L,102L,0L,106L,108L,0L,112L,11L,0L,16L,110L,0L,25L,126L,0L,130L,18L,0L,136L,23L,0L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070681Inst : IEnumerable<long>
{
public static readonly long[] Value=A070681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070681.Bytes);
public long this[int i]=>Value[i];

public static A070681Inst Instance=new A070681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070682
{
public static readonly long[] Value={ 0L,1L,0L,6L,1L,2L,6L,0L,16L,18L,6L,22L,0L,3L,28L,15L,2L,0L,3L,6L,5L,21L,0L,46L,42L,16L,13L,0L,18L,58L,60L,6L,0L,33L,22L,35L,8L,0L,6L,13L,9L,41L,0L,28L,44L,6L,15L,0L,96L,2L,4L,34L,0L,53L,108L,3L,112L,0L,6L,48L,22L,5L,0L,42L,21L,130L,18L,0L,8L,46L,46L,6L,0L,42L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070682Inst : IEnumerable<long>
{
public static readonly long[] Value=A070682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070682.Bytes);
public long this[int i]=>Value[i];

public static A070682Inst Instance=new A070682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070683
{
public static readonly long[] Value={ 0L,0L,4L,6L,0L,1L,2L,0L,16L,6L,0L,11L,20L,0L,4L,30L,0L,12L,9L,0L,40L,42L,0L,23L,42L,0L,52L,4L,0L,29L,15L,0L,4L,66L,0L,35L,36L,0L,6L,26L,0L,41L,16L,0L,8L,6L,0L,12L,16L,0L,100L,102L,0L,53L,54L,0L,112L,44L,0L,48L,11L,0L,100L,126L,0L,65L,6L,0L,136L,138L,0L,2L,4L,0L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070683Inst : IEnumerable<long>
{
public static readonly long[] Value=A070683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070683.Bytes);
public long this[int i]=>Value[i];

public static A070683Inst Instance=new A070683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070684
{
public static readonly long[] Value={ 0L,1L,20L,25L,4L,5L,16L,37L,36L,9L,12L,33L,12L,9L,36L,37L,16L,5L,4L,25L,20L,1L,0L,1L,20L,25L,4L,5L,16L,37L,36L,9L,12L,33L,12L,9L,36L,37L,16L,5L,4L,25L,20L,1L,0L,1L,20L,25L,4L,5L,16L,37L,36L,9L,12L,33L,12L,9L,36L,37L,16L,5L,4L,25L,20L,1L,0L,1L,20L,25L,4L,5L,16L,37L,36L,9L,12L,33L,12L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070684Inst : IEnumerable<long>
{
public static readonly long[] Value=A070684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070684.Bytes);
public long this[int i]=>Value[i];

public static A070684Inst Instance=new A070684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070685
{
public static readonly long[] Value={ 0L,1L,19L,9L,1L,10L,36L,19L,19L,36L,10L,1L,9L,19L,1L,0L,1L,19L,9L,1L,10L,36L,19L,19L,36L,10L,1L,9L,19L,1L,0L,1L,19L,9L,1L,10L,36L,19L,19L,36L,10L,1L,9L,19L,1L,0L,1L,19L,9L,1L,10L,36L,19L,19L,36L,10L,1L,9L,19L,1L,0L,1L,19L,9L,1L,10L,36L,19L,19L,36L,10L,1L,9L,19L,1L,0L,1L,19L,9L,1L,10L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070685Inst : IEnumerable<long>
{
public static readonly long[] Value=A070685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070685.Bytes);
public long this[int i]=>Value[i];

public static A070685Inst Instance=new A070685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070686
{
public static readonly long[] Value={ 0L,1L,18L,39L,2L,31L,12L,27L,36L,3L,6L,9L,32L,29L,26L,13L,4L,35L,8L,25L,16L,41L,24L,23L,24L,41L,16L,25L,8L,35L,4L,13L,26L,29L,32L,9L,6L,3L,36L,27L,12L,31L,2L,39L,18L,1L,0L,1L,18L,39L,2L,31L,12L,27L,36L,3L,6L,9L,32L,29L,26L,13L,4L,35L,8L,25L,16L,41L,24L,23L,24L,41L,16L,25L,8L,35L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070686Inst : IEnumerable<long>
{
public static readonly long[] Value=A070686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070686.Bytes);
public long this[int i]=>Value[i];

public static A070686Inst Instance=new A070686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070687
{
public static readonly long[] Value={ 0L,1L,17L,24L,7L,21L,32L,8L,25L,12L,28L,37L,27L,3L,42L,34L,2L,14L,16L,9L,6L,4L,18L,36L,36L,18L,4L,6L,9L,16L,14L,2L,34L,42L,3L,27L,37L,28L,12L,25L,8L,32L,21L,7L,24L,17L,1L,0L,1L,17L,24L,7L,21L,32L,8L,25L,12L,28L,37L,27L,3L,42L,34L,2L,14L,16L,9L,6L,4L,18L,36L,36L,18L,4L,6L,9L,16L,14L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070687Inst : IEnumerable<long>
{
public static readonly long[] Value=A070687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070687.Bytes);
public long this[int i]=>Value[i];

public static A070687Inst Instance=new A070687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070688
{
public static readonly long[] Value={ 0L,1L,16L,9L,16L,25L,0L,1L,16L,33L,16L,25L,0L,25L,16L,33L,16L,1L,0L,25L,16L,9L,16L,1L,0L,1L,16L,9L,16L,25L,0L,1L,16L,33L,16L,25L,0L,25L,16L,33L,16L,1L,0L,25L,16L,9L,16L,1L,0L,1L,16L,9L,16L,25L,0L,1L,16L,33L,16L,25L,0L,25L,16L,33L,16L,1L,0L,25L,16L,9L,16L,1L,0L,1L,16L,9L,16L,25L,0L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070688Inst : IEnumerable<long>
{
public static readonly long[] Value=A070688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070688.Bytes);
public long this[int i]=>Value[i];

public static A070688Inst Instance=new A070688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070689
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,16L,36L,40L,66L,126L,130L,150L,156L,180L,210L,240L,250L,256L,270L,280L,306L,396L,400L,420L,430L,466L,490L,556L,570L,576L,646L,690L,700L,750L,760L,826L,906L,910L,936L,946L,966L,1060L,1096L,1150L,1276L,1290L,1306L,1320L,1366L,1566L,1570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070689Inst : IEnumerable<long>
{
public static readonly long[] Value=A070689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070689.Bytes);
public long this[int i]=>Value[i];

public static A070689Inst Instance=new A070689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070690
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070690Inst : IEnumerable<long>
{
public static readonly long[] Value=A070690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070690.Bytes);
public long this[int i]=>Value[i];

public static A070690Inst Instance=new A070690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070691
{
public static readonly ulong[] Value={ 1L,4L,27L,256L,3125L,46656L,823543L,16777216L,387420489L,1L,2048L,531441L,67108864L,6103515625L,470184984576L,33232930569601L,2251799813685248L,150094635296999121L,10000000000000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070691Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A070691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070691.Bytes);
public ulong this[int i]=>Value[i];

public static A070691Inst Instance=new A070691Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070708
{
public static readonly long[] Value={ 0L,1L,20L,0L,22L,14L,0L,16L,8L,0L,10L,2L,0L,4L,23L,0L,25L,17L,0L,19L,11L,0L,13L,5L,0L,7L,26L,0L,1L,20L,0L,22L,14L,0L,16L,8L,0L,10L,2L,0L,4L,23L,0L,25L,17L,0L,19L,11L,0L,13L,5L,0L,7L,26L,0L,1L,20L,0L,22L,14L,0L,16L,8L,0L,10L,2L,0L,4L,23L,0L,25L,17L,0L,19L,11L,0L,13L,5L,0L,7L,26L,0L,1L,20L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070708Inst : IEnumerable<long>
{
public static readonly long[] Value=A070708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070708.Bytes);
public long this[int i]=>Value[i];

public static A070708Inst Instance=new A070708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070709
{
public static readonly long[] Value={ 0L,1L,16L,3L,4L,5L,20L,7L,8L,9L,24L,11L,12L,13L,0L,15L,16L,17L,4L,19L,20L,21L,8L,23L,24L,25L,12L,27L,0L,1L,16L,3L,4L,5L,20L,7L,8L,9L,24L,11L,12L,13L,0L,15L,16L,17L,4L,19L,20L,21L,8L,23L,24L,25L,12L,27L,0L,1L,16L,3L,4L,5L,20L,7L,8L,9L,24L,11L,12L,13L,0L,15L,16L,17L,4L,19L,20L,21L,8L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070709Inst : IEnumerable<long>
{
public static readonly long[] Value=A070709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070709.Bytes);
public long this[int i]=>Value[i];

public static A070709Inst Instance=new A070709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070710
{
public static readonly long[] Value={ 0L,1L,12L,12L,28L,28L,28L,1L,17L,28L,17L,12L,17L,28L,12L,17L,1L,12L,17L,12L,1L,12L,28L,1L,1L,1L,17L,17L,28L,0L,1L,12L,12L,28L,28L,28L,1L,17L,28L,17L,12L,17L,28L,12L,17L,1L,12L,17L,12L,1L,12L,28L,1L,1L,1L,17L,17L,28L,0L,1L,12L,12L,28L,28L,28L,1L,17L,28L,17L,12L,17L,28L,12L,17L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070710Inst : IEnumerable<long>
{
public static readonly long[] Value=A070710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070710.Bytes);
public long this[int i]=>Value[i];

public static A070710Inst Instance=new A070710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070711
{
public static readonly long[] Value={ 0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L,12L,19L,20L,21L,28L,17L,24L,25L,26L,3L,22L,29L,0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L,12L,19L,20L,21L,28L,17L,24L,25L,26L,3L,22L,29L,0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070711Inst : IEnumerable<long>
{
public static readonly long[] Value=A070711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070711.Bytes);
public long this[int i]=>Value[i];

public static A070711Inst Instance=new A070711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070712
{
public static readonly long[] Value={ 0L,1L,4L,17L,16L,5L,6L,28L,2L,10L,20L,13L,24L,22L,19L,23L,8L,12L,9L,7L,18L,11L,21L,29L,3L,25L,26L,15L,14L,27L,30L,0L,1L,4L,17L,16L,5L,6L,28L,2L,10L,20L,13L,24L,22L,19L,23L,8L,12L,9L,7L,18L,11L,21L,29L,3L,25L,26L,15L,14L,27L,30L,0L,1L,4L,17L,16L,5L,6L,28L,2L,10L,20L,13L,24L,22L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070712Inst : IEnumerable<long>
{
public static readonly long[] Value=A070712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070712.Bytes);
public long this[int i]=>Value[i];

public static A070712Inst Instance=new A070712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070713
{
public static readonly long[] Value={ 1L,4L,9L,22L,88L,144L,414L,441L,466L,646L,664L,889L,898L,988L,1111L,1177L,1224L,1242L,1339L,1393L,1422L,1717L,1771L,1933L,2124L,2142L,2214L,2241L,2266L,2338L,2383L,2412L,2421L,2626L,2662L,2833L,3139L,3193L,3238L,3283L,3319L,3328L,3355L,3382L,3391L,3535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070713Inst : IEnumerable<long>
{
public static readonly long[] Value=A070713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070713.Bytes);
public long this[int i]=>Value[i];

public static A070713Inst Instance=new A070713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070714
{
public static readonly long[] Value={ 0L,1L,29L,9L,16L,14L,30L,28L,2L,15L,10L,11L,12L,7L,20L,27L,25L,8L,6L,13L,26L,21L,22L,23L,18L,31L,5L,3L,19L,17L,24L,4L,32L,0L,1L,29L,9L,16L,14L,30L,28L,2L,15L,10L,11L,12L,7L,20L,27L,25L,8L,6L,13L,26L,21L,22L,23L,18L,31L,5L,3L,19L,17L,24L,4L,32L,0L,1L,29L,9L,16L,14L,30L,28L,2L,15L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070714Inst : IEnumerable<long>
{
public static readonly long[] Value=A070714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070714.Bytes);
public long this[int i]=>Value[i];

public static A070714Inst Instance=new A070714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070715
{
public static readonly long[] Value={ 0L,1L,26L,11L,30L,27L,14L,29L,32L,19L,22L,3L,24L,21L,6L,25L,16L,17L,18L,9L,28L,13L,10L,31L,12L,15L,2L,5L,20L,7L,4L,23L,8L,33L,0L,1L,26L,11L,30L,27L,14L,29L,32L,19L,22L,3L,24L,21L,6L,25L,16L,17L,18L,9L,28L,13L,10L,31L,12L,15L,2L,5L,20L,7L,4L,23L,8L,33L,0L,1L,26L,11L,30L,27L,14L,29L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070715Inst : IEnumerable<long>
{
public static readonly long[] Value=A070715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070715.Bytes);
public long this[int i]=>Value[i];

public static A070715Inst Instance=new A070715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070716
{
public static readonly long[] Value={ 0L,1L,23L,17L,4L,5L,6L,28L,22L,9L,10L,11L,33L,27L,14L,15L,16L,3L,32L,19L,20L,21L,8L,2L,24L,25L,26L,13L,7L,29L,30L,31L,18L,12L,34L,0L,1L,23L,17L,4L,5L,6L,28L,22L,9L,10L,11L,33L,27L,14L,15L,16L,3L,32L,19L,20L,21L,8L,2L,24L,25L,26L,13L,7L,29L,30L,31L,18L,12L,34L,0L,1L,23L,17L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070716Inst : IEnumerable<long>
{
public static readonly long[] Value=A070716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070716.Bytes);
public long this[int i]=>Value[i];

public static A070716Inst Instance=new A070716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070717
{
public static readonly long[] Value={ 0L,1L,20L,27L,4L,5L,0L,7L,8L,9L,28L,11L,0L,13L,32L,27L,16L,17L,0L,19L,20L,9L,4L,23L,0L,25L,8L,27L,28L,29L,0L,31L,32L,9L,16L,35L,0L,1L,20L,27L,4L,5L,0L,7L,8L,9L,28L,11L,0L,13L,32L,27L,16L,17L,0L,19L,20L,9L,4L,23L,0L,25L,8L,27L,28L,29L,0L,31L,32L,9L,16L,35L,0L,1L,20L,27L,4L,5L,0L,7L,8L,9L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070717Inst : IEnumerable<long>
{
public static readonly long[] Value=A070717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070717.Bytes);
public long this[int i]=>Value[i];

public static A070717Inst Instance=new A070717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070718
{
public static readonly long[] Value={ 0L,1L,17L,4L,30L,18L,31L,34L,29L,16L,10L,11L,9L,32L,23L,35L,12L,15L,13L,24L,22L,25L,2L,14L,5L,28L,26L,27L,21L,8L,3L,6L,19L,7L,33L,20L,36L,0L,1L,17L,4L,30L,18L,31L,34L,29L,16L,10L,11L,9L,32L,23L,35L,12L,15L,13L,24L,22L,25L,2L,14L,5L,28L,26L,27L,21L,8L,3L,6L,19L,7L,33L,20L,36L,0L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070718Inst : IEnumerable<long>
{
public static readonly long[] Value=A070718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070718.Bytes);
public long this[int i]=>Value[i];

public static A070718Inst Instance=new A070718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070719
{
public static readonly long[] Value={ 0L,1L,14L,21L,6L,35L,28L,7L,8L,23L,34L,11L,12L,29L,22L,13L,36L,5L,18L,19L,20L,33L,2L,25L,16L,9L,26L,27L,4L,15L,30L,31L,10L,3L,32L,17L,24L,37L,0L,1L,14L,21L,6L,35L,28L,7L,8L,23L,34L,11L,12L,29L,22L,13L,36L,5L,18L,19L,20L,33L,2L,25L,16L,9L,26L,27L,4L,15L,30L,31L,10L,3L,32L,17L,24L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070719Inst : IEnumerable<long>
{
public static readonly long[] Value=A070719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070719.Bytes);
public long this[int i]=>Value[i];

public static A070719Inst Instance=new A070719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070720
{
public static readonly long[] Value={ 0L,1L,11L,3L,4L,8L,33L,19L,5L,9L,10L,2L,12L,13L,14L,24L,16L,17L,21L,7L,32L,18L,22L,23L,15L,25L,26L,27L,37L,29L,30L,34L,20L,6L,31L,35L,36L,28L,38L,0L,1L,11L,3L,4L,8L,33L,19L,5L,9L,10L,2L,12L,13L,14L,24L,16L,17L,21L,7L,32L,18L,22L,23L,15L,25L,26L,27L,37L,29L,30L,34L,20L,6L,31L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070720Inst : IEnumerable<long>
{
public static readonly long[] Value=A070720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070720.Bytes);
public long this[int i]=>Value[i];

public static A070720Inst Instance=new A070720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070721
{
public static readonly long[] Value={ 0L,1L,8L,27L,24L,5L,16L,23L,32L,9L,0L,11L,8L,37L,24L,15L,16L,33L,32L,19L,0L,21L,8L,7L,24L,25L,16L,3L,32L,29L,0L,31L,8L,17L,24L,35L,16L,13L,32L,39L,0L,1L,8L,27L,24L,5L,16L,23L,32L,9L,0L,11L,8L,37L,24L,15L,16L,33L,32L,19L,0L,21L,8L,7L,24L,25L,16L,3L,32L,29L,0L,31L,8L,17L,24L,35L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070721Inst : IEnumerable<long>
{
public static readonly long[] Value=A070721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070721.Bytes);
public long this[int i]=>Value[i];

public static A070721Inst Instance=new A070721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070722
{
public static readonly long[] Value={ 0L,1L,5L,14L,25L,20L,29L,17L,2L,32L,18L,35L,22L,26L,3L,34L,10L,13L,37L,30L,8L,33L,11L,4L,28L,31L,7L,38L,15L,19L,6L,23L,9L,39L,24L,12L,21L,16L,27L,36L,40L,0L,1L,5L,14L,25L,20L,29L,17L,2L,32L,18L,35L,22L,26L,3L,34L,10L,13L,37L,30L,8L,33L,11L,4L,28L,31L,7L,38L,15L,19L,6L,23L,9L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070722Inst : IEnumerable<long>
{
public static readonly long[] Value=A070722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070722.Bytes);
public long this[int i]=>Value[i];

public static A070722Inst Instance=new A070722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070723
{
public static readonly long[] Value={ 0L,1L,42L,37L,1L,37L,6L,7L,42L,36L,6L,1L,37L,36L,36L,36L,1L,36L,7L,37L,37L,1L,42L,6L,6L,36L,7L,42L,7L,7L,7L,6L,42L,37L,7L,1L,36L,37L,6L,42L,6L,1L,42L,0L,1L,42L,37L,1L,37L,6L,7L,42L,36L,6L,1L,37L,36L,36L,36L,1L,36L,7L,37L,37L,1L,42L,6L,6L,36L,7L,42L,7L,7L,7L,6L,42L,37L,7L,1L,36L,37L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070723Inst : IEnumerable<long>
{
public static readonly long[] Value=A070723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070723.Bytes);
public long this[int i]=>Value[i];

public static A070723Inst Instance=new A070723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070932
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,27L,28L,30L,31L,32L,36L,40L,42L,44L,45L,46L,48L,49L,52L,54L,56L,58L,60L,62L,63L,64L,66L,70L,72L,78L,80L,81L,82L,84L,88L,90L,92L,93L,96L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070932Inst : IEnumerable<long>
{
public static readonly long[] Value=A070932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070932.Bytes);
public long this[int i]=>Value[i];

public static A070932Inst Instance=new A070932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070933
{
public static readonly long[] Value={ 1L,2L,6L,14L,34L,74L,166L,350L,746L,1546L,3206L,6550L,13386L,27114L,54894L,110630L,222794L,447538L,898574L,1801590L,3610930L,7231858L,14480654L,28983246L,58003250L,116054034L,232186518L,464475166L,929116402L,1858449178L,3717247638L,7434950062L,14870628026L,29742206138L,59485920374L,118973809798L,237950730522L,475905520474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070933Inst : IEnumerable<long>
{
public static readonly long[] Value=A070933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070933.Bytes);
public long this[int i]=>Value[i];

public static A070933Inst Instance=new A070933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070934
{
public static readonly long[] Value={ 2L,23L,53L,197L,127L,233L,691L,379L,499L,857L,953L,1151L,1259L,1583L,2099L,2399L,2417L,2579L,2909L,3803L,3821L,4217L,4651L,5107L,5813L,6829L,6079L,6599L,14153L,10091L,8273L,10163L,9521L,12281L,13043L,11597L,12713L,13099L,16763L,15527L,16823L,22741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070934Inst : IEnumerable<long>
{
public static readonly long[] Value=A070934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070934.Bytes);
public long this[int i]=>Value[i];

public static A070934Inst Instance=new A070934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070935
{
public static readonly long[] Value={ 2L,3L,8L,5L,18L,7L,32L,27L,50L,11L,72L,13L,98L,75L,128L,17L,162L,19L,200L,147L,242L,23L,288L,125L,338L,243L,392L,29L,450L,31L,512L,363L,578L,245L,648L,37L,722L,507L,800L,41L,882L,43L,968L,675L,1058L,47L,1152L,343L,1250L,867L,1352L,53L,1458L,605L,1568L,1083L,1682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070935Inst : IEnumerable<long>
{
public static readonly long[] Value=A070935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070935.Bytes);
public long this[int i]=>Value[i];

public static A070935Inst Instance=new A070935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070936
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,2L,0L,0L,0L,1L,1L,1L,2L,1L,0L,0L,0L,1L,1L,1L,2L,2L,1L,0L,0L,0L,1L,1L,1L,2L,2L,2L,1L,0L,0L,0L,1L,1L,1L,2L,2L,3L,2L,0L,0L,0L,0L,1L,1L,1L,2L,2L,3L,3L,2L,0L,0L,0L,0L,1L,1L,1L,2L,2L,3L,4L,3L,1L,0L,0L,0L,0L,1L,1L,1L,2L,2L,3L,4L,4L,3L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070936Inst : IEnumerable<long>
{
public static readonly long[] Value=A070936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070936.Bytes);
public long this[int i]=>Value[i];

public static A070936Inst Instance=new A070936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070937
{
public static readonly long[] Value={ 1L,2L,4L,1L,5L,6L,4L,5L,1L,4L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070937Inst : IEnumerable<long>
{
public static readonly long[] Value=A070937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070937.Bytes);
public long this[int i]=>Value[i];

public static A070937Inst Instance=new A070937Inst();

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