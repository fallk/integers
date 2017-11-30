using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A085962
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,2L,3L,3L,2L,5L,2L,3L,2L,2L,3L,5L,3L,7L,2L,5L,2L,2L,3L,3L,2L,5L,2L,3L,5L,7L,3L,7L,2L,5L,11L,2L,2L,3L,2L,3L,3L,2L,5L,5L,2L,7L,3L,5L,7L,3L,7L,11L,2L,5L,13L,11L,2L,2L,2L,3L,3L,2L,3L,5L,3L,2L,5L,7L,5L,2L,7L,3L,5L,7L,11L,3L,7L,11L,2L,13L,5L,13L,11L,17L,2L,2L,2L,3L,2L,3L,3L,2L,5L,3L,5L,3L,2L,5L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085962Inst : IEnumerable<long>
{
public static readonly long[] Value=A085962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085962.Bytes);
public long this[int i]=>Value[i];

public static A085962Inst Instance=new A085962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085963
{
public static readonly long[] Value={ 3L,5L,5L,3L,7L,5L,7L,5L,3L,7L,11L,11L,7L,5L,7L,11L,5L,11L,3L,7L,13L,11L,13L,11L,7L,13L,5L,7L,11L,13L,5L,11L,3L,7L,13L,17L,13L,17L,11L,13L,11L,7L,17L,13L,5L,17L,7L,11L,13L,5L,11L,17L,3L,7L,17L,13L,19L,17L,13L,19L,17L,11L,13L,19L,11L,7L,17L,19L,13L,5L,17L,7L,11L,13L,19L,5L,11L,17L,3L,19L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085963Inst : IEnumerable<long>
{
public static readonly long[] Value=A085963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085963.Bytes);
public long this[int i]=>Value[i];

public static A085963Inst Instance=new A085963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085964
{
public static readonly long[] Value={ 0L,7L,6L,9L,9L,3L,1L,3L,9L,7L,6L,4L,2L,4L,6L,8L,4L,4L,9L,4L,2L,6L,1L,9L,2L,9L,5L,9L,3L,3L,1L,5L,7L,8L,7L,0L,1L,6L,2L,0L,4L,1L,0L,5L,9L,7L,1L,4L,8L,4L,3L,1L,9L,0L,2L,6L,4L,9L,3L,8L,0L,0L,8L,8L,5L,9L,2L,1L,6L,5L,7L,0L,4L,8L,7L,5L,6L,4L,2L,0L,6L,5L,1L,0L,3L,3L,3L,1L,0L,6L,7L,8L,5L,3L,9L,6L,2L,8L,9L,5L,4L,2L,0L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085964Inst : IEnumerable<long>
{
public static readonly long[] Value=A085964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085964.Bytes);
public long this[int i]=>Value[i];

public static A085964Inst Instance=new A085964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085965
{
public static readonly long[] Value={ 0L,3L,5L,7L,5L,5L,0L,1L,7L,4L,8L,3L,9L,2L,4L,2L,5L,7L,1L,3L,2L,8L,1L,8L,2L,4L,2L,5L,3L,8L,8L,5L,5L,7L,1L,1L,1L,3L,1L,6L,9L,7L,2L,7L,6L,7L,2L,6L,6L,5L,1L,3L,3L,1L,6L,9L,0L,0L,9L,2L,6L,7L,4L,8L,2L,3L,9L,7L,5L,8L,3L,4L,2L,7L,4L,7L,2L,7L,9L,3L,1L,3L,6L,6L,0L,7L,2L,8L,0L,6L,4L,7L,0L,3L,7L,6L,7L,9L,5L,0L,8L,9L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085965Inst : IEnumerable<long>
{
public static readonly long[] Value=A085965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085965.Bytes);
public long this[int i]=>Value[i];

public static A085965Inst Instance=new A085965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085966
{
public static readonly long[] Value={ 0L,1L,7L,0L,7L,0L,0L,8L,6L,8L,5L,0L,6L,3L,6L,5L,1L,2L,9L,5L,4L,1L,3L,3L,6L,7L,3L,2L,6L,6L,0L,5L,9L,3L,9L,9L,2L,0L,9L,5L,8L,5L,9L,4L,1L,8L,7L,4L,5L,4L,4L,2L,4L,4L,7L,3L,3L,1L,6L,3L,3L,6L,8L,8L,3L,6L,9L,6L,9L,7L,3L,6L,7L,4L,7L,1L,7L,2L,4L,3L,6L,6L,7L,1L,8L,6L,0L,3L,5L,0L,0L,7L,8L,1L,8L,0L,6L,2L,3L,0L,2L,8L,8L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085966Inst : IEnumerable<long>
{
public static readonly long[] Value=A085966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085966.Bytes);
public long this[int i]=>Value[i];

public static A085966Inst Instance=new A085966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085967
{
public static readonly long[] Value={ 0L,0L,8L,2L,8L,3L,8L,3L,2L,8L,5L,6L,1L,3L,3L,5L,9L,2L,5L,3L,5L,1L,2L,4L,1L,3L,8L,7L,2L,9L,4L,4L,8L,7L,2L,3L,0L,8L,9L,1L,8L,3L,3L,2L,8L,8L,8L,5L,3L,0L,7L,8L,0L,6L,2L,4L,4L,6L,4L,1L,9L,2L,1L,6L,3L,8L,6L,5L,5L,4L,8L,9L,4L,1L,1L,0L,0L,7L,8L,5L,8L,1L,8L,4L,3L,1L,6L,6L,1L,3L,4L,1L,8L,1L,9L,1L,8L,2L,0L,0L,4L,3L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085967Inst : IEnumerable<long>
{
public static readonly long[] Value=A085967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085967.Bytes);
public long this[int i]=>Value[i];

public static A085967Inst Instance=new A085967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085968
{
public static readonly long[] Value={ 0L,0L,4L,0L,6L,1L,4L,0L,5L,3L,6L,6L,5L,1L,7L,8L,3L,0L,5L,6L,0L,5L,2L,3L,4L,3L,9L,1L,4L,2L,6L,8L,3L,0L,8L,0L,5L,2L,2L,9L,7L,7L,1L,4L,4L,5L,1L,2L,0L,7L,1L,7L,4L,1L,0L,0L,1L,0L,3L,2L,6L,8L,8L,6L,8L,1L,7L,2L,8L,6L,3L,0L,4L,0L,7L,0L,7L,8L,8L,0L,4L,4L,0L,6L,0L,9L,2L,2L,8L,2L,8L,0L,5L,3L,0L,4L,3L,1L,3L,4L,4L,2L,6L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085968Inst : IEnumerable<long>
{
public static readonly long[] Value=A085968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085968.Bytes);
public long this[int i]=>Value[i];

public static A085968Inst Instance=new A085968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085969
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,4L,4L,6L,7L,5L,7L,4L,9L,6L,2L,4L,5L,0L,6L,6L,3L,0L,7L,3L,5L,8L,5L,1L,4L,0L,7L,8L,3L,1L,1L,7L,5L,3L,6L,8L,2L,2L,9L,2L,0L,3L,4L,9L,7L,3L,8L,5L,7L,8L,5L,5L,0L,2L,7L,5L,5L,9L,1L,7L,3L,9L,7L,9L,3L,7L,2L,6L,2L,5L,1L,5L,1L,9L,9L,7L,7L,1L,9L,0L,8L,1L,3L,5L,5L,3L,4L,3L,4L,0L,1L,2L,4L,4L,1L,7L,7L,2L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085969Inst : IEnumerable<long>
{
public static readonly long[] Value=A085969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085969.Bytes);
public long this[int i]=>Value[i];

public static A085969Inst Instance=new A085969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085970
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,3L,3L,4L,5L,5L,5L,6L,6L,7L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,13L,14L,15L,16L,17L,17L,18L,19L,20L,20L,21L,21L,22L,23L,24L,24L,25L,25L,26L,27L,28L,28L,29L,30L,31L,32L,33L,33L,34L,34L,35L,36L,36L,37L,38L,38L,39L,40L,41L,41L,42L,42L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085970Inst : IEnumerable<long>
{
public static readonly long[] Value=A085970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085970.Bytes);
public long this[int i]=>Value[i];

public static A085970Inst Instance=new A085970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085971
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085971Inst : IEnumerable<long>
{
public static readonly long[] Value=A085971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085971.Bytes);
public long this[int i]=>Value[i];

public static A085971Inst Instance=new A085971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086036
{
public static readonly long[] Value={ 0L,0L,0L,0L,6L,4L,2L,5L,0L,9L,6L,3L,6L,6L,4L,7L,7L,3L,7L,9L,1L,1L,0L,1L,8L,1L,9L,1L,3L,8L,0L,4L,3L,5L,7L,6L,5L,9L,8L,9L,8L,4L,5L,4L,5L,5L,4L,6L,9L,7L,8L,8L,1L,5L,0L,5L,2L,8L,9L,8L,5L,6L,6L,2L,5L,8L,4L,3L,8L,9L,8L,4L,5L,2L,0L,0L,9L,7L,7L,4L,5L,3L,2L,3L,9L,4L,4L,7L,4L,5L,8L,2L,6L,4L,7L,0L,4L,5L,7L,0L,1L,1L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086036Inst : IEnumerable<long>
{
public static readonly long[] Value=A086036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086036.Bytes);
public long this[int i]=>Value[i];

public static A086036Inst Instance=new A086036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086037
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,8L,1L,8L,4L,4L,8L,5L,9L,9L,7L,9L,5L,2L,6L,8L,2L,5L,1L,0L,2L,6L,5L,8L,2L,1L,6L,6L,5L,0L,7L,9L,3L,5L,8L,2L,0L,6L,0L,6L,7L,4L,9L,5L,6L,3L,3L,4L,4L,7L,9L,4L,3L,6L,2L,6L,5L,6L,9L,1L,4L,6L,8L,2L,1L,9L,4L,3L,9L,9L,4L,9L,5L,0L,8L,5L,2L,8L,5L,3L,2L,3L,8L,9L,5L,3L,4L,0L,5L,4L,6L,4L,2L,7L,4L,5L,3L,9L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086037Inst : IEnumerable<long>
{
public static readonly long[] Value=A086037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086037.Bytes);
public long this[int i]=>Value[i];

public static A086037Inst Instance=new A086037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086038
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,5L,6L,1L,3L,7L,1L,6L,8L,0L,3L,9L,6L,4L,6L,9L,8L,0L,8L,2L,4L,8L,4L,3L,2L,3L,1L,2L,4L,7L,3L,9L,3L,6L,4L,4L,7L,2L,6L,0L,6L,0L,1L,8L,0L,7L,2L,9L,8L,8L,7L,0L,6L,6L,6L,7L,5L,4L,5L,9L,9L,1L,7L,4L,7L,4L,1L,2L,1L,1L,1L,8L,8L,8L,4L,8L,9L,3L,8L,8L,9L,7L,9L,8L,9L,1L,4L,8L,1L,7L,8L,0L,3L,0L,3L,0L,1L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086038Inst : IEnumerable<long>
{
public static readonly long[] Value=A086038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086038.Bytes);
public long this[int i]=>Value[i];

public static A086038Inst Instance=new A086038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086039
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,5L,1L,2L,1L,0L,2L,8L,1L,2L,2L,5L,2L,7L,7L,3L,8L,3L,8L,3L,2L,5L,9L,8L,9L,8L,5L,9L,7L,0L,6L,3L,4L,7L,2L,0L,0L,5L,3L,9L,6L,5L,9L,8L,5L,6L,9L,3L,9L,1L,5L,0L,4L,8L,0L,3L,7L,5L,7L,1L,4L,1L,8L,0L,6L,9L,7L,3L,3L,0L,0L,2L,2L,5L,9L,8L,4L,5L,2L,9L,6L,7L,4L,2L,5L,7L,7L,9L,2L,2L,0L,0L,1L,2L,6L,5L,9L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086039Inst : IEnumerable<long>
{
public static readonly long[] Value=A086039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086039.Bytes);
public long this[int i]=>Value[i];

public static A086039Inst Instance=new A086039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086040
{
public static readonly long[] Value={ 7L,47L,53L,67L,97L,101L,149L,401L,431L,479L,487L,757L,827L,887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086040Inst : IEnumerable<long>
{
public static readonly long[] Value=A086040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086040.Bytes);
public long this[int i]=>Value[i];

public static A086040Inst Instance=new A086040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086041
{
public static readonly long[] Value={ 711131719L,4753596167L,5359616771L,6771737983L,97101103107109L,101103107109113L,149151157163167L,401409419421431L,431433439443449L,479487491499503L,487491499503509L,757761769773787L,827829839853857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086041Inst : IEnumerable<long>
{
public static readonly long[] Value=A086041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086041.Bytes);
public long this[int i]=>Value[i];

public static A086041Inst Instance=new A086041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086042
{
public static readonly long[] Value={ 31L,71L,73L,97L,101L,103L,107L,109L,131L,173L,193L,197L,271L,293L,307L,311L,317L,373L,397L,419L,439L,491L,509L,547L,571L,593L,607L,617L,647L,659L,673L,701L,709L,719L,727L,733L,739L,743L,751L,757L,761L,809L,839L,907L,919L,937L,941L,947L,953L,971L,983L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086042Inst : IEnumerable<long>
{
public static readonly long[] Value=A086042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086042.Bytes);
public long this[int i]=>Value[i];

public static A086042Inst Instance=new A086042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086043
{
public static readonly BigInteger[] Value={ 3L,35L,357L,35711L,3571113L,357111317L,35711131719L,3571113171929L,357111317192931L,35711131719293141L,3571113171929314143L,BigInteger.Parse("357111317192931414359"),BigInteger.Parse("35711131719293141435961"),BigInteger.Parse("3571113171929314143596171"),BigInteger.Parse("357111317192931414359617173"),BigInteger.Parse("357111317192931414359617173101") };
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
public class A086043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086043.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086043Inst Instance=new A086043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086044
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,2L,17L,19L,21L,23L,25L,27L,29L,31L,16L,35L,3L,39L,41L,43L,45L,47L,49L,51L,18L,38L,57L,4L,61L,63L,65L,67L,69L,71L,20L,40L,60L,79L,5L,83L,85L,87L,89L,91L,22L,42L,62L,82L,101L,6L,105L,107L,109L,111L,24L,44L,64L,84L,104L,123L,7L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086044Inst : IEnumerable<long>
{
public static readonly long[] Value=A086044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086044.Bytes);
public long this[int i]=>Value[i];

public static A086044Inst Instance=new A086044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086045
{
public static readonly long[] Value={ 12L,11L,16L,18L,20L,22L,24L,26L,28L,30L,191L,14L,15L,54L,74L,94L,114L,134L,154L,174L,252L,33L,36L,37L,76L,96L,116L,136L,156L,176L,282L,53L,55L,58L,59L,98L,118L,138L,158L,178L,312L,73L,75L,77L,80L,81L,120L,140L,160L,180L,342L,93L,95L,97L,99L,102L,103L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086045Inst : IEnumerable<long>
{
public static readonly long[] Value=A086045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086045.Bytes);
public long this[int i]=>Value[i];

public static A086045Inst Instance=new A086045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086046
{
public static readonly long[] Value={ 16L,40L,76L,116L,170L,226L,286L,367L,451L,539L,629L,729L,833L,959L,1091L,1226L,1362L,1502L,1652L,1804L,1960L,2144L,2333L,2529L,2727L,2931L,3141L,3361L,3586L,3814L,4046L,4280L,4528L,4778L,5038L,5314L,5608L,5904L,6201L,6507L,6815L,7130L,7458L,7788L,8128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086046Inst : IEnumerable<long>
{
public static readonly long[] Value=A086046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086046.Bytes);
public long this[int i]=>Value[i];

public static A086046Inst Instance=new A086046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086047
{
public static readonly long[] Value={ 32L,80L,152L,232L,340L,452L,572L,734L,902L,1078L,1258L,1458L,1666L,1909L,2161L,2425L,2695L,2967L,3247L,3547L,3851L,4163L,4531L,4909L,5301L,5697L,6102L,6510L,6930L,7370L,7820L,8276L,8740L,9208L,9704L,10204L,10724L,11276L,11843L,12431L,13023L,13617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086047Inst : IEnumerable<long>
{
public static readonly long[] Value=A086047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086047.Bytes);
public long this[int i]=>Value[i];

public static A086047Inst Instance=new A086047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086048
{
public static readonly long[] Value={ 1L,6L,2L,3L,22L,4L,32L,5L,42L,13L,48L,6L,63L,8L,23L,78L,33L,10L,96L,12L,590L,111L,114L,2L,129L,132L,138L,64L,150L,16L,159L,9L,15L,124L,25L,3L,189L,20L,43L,73L,207L,22L,216L,24L,228L,234L,237L,26L,249L,76L,258L,79L,264L,28L,270L,276L,279L,4L,291L,30L,300L,32L,830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086048Inst : IEnumerable<long>
{
public static readonly long[] Value=A086048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086048.Bytes);
public long this[int i]=>Value[i];

public static A086048Inst Instance=new A086048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086049
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,10L,12L,2L,16L,9L,20L,22L,24L,26L,28L,30L,32L,34L,5L,38L,40L,42L,44L,46L,48L,51L,54L,57L,7L,63L,8L,19L,72L,75L,78L,81L,84L,33L,37L,93L,96L,99L,102L,105L,108L,111L,114L,117L,120L,123L,126L,129L,132L,135L,138L,141L,64L,147L,150L,153L,16L,159L,67L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086049Inst : IEnumerable<long>
{
public static readonly long[] Value=A086049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086049.Bytes);
public long this[int i]=>Value[i];

public static A086049Inst Instance=new A086049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086050
{
public static readonly long[] Value={ 14L,9L,28L,11L,7L,19L,37L,99L,14L,121L,18L,39L,130L,219L,178L,184L,187L,238L,88L,11L,91L,94L,154L,202L,106L,481L,493L,2534L,529L,60L,146L,61L,69L,689L,254L,562L,287L,570L,87L,90L,1110L,578L,440L,586L,355L,442L,491L,602L,1153L,606L,1181L,1134L,1233L,1142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086050Inst : IEnumerable<long>
{
public static readonly long[] Value=A086050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086050.Bytes);
public long this[int i]=>Value[i];

public static A086050Inst Instance=new A086050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086051
{
public static readonly long[] Value={ 31L,71L,73L,97L,131L,173L,193L,197L,271L,293L,311L,317L,373L,397L,419L,439L,491L,547L,571L,593L,617L,647L,659L,673L,719L,727L,733L,739L,743L,751L,757L,761L,839L,919L,937L,941L,947L,953L,971L,983L,991L,1171L,1213L,1231L,1291L,1297L,1321L,1327L,1429L,1549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086051Inst : IEnumerable<long>
{
public static readonly long[] Value=A086051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086051.Bytes);
public long this[int i]=>Value[i];

public static A086051Inst Instance=new A086051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086084
{
public static readonly long[] Value={ 1L,10L,11L,101L,111L,1011L,1101L,1111L,10111L,11011L,11101L,11111L,101111L,110111L,111011L,111101L,111111L,1011111L,1101111L,1110111L,1111011L,1111101L,1111111L,10111111L,11011111L,11101111L,11110111L,11111011L,11111101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086084Inst : IEnumerable<long>
{
public static readonly long[] Value=A086084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086084.Bytes);
public long this[int i]=>Value[i];

public static A086084Inst Instance=new A086084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086085
{
public static readonly long[] Value={ 2L,5L,19L,37L,41L,47L,71L,103L,151L,167L,197L,277L,331L,349L,401L,419L,487L,499L,577L,593L,607L,617L,619L,683L,701L,811L,829L,907L,911L,937L,941L,947L,953L,1031L,1061L,1451L,1493L,1511L,1627L,1657L,1669L,1789L,1831L,1847L,1949L,1973L,2161L,2309L,2333L,2341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086085Inst : IEnumerable<long>
{
public static readonly long[] Value=A086085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086085.Bytes);
public long this[int i]=>Value[i];

public static A086085Inst Instance=new A086085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086086
{
public static readonly long[] Value={ 3L,5L,7L,17L,23L,37L,43L,47L,67L,79L,107L,113L,149L,151L,163L,211L,257L,331L,349L,409L,421L,439L,509L,521L,587L,593L,601L,617L,709L,727L,797L,839L,907L,911L,937L,941L,1051L,1063L,1163L,1187L,1319L,1327L,1447L,1471L,1489L,1607L,1619L,1637L,1667L,1783L,1789L,1801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086086Inst : IEnumerable<long>
{
public static readonly long[] Value=A086086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086086.Bytes);
public long this[int i]=>Value[i];

public static A086086Inst Instance=new A086086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086087
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,4L,4L,5L,4L,3L,6L,6L,4L,16L,4L,18L,4L,8L,5L,11L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086087Inst : IEnumerable<long>
{
public static readonly long[] Value=A086087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086087.Bytes);
public long this[int i]=>Value[i];

public static A086087Inst Instance=new A086087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086088
{
public static readonly long[] Value={ 1L,9L,2L,7L,5L,6L,1L,9L,7L,5L,4L,8L,2L,9L,2L,5L,3L,0L,4L,2L,6L,1L,9L,0L,5L,8L,6L,1L,7L,3L,6L,6L,2L,2L,1L,6L,8L,6L,9L,8L,5L,5L,4L,2L,5L,5L,1L,6L,3L,3L,8L,4L,7L,2L,7L,1L,4L,6L,6L,4L,7L,0L,3L,8L,0L,0L,9L,6L,6L,6L,0L,6L,2L,2L,9L,7L,8L,1L,5L,5L,5L,9L,1L,4L,9L,8L,1L,8L,2L,5L,3L,4L,6L,1L,8L,9L,0L,6L,5L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086088Inst : IEnumerable<long>
{
public static readonly long[] Value=A086088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086088.Bytes);
public long this[int i]=>Value[i];

public static A086088Inst Instance=new A086088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086089
{
public static readonly long[] Value={ 8L,2L,6L,9L,9L,3L,3L,4L,3L,1L,3L,2L,6L,8L,8L,0L,7L,4L,2L,6L,6L,9L,8L,9L,7L,4L,7L,4L,6L,9L,4L,5L,4L,1L,6L,2L,0L,9L,6L,0L,7L,9L,7L,2L,0L,5L,4L,9L,9L,6L,0L,9L,7L,9L,1L,9L,9L,0L,4L,9L,0L,3L,0L,4L,3L,6L,5L,4L,5L,4L,5L,5L,2L,0L,3L,9L,0L,4L,6L,9L,2L,2L,6L,0L,5L,7L,0L,0L,4L,3L,2L,3L,4L,7L,5L,6L,3L,3L,3L,8L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086089Inst : IEnumerable<long>
{
public static readonly long[] Value=A086089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086089.Bytes);
public long this[int i]=>Value[i];

public static A086089Inst Instance=new A086089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086090
{
public static readonly long[] Value={ 1L,5L,22L,89L,340L,1247L,4438L,15437L,52744L,177659L,591514L,1950665L,6381388L,20734391L,66977950L,215266373L,688813072L,2195513843L,6973830946L,22083492161L,69736736596L,219669514415L,690387505702L,2165301501629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086090Inst : IEnumerable<long>
{
public static readonly long[] Value=A086090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086090.Bytes);
public long this[int i]=>Value[i];

public static A086090Inst Instance=new A086090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086091
{
public static readonly long[] Value={ 1L,6L,33L,171L,849L,4083L,19161L,88203L,399777L,1789155L,7923369L,34780155L,151526385L,655905747L,2823355257L,12093944427L,51582654273L,219172472259L,928100356425L,3918172435419L,16496161201041L,69279692903091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086091Inst : IEnumerable<long>
{
public static readonly long[] Value=A086091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086091.Bytes);
public long this[int i]=>Value[i];

public static A086091Inst Instance=new A086091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086092
{
public static readonly long[] Value={ 1L,7L,46L,289L,1756L,10399L,60346L,344509L,1940536L,10809019L,59642326L,326459929L,1774589716L,9588593239L,51537966706L,275731944949L,1469138717296L,7799162291059L,41267449945486L,217712622047569L,1145508691315276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086092Inst : IEnumerable<long>
{
public static readonly long[] Value=A086092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086092.Bytes);
public long this[int i]=>Value[i];

public static A086092Inst Instance=new A086092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086093
{
public static readonly long[] Value={ 1L,5L,25L,123L,593L,2803L,13017L,59531L,268705L,1199331L,5301929L,23245819L,101194737L,437801939L,1883831161L,8067412587L,34402785089L,146158028227L,618862711113L,2612502377435L,10998603062161L,46189948719795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086093Inst : IEnumerable<long>
{
public static readonly long[] Value=A086093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086093.Bytes);
public long this[int i]=>Value[i];

public static A086093Inst Instance=new A086093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086094
{
public static readonly BigInteger[] Value={ 0L,1L,4L,49L,594L,9088L,192550L,4400305L,123753812L,3913346101L,143259991494L,5423531436645L,254447352721880L,12256517669340701L,645137240849841756L,BigInteger.Parse("37228477466802215873"),BigInteger.Parse("2388339009798778979334"),BigInteger.Parse("155663410717277848640228") };
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
public class A086094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086094Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086094.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086094.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086094Inst Instance=new A086094Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086095
{
public static readonly long[] Value={ 0L,1L,-2L,1L,0L,4L,16L,16L,-64L,1184L,-4176L,11588L,-45320L,60177L,-107154L,596001L,-2059576L,9159736L,8005616L,313722880L,1052525600L,9682854977L,55241475020L,489566327904L,4159594989264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086095Inst : IEnumerable<long>
{
public static readonly long[] Value=A086095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086095.Bytes);
public long this[int i]=>Value[i];

public static A086095Inst Instance=new A086095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086096
{
public static readonly long[] Value={ 15L,39L,46L,51L,57L,58L,77L,85L,86L,95L,106L,111L,119L,123L,141L,142L,159L,166L,169L,177L,178L,183L,187L,201L,202L,209L,215L,219L,221L,226L,235L,237L,249L,267L,278L,287L,291L,298L,303L,305L,323L,326L,329L,335L,365L,371L,377L,393L,394L,407L,411L,413L,417L,427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086096Inst : IEnumerable<long>
{
public static readonly long[] Value=A086096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086096.Bytes);
public long this[int i]=>Value[i];

public static A086096Inst Instance=new A086096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086097
{
public static readonly long[] Value={ 57L,85L,141L,177L,201L,393L,537L,553L,633L,697L,717L,745L,921L,933L,1141L,1285L,1345L,1477L,1641L,1713L,1761L,1981L,1982L,2041L,2181L,2361L,2433L,2558L,2577L,2605L,2761L,2941L,2977L,3062L,3117L,3241L,3273L,3326L,3397L,3578L,3721L,3777L,3901L,3902L,3957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086097Inst : IEnumerable<long>
{
public static readonly long[] Value=A086097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086097.Bytes);
public long this[int i]=>Value[i];

public static A086097Inst Instance=new A086097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086098
{
public static readonly long[] Value={ 1L,21L,1141L,208965L,139889701L,354550756581L,3464730268306021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086098Inst : IEnumerable<long>
{
public static readonly long[] Value=A086098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086098.Bytes);
public long this[int i]=>Value[i];

public static A086098Inst Instance=new A086098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086099
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,2L,3L,0L,7L,6L,7L,4L,7L,6L,7L,0L,15L,14L,15L,12L,15L,14L,15L,8L,15L,14L,15L,12L,15L,14L,15L,0L,31L,30L,31L,28L,31L,30L,31L,24L,31L,30L,31L,28L,31L,30L,31L,16L,31L,30L,31L,28L,31L,30L,31L,24L,31L,30L,31L,28L,31L,30L,31L,0L,63L,62L,63L,60L,63L,62L,63L,56L,63L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086099Inst : IEnumerable<long>
{
public static readonly long[] Value=A086099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086099.Bytes);
public long this[int i]=>Value[i];

public static A086099Inst Instance=new A086099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086132
{
public static readonly long[] Value={ 4L,9L,16L,25L,27L,49L,50L,54L,81L,108L,121L,125L,144L,169L,196L,225L,242L,256L,289L,343L,361L,392L,400L,432L,441L,500L,529L,578L,605L,625L,676L,729L,784L,841L,847L,961L,972L,1014L,1029L,1058L,1083L,1089L,1183L,1225L,1323L,1331L,1369L,1372L,1444L,1445L,1452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086132Inst : IEnumerable<long>
{
public static readonly long[] Value=A086132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086132.Bytes);
public long this[int i]=>Value[i];

public static A086132Inst Instance=new A086132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086133
{
public static readonly long[] Value={ 4L,8L,12L,16L,20L,24L,27L,28L,32L,36L,40L,44L,45L,48L,52L,56L,60L,63L,64L,68L,72L,76L,80L,84L,88L,92L,96L,99L,100L,104L,108L,112L,116L,117L,120L,124L,128L,132L,136L,140L,144L,148L,152L,153L,156L,160L,164L,168L,171L,172L,175L,176L,180L,184L,188L,192L,196L,200L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086133Inst : IEnumerable<long>
{
public static readonly long[] Value=A086133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086133.Bytes);
public long this[int i]=>Value[i];

public static A086133Inst Instance=new A086133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086134
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,5L,0L,2L,2L,7L,0L,2L,0L,3L,2L,2L,0L,3L,0L,2L,2L,13L,0L,2L,2L,3L,3L,2L,0L,31L,0L,2L,2L,19L,2L,2L,0L,3L,2L,2L,0L,41L,0L,2L,3L,5L,0L,2L,2L,3L,2L,2L,0L,3L,2L,2L,2L,31L,0L,2L,0L,3L,3L,2L,2L,61L,0L,2L,2L,59L,0L,2L,0L,3L,5L,2L,2L,71L,0L,2L,2L,43L,0L,2L,2L,3L,2L,2L,0L,3L,2L,2L,2L,7L,2L,2L,0L,7L,3L,2L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086134Inst : IEnumerable<long>
{
public static readonly long[] Value=A086134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086134.Bytes);
public long this[int i]=>Value[i];

public static A086134Inst Instance=new A086134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086135
{
public static readonly long[] Value={ 3L,7L,13L,19L,31L,37L,43L,61L,73L,79L,97L,103L,127L,157L,163L,223L,229L,271L,307L,349L,373L,379L,433L,439L,457L,499L,607L,643L,673L,733L,751L,853L,877L,937L,967L,1009L,1087L,1093L,1213L,1279L,1291L,1297L,1423L,1429L,1483L,1489L,1543L,1549L,1597L,1609L,1657L,1777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086135Inst : IEnumerable<long>
{
public static readonly long[] Value=A086135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086135.Bytes);
public long this[int i]=>Value[i];

public static A086135Inst Instance=new A086135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086136
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,29L,31L,41L,47L,59L,61L,67L,71L,89L,97L,101L,127L,137L,139L,151L,167L,179L,181L,227L,229L,239L,251L,257L,269L,271L,281L,337L,347L,367L,389L,397L,409L,419L,421L,431L,449L,479L,487L,491L,557L,587L,601L,607L,631L,641L,647L,727L,739L,757L,761L,809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086136Inst : IEnumerable<long>
{
public static readonly long[] Value=A086136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086136.Bytes);
public long this[int i]=>Value[i];

public static A086136Inst Instance=new A086136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086137
{
public static readonly long[] Value={ 2L,2L,2L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,2L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,2L,0L,0L,0L,1L,1L,1L,0L,0L,2L,0L,0L,2L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,2L,1L,1L,0L,2L,0L,1L,1L,0L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086137Inst : IEnumerable<long>
{
public static readonly long[] Value=A086137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086137.Bytes);
public long this[int i]=>Value[i];

public static A086137Inst Instance=new A086137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086138
{
public static readonly long[] Value={ 3L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,0L,1L,1L,0L,2L,1L,0L,1L,0L,2L,0L,1L,1L,1L,0L,0L,1L,1L,2L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,2L,2L,0L,1L,1L,1L,0L,0L,0L,2L,1L,0L,0L,1L,0L,1L,1L,2L,0L,2L,1L,0L,2L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,2L,0L,1L,2L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086138Inst : IEnumerable<long>
{
public static readonly long[] Value=A086138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086138.Bytes);
public long this[int i]=>Value[i];

public static A086138Inst Instance=new A086138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086139
{
public static readonly long[] Value={ 3L,3L,3L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,3L,3L,2L,1L,1L,1L,1L,1L,1L,0L,0L,2L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,0L,1L,1L,1L,0L,1L,1L,1L,2L,0L,1L,2L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,0L,1L,0L,2L,2L,2L,2L,0L,1L,2L,1L,2L,0L,1L,3L,2L,0L,0L,0L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086139Inst : IEnumerable<long>
{
public static readonly long[] Value=A086139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086139.Bytes);
public long this[int i]=>Value[i];

public static A086139Inst Instance=new A086139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086140
{
public static readonly long[] Value={ 5L,7L,11L,97L,101L,1481L,1867L,3457L,5647L,15727L,16057L,16061L,19417L,19421L,21011L,22271L,43777L,43781L,55331L,79687L,88807L,101107L,144161L,165701L,166841L,195731L,201821L,225341L,247601L,257857L,266677L,268811L,276037L,284737L,326141L,340927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086140Inst : IEnumerable<long>
{
public static readonly long[] Value=A086140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086140.Bytes);
public long this[int i]=>Value[i];

public static A086140Inst Instance=new A086140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086141
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,36L,30L,16L,24L,72L,60L,216L,180L,900L,210L,32L,48L,144L,120L,432L,360L,1800L,420L,1296L,1080L,5400L,1260L,27000L,6300L,44100L,2310L,64L,96L,288L,240L,864L,720L,3600L,840L,2592L,2160L,10800L,2520L,54000L,12600L,88200L,4620L,7776L,6480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086141Inst : IEnumerable<long>
{
public static readonly long[] Value=A086141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086141.Bytes);
public long this[int i]=>Value[i];

public static A086141Inst Instance=new A086141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086142
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,8L,9L,11L,11L,13L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,19L,20L,20L,21L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,25L,25L,26L,26L,26L,27L,27L,27L,27L,28L,28L,29L,29L,29L,29L,29L,30L,30L,30L,31L,31L,31L,31L,31L,31L,32L,32L,32L,33L,33L,33L,33L,34L,34L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086142Inst : IEnumerable<long>
{
public static readonly long[] Value=A086142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086142.Bytes);
public long this[int i]=>Value[i];

public static A086142Inst Instance=new A086142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086143
{
public static readonly BigInteger[] Value={ 4L,585L,1111L,99499L,1010101L,1001001001L,1000100010001L,1000010000100001L,1000001000001000001L,BigInteger.Parse("1000000100000010000001"),BigInteger.Parse("1000000010000000100000001"),BigInteger.Parse("1000000001000000001000000001"),BigInteger.Parse("1000000000100000000010000000001") };
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
public class A086143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086143Inst Instance=new A086143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086144
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,5L,4L,3L,2L,1L,2L,3L,4L,3L,4L,5L,6L,5L,6L,5L,4L,5L,6L,5L,4L,3L,2L,3L,2L,1L,2L,3L,2L,3L,4L,5L,6L,7L,6L,7L,6L,7L,8L,7L,6L,5L,6L,7L,6L,7L,8L,9L,10L,9L,10L,9L,8L,7L,8L,9L,8L,9L,8L,7L,6L,7L,8L,9L,8L,9L,10L,11L,10L,9L,10L,11L,10L,9L,8L,9L,10L,11L,10L,11L,10L,11L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086144Inst : IEnumerable<long>
{
public static readonly long[] Value=A086144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086144.Bytes);
public long this[int i]=>Value[i];

public static A086144Inst Instance=new A086144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086145
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,2L,1L,3L,6L,3L,6L,2L,1L,10L,5L,5L,5L,10L,10L,10L,5L,2L,1L,12L,3L,6L,4L,12L,12L,4L,3L,6L,12L,2L,1L,8L,16L,4L,16L,16L,16L,8L,8L,16L,16L,16L,4L,16L,8L,2L,1L,18L,18L,9L,9L,9L,3L,6L,9L,18L,3L,6L,18L,18L,18L,9L,9L,2L,1L,11L,11L,11L,22L,11L,22L,11L,11L,22L,22L,11L,11L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086145Inst : IEnumerable<long>
{
public static readonly long[] Value=A086145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086145.Bytes);
public long this[int i]=>Value[i];

public static A086145Inst Instance=new A086145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086146
{
public static readonly long[] Value={ 1L,2L,3L,11L,7L,9L,10L,11L,14L,19L,12L,21L,28L,19L,24L,66L,54L,21L,20L,58L,24L,25L,32L,70L,44L,28L,39L,55L,91L,97L,44L,66L,35L,94L,39L,80L,86L,47L,129L,66L,45L,75L,100L,58L,129L,75L,56L,70L,68L,74L,178L,62L,66L,340L,58L,75L,209L,97L,93L,124L,115L,101L,138L,66L,84L,75L,111L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086146Inst : IEnumerable<long>
{
public static readonly long[] Value=A086146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086146.Bytes);
public long this[int i]=>Value[i];

public static A086146Inst Instance=new A086146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086147
{
public static readonly long[] Value={ 1L,13L,219L,367L,4891L,1977L,36085L,9791L,46731L,39133L,479157L,37119L,1289911L,243703L,375219L,305599L,6991319L,299913L,11500123L,667219L,2610657L,3723423L,40035651L,781127L,14928331L,8544673L,11297307L,4540153L,129539703L,2739477L,209881105L,9748415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086147Inst : IEnumerable<long>
{
public static readonly long[] Value=A086147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086147.Bytes);
public long this[int i]=>Value[i];

public static A086147Inst Instance=new A086147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086196
{
public static readonly long[] Value={ 2L,3L,4L,1L,1L,1L,1L,9L,10L,11L,4L,13L,14L,5L,16L,17L,3L,19L,10L,7L,11L,23L,4L,25L,26L,27L,28L,29L,10L,31L,32L,33L,34L,35L,36L,37L,19L,39L,20L,41L,3L,43L,22L,45L,23L,47L,24L,7L,10L,17L,52L,53L,18L,11L,56L,19L,58L,59L,4L,61L,62L,21L,64L,13L,33L,67L,17L,69L,7L,71L,18L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086196Inst : IEnumerable<long>
{
public static readonly long[] Value=A086196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086196.Bytes);
public long this[int i]=>Value[i];

public static A086196Inst Instance=new A086196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086197
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,1L,1L,11L,13L,14L,5L,17L,9L,19L,5L,24L,25L,27L,7L,10L,31L,32L,11L,36L,19L,13L,3L,44L,3L,46L,47L,52L,53L,54L,55L,57L,29L,59L,3L,63L,32L,65L,3L,68L,35L,71L,3L,76L,39L,80L,81L,83L,14L,87L,11L,91L,46L,93L,47L,96L,97L,14L,25L,106L,107L,108L,109L,37L,8L,113L,19L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086197Inst : IEnumerable<long>
{
public static readonly long[] Value=A086197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086197.Bytes);
public long this[int i]=>Value[i];

public static A086197Inst Instance=new A086197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086198
{
public static readonly long[] Value={ 2L,3L,4L,1L,1L,1L,1L,9L,10L,11L,4L,13L,7L,15L,4L,17L,18L,19L,5L,7L,22L,23L,8L,25L,13L,9L,2L,29L,2L,31L,32L,33L,34L,35L,36L,37L,19L,39L,2L,41L,21L,43L,2L,45L,23L,47L,2L,49L,25L,51L,52L,53L,9L,55L,7L,57L,29L,59L,30L,61L,62L,9L,16L,65L,66L,67L,68L,23L,5L,71L,12L,73L,37L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086198Inst : IEnumerable<long>
{
public static readonly long[] Value=A086198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086198.Bytes);
public long this[int i]=>Value[i];

public static A086198Inst Instance=new A086198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086199
{
public static readonly long[] Value={ 9L,0L,8L,9L,0L,8L,5L,5L,7L,5L,4L,8L,5L,4L,1L,4L,7L,8L,2L,3L,6L,1L,1L,8L,9L,0L,8L,7L,4L,4L,7L,9L,3L,5L,0L,4L,9L,0L,1L,0L,1L,3L,9L,6L,9L,3L,4L,0L,4L,1L,1L,8L,3L,8L,1L,9L,8L,0L,7L,2L,5L,9L,6L,0L,9L,5L,6L,3L,8L,1L,4L,9L,0L,9L,2L,4L,2L,0L,3L,3L,9L,2L,2L,8L,2L,4L,4L,7L,0L,7L,0L,1L,1L,2L,0L,6L,0L,9L,3L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086199Inst : IEnumerable<long>
{
public static readonly long[] Value=A086199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086199.Bytes);
public long this[int i]=>Value[i];

public static A086199Inst Instance=new A086199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086200
{
public static readonly long[] Value={ 1L,3L,15L,66L,406L,2775L,19900L,152076L,1206681L,9841266L,82336528L,702993756L,6105180250L,53822344278L,480681790786L,4342078862605L,39621836138886L,364831810979041L,3386667673687950L,31669036266203766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086200Inst : IEnumerable<long>
{
public static readonly long[] Value=A086200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086200.Bytes);
public long this[int i]=>Value[i];

public static A086200Inst Instance=new A086200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086201
{
public static readonly long[] Value={ 1L,5L,9L,1L,5L,4L,9L,4L,3L,0L,9L,1L,8L,9L,5L,3L,3L,5L,7L,6L,8L,8L,8L,3L,7L,6L,3L,3L,7L,2L,5L,1L,4L,3L,6L,2L,0L,3L,4L,4L,5L,9L,6L,4L,5L,7L,4L,0L,4L,5L,6L,4L,4L,8L,7L,4L,7L,6L,6L,7L,3L,4L,4L,0L,5L,8L,8L,9L,6L,7L,9L,7L,6L,3L,4L,2L,2L,6L,5L,3L,5L,0L,9L,0L,1L,1L,3L,8L,0L,2L,7L,6L,6L,2L,5L,3L,0L,8L,5L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086201Inst : IEnumerable<long>
{
public static readonly long[] Value=A086201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086201.Bytes);
public long this[int i]=>Value[i];

public static A086201Inst Instance=new A086201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086202
{
public static readonly long[] Value={ 4L,7L,5L,6L,2L,6L,0L,7L,6L,7L,3L,5L,9L,8L,8L,5L,5L,4L,8L,0L,4L,9L,7L,7L,2L,5L,2L,9L,0L,4L,9L,5L,4L,7L,1L,4L,2L,8L,1L,9L,6L,0L,5L,3L,1L,3L,5L,3L,8L,2L,2L,7L,5L,2L,8L,9L,5L,8L,1L,1L,1L,3L,4L,2L,0L,9L,5L,7L,4L,0L,4L,0L,2L,8L,7L,4L,9L,8L,4L,0L,0L,4L,7L,1L,2L,7L,3L,8L,7L,6L,8L,8L,5L,6L,2L,9L,5L,2L,3L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086202Inst : IEnumerable<long>
{
public static readonly long[] Value=A086202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086202.Bytes);
public long this[int i]=>Value[i];

public static A086202Inst Instance=new A086202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086203
{
public static readonly long[] Value={ 1L,4L,7L,5L,8L,3L,6L,1L,7L,6L,5L,0L,4L,3L,3L,2L,7L,4L,1L,7L,5L,4L,0L,1L,0L,7L,6L,2L,2L,4L,7L,4L,0L,5L,2L,5L,9L,5L,1L,1L,3L,4L,5L,2L,3L,8L,8L,6L,9L,1L,7L,8L,9L,4L,5L,9L,9L,9L,2L,2L,3L,1L,2L,8L,6L,2L,7L,1L,1L,4L,7L,6L,7L,8L,6L,0L,2L,6L,3L,3L,6L,7L,3L,1L,7L,1L,4L,2L,9L,8L,9L,4L,7L,7L,8L,9L,8L,0L,4L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086203Inst : IEnumerable<long>
{
public static readonly long[] Value=A086203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086203.Bytes);
public long this[int i]=>Value[i];

public static A086203Inst Instance=new A086203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086204
{
public static readonly long[] Value={ 2L,2L,47L,151L,4001L,4001L,100207L,41532851L,447045215857L,282607273285049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086204Inst : IEnumerable<long>
{
public static readonly long[] Value=A086204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086204.Bytes);
public long this[int i]=>Value[i];

public static A086204Inst Instance=new A086204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086205
{
public static readonly BigInteger[] Value={ 1L,1L,6L,360L,302400L,4572288000L,1520925880320000L,BigInteger.Parse("13153940405570764800000"),BigInteger.Parse("3412910854477066178396160000000"),BigInteger.Parse("30107378079113824305786648526848000000000") };
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
public class A086205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086205Inst Instance=new A086205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086206
{
public static readonly BigInteger[] Value={ 0L,1L,27L,2401L,759375L,887503681L,3938980639167L,67675234241018881L,BigInteger.Parse("4558916353692287109375"),BigInteger.Parse("1213972926354344043087129601") };
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
public class A086206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086206Inst Instance=new A086206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086207
{
public static readonly long[] Value={ 3L,435L,704403L,15823018515L,5272966965638163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086207Inst : IEnumerable<long>
{
public static readonly long[] Value=A086207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086207.Bytes);
public long this[int i]=>Value[i];

public static A086207Inst Instance=new A086207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086208
{
public static readonly long[] Value={ 3L,7L,13L,43L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086208Inst : IEnumerable<long>
{
public static readonly long[] Value=A086208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086208.Bytes);
public long this[int i]=>Value[i];

public static A086208Inst Instance=new A086208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086209
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,11L,29L,66L,216L,656L,2595L,9744L,49895L,232379L,1409681L,8499639L,62575472L,457432705L,4149365733L,37128654099L,403871166718L,4462555420780L,57791900756532L,769856248243565L,12070457173762581L,193254691673461508L,3581624759657803466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086209Inst : IEnumerable<long>
{
public static readonly long[] Value=A086209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086209.Bytes);
public long this[int i]=>Value[i];

public static A086209Inst Instance=new A086209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086210
{
public static readonly long[] Value={ 7L,1L,4L,22L,26L,34L,38L,46L,58L,62L,74L,82L,86L,95L,7L,19L,23L,35L,43L,47L,59L,67L,79L,94L,202L,206L,214L,218L,226L,254L,262L,274L,278L,298L,302L,314L,326L,334L,346L,358L,362L,382L,386L,394L,398L,422L,446L,454L,458L,466L,478L,482L,502L,514L,526L,538L,542L,554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086210Inst : IEnumerable<long>
{
public static readonly long[] Value=A086210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086210.Bytes);
public long this[int i]=>Value[i];

public static A086210Inst Instance=new A086210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086211
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,6L,9L,6L,1L,22L,31L,28L,10L,1L,92L,123L,126L,69L,15L,1L,426L,549L,586L,418L,145L,21L,1L,2146L,2695L,2892L,2425L,1165L,272L,28L,1L,11624L,14319L,15262L,14058L,8551L,2826L,469L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086211Inst : IEnumerable<long>
{
public static readonly long[] Value=A086211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086211.Bytes);
public long this[int i]=>Value[i];

public static A086211Inst Instance=new A086211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086228
{
public static readonly BigInteger[] Value={ 1L,3L,15L,140L,2520L,88704L,6150144L,843448320L,229417943040L,123987652771840L,133311524260282368L,BigInteger.Parse("285432092670742757376"),BigInteger.Parse("1217843595395169098137600"),BigInteger.Parse("10360289146303272377017958400"),BigInteger.Parse("175805226564926843718814452940800") };
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
public class A086228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086228Inst Instance=new A086228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086229
{
public static readonly BigInteger[] Value={ 1L,1L,3L,20L,280L,8064L,473088L,56229888L,13495173120L,6525665935360L,6348167821918208L,12410090985684467712UL,BigInteger.Parse("48713743815806763925504"),BigInteger.Parse("383714412826047125074739200"),BigInteger.Parse("6062249191894029093752222515200") };
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
public class A086229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086229Inst Instance=new A086229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086230
{
public static readonly long[] Value={ 3L,4L,0L,5L,3L,7L,3L,2L,9L,5L,5L,0L,9L,9L,9L,1L,4L,2L,8L,2L,6L,2L,7L,3L,1L,8L,4L,4L,3L,2L,9L,0L,2L,8L,9L,6L,7L,1L,0L,6L,0L,8L,2L,1L,7L,1L,2L,4L,3L,0L,2L,0L,9L,7L,7L,6L,3L,2L,3L,6L,1L,0L,5L,3L,7L,7L,7L,9L,1L,9L,6L,9L,4L,5L,8L,9L,6L,2L,3L,8L,4L,6L,4L,2L,5L,2L,8L,0L,8L,1L,8L,8L,9L,0L,5L,7L,1L,3L,0L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086230Inst : IEnumerable<long>
{
public static readonly long[] Value=A086230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086230.Bytes);
public long this[int i]=>Value[i];

public static A086230Inst Instance=new A086230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086231
{
public static readonly long[] Value={ 1L,5L,1L,6L,3L,8L,6L,0L,5L,9L,1L,5L,1L,9L,7L,8L,0L,1L,8L,1L,5L,6L,0L,1L,2L,1L,5L,9L,6L,8L,1L,4L,2L,0L,7L,7L,9L,9L,5L,5L,3L,8L,7L,0L,4L,4L,4L,5L,2L,2L,6L,2L,6L,7L,6L,5L,6L,6L,9L,8L,0L,4L,6L,3L,6L,5L,8L,0L,8L,6L,3L,2L,0L,3L,5L,3L,5L,2L,1L,4L,5L,0L,4L,0L,1L,6L,1L,1L,7L,4L,1L,2L,0L,9L,6L,8L,8L,1L,1L,3L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086231Inst : IEnumerable<long>
{
public static readonly long[] Value=A086231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086231.Bytes);
public long this[int i]=>Value[i];

public static A086231Inst Instance=new A086231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086232
{
public static readonly long[] Value={ 1L,9L,3L,2L,0L,1L,6L,7L,3L,2L,2L,4L,9L,8L,3L,9L,3L,7L,3L,4L,1L,8L,7L,0L,9L,7L,3L,3L,2L,9L,3L,6L,9L,1L,6L,0L,5L,7L,5L,8L,7L,3L,3L,8L,6L,4L,5L,0L,1L,3L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086232Inst : IEnumerable<long>
{
public static readonly long[] Value=A086232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086232.Bytes);
public long this[int i]=>Value[i];

public static A086232Inst Instance=new A086232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086233
{
public static readonly long[] Value={ 1L,3L,5L,1L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086233Inst : IEnumerable<long>
{
public static readonly long[] Value=A086233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086233.Bytes);
public long this[int i]=>Value[i];

public static A086233Inst Instance=new A086233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086234
{
public static readonly long[] Value={ 1L,0L,4L,7L,1L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086234Inst : IEnumerable<long>
{
public static readonly long[] Value=A086234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086234.Bytes);
public long this[int i]=>Value[i];

public static A086234Inst Instance=new A086234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086235
{
public static readonly long[] Value={ 0L,8L,5L,8L,4L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086235Inst : IEnumerable<long>
{
public static readonly long[] Value=A086235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086235.Bytes);
public long this[int i]=>Value[i];

public static A086235Inst Instance=new A086235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086236
{
public static readonly long[] Value={ 0L,7L,2L,9L,1L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086236Inst : IEnumerable<long>
{
public static readonly long[] Value=A086236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086236.Bytes);
public long this[int i]=>Value[i];

public static A086236Inst Instance=new A086236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086237
{
public static readonly long[] Value={ 1L,4L,6L,7L,0L,7L,8L,0L,7L,9L,4L,3L,3L,9L,7L,5L,4L,7L,2L,8L,9L,7L,7L,9L,8L,4L,8L,4L,7L,0L,7L,2L,2L,9L,9L,5L,3L,4L,4L,9L,9L,0L,3L,3L,2L,2L,4L,1L,4L,8L,8L,7L,7L,7L,7L,3L,9L,9L,6L,8L,5L,8L,1L,7L,6L,1L,6L,6L,0L,6L,7L,4L,4L,3L,2L,9L,0L,4L,4L,8L,0L,8L,4L,3L,0L,3L,6L,9L,3L,2L,7L,5L,1L,1L,1L,7L,4L,0L,1L,5L,2L,1L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086237Inst : IEnumerable<long>
{
public static readonly long[] Value=A086237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086237.Bytes);
public long this[int i]=>Value[i];

public static A086237Inst Instance=new A086237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086238
{
public static readonly long[] Value={ 1L,9L,2L,8L,7L,8L,2L,1L,8L,7L,1L,5L,0L,2L,1L,6L,6L,8L,3L,8L,9L,5L,4L,0L,1L,8L,7L,0L,9L,3L,2L,3L,6L,6L,9L,4L,2L,3L,0L,3L,7L,7L,0L,6L,0L,9L,3L,8L,9L,9L,3L,6L,0L,0L,2L,3L,8L,7L,8L,2L,8L,0L,7L,9L,2L,0L,2L,9L,2L,7L,0L,8L,6L,0L,7L,8L,2L,6L,9L,8L,8L,5L,1L,3L,8L,8L,8L,2L,7L,7L,1L,6L,4L,5L,0L,0L,5L,3L,0L,9L,2L,4L,2L,4L,0L,3L,1L,5L,7L,4L,8L,5L,4L,8L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086238Inst : IEnumerable<long>
{
public static readonly long[] Value=A086238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086238.Bytes);
public long this[int i]=>Value[i];

public static A086238Inst Instance=new A086238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086239
{
public static readonly long[] Value={ 3L,3L,4L,9L,8L,1L,3L,2L,5L,2L,9L,9L,9L,9L,3L,1L,8L,1L,0L,6L,3L,3L,1L,7L,1L,2L,1L,4L,8L,7L,5L,4L,3L,5L,7L,3L,7L,7L,9L,9L,7L,5L,3L,8L,0L,7L,5L,5L,0L,7L,7L,0L,4L,8L,1L,0L,8L,0L,2L,0L,5L,7L,8L,8L,4L,5L,2L,2L,2L,8L,4L,3L,2L,7L,1L,8L,8L,4L,1L,1L,0L,6L,2L,4L,8L,9L,9L,6L,3L,1L,0L,2L,9L,8L,0L,3L,3L,4L,5L,3L,9L,2L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086239Inst : IEnumerable<long>
{
public static readonly long[] Value=A086239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086239.Bytes);
public long this[int i]=>Value[i];

public static A086239Inst Instance=new A086239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086240
{
public static readonly long[] Value={ 0L,9L,4L,6L,1L,9L,8L,9L,2L,8L,9L,2L,9L,5L,0L,1L,5L,7L,9L,4L,5L,1L,8L,6L,7L,9L,0L,1L,4L,9L,1L,7L,4L,8L,0L,9L,6L,0L,1L,8L,8L,0L,3L,4L,0L,2L,4L,9L,7L,2L,1L,3L,5L,7L,1L,4L,8L,5L,9L,6L,0L,8L,5L,7L,5L,9L,4L,3L,1L,3L,7L,3L,2L,7L,5L,6L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086240Inst : IEnumerable<long>
{
public static readonly long[] Value=A086240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086240.Bytes);
public long this[int i]=>Value[i];

public static A086240Inst Instance=new A086240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086241
{
public static readonly long[] Value={ 6L,4L,1L,9L,4L,4L,8L,3L,8L,5L,3L,3L,1L,9L,5L,7L,0L,8L,6L,6L,1L,3L,9L,2L,6L,3L,9L,7L,2L,1L,7L,3L,4L,3L,1L,6L,6L,7L,5L,4L,1L,1L,0L,4L,4L,0L,1L,5L,8L,8L,9L,6L,5L,4L,9L,0L,8L,1L,7L,0L,8L,4L,5L,1L,3L,1L,7L,3L,3L,2L,8L,2L,6L,9L,0L,7L,3L,7L,2L,3L,3L,5L,9L,8L,1L,7L,4L,1L,5L,9L,9L,4L,5L,6L,0L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086241Inst : IEnumerable<long>
{
public static readonly long[] Value=A086241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086241.Bytes);
public long this[int i]=>Value[i];

public static A086241Inst Instance=new A086241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086242
{
public static readonly long[] Value={ 1L,3L,7L,5L,0L,6L,4L,9L,9L,4L,7L,4L,8L,6L,3L,5L,2L,8L,7L,9L,1L,7L,2L,5L,3L,1L,3L,0L,5L,2L,2L,4L,3L,9L,6L,9L,9L,1L,7L,9L,5L,9L,9L,9L,6L,0L,1L,7L,5L,3L,1L,7L,4L,5L,8L,7L,0L,9L,1L,8L,9L,3L,3L,5L,8L,9L,1L,2L,3L,5L,7L,1L,3L,1L,4L,1L,5L,5L,5L,2L,5L,5L,4L,2L,9L,9L,0L,7L,6L,5L,2L,4L,1L,6L,5L,8L,8L,1L,1L,4L,5L,2L,7L,6L,0L,6L,5L,7L,4L,4L,8L,0L,6L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086242Inst : IEnumerable<long>
{
public static readonly long[] Value=A086242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086242.Bytes);
public long this[int i]=>Value[i];

public static A086242Inst Instance=new A086242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086243
{
public static readonly long[] Value={ 2L,14L,68L,604L,4312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086243Inst : IEnumerable<long>
{
public static readonly long[] Value=A086243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086243.Bytes);
public long this[int i]=>Value[i];

public static A086243Inst Instance=new A086243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086356
{
public static readonly long[] Value={ 2L,6L,2L,7L,2L,4L,4L,2L,2L,6L,6L,6L,8L,6L,5L,8L,8L,4L,8L,2L,9L,8L,6L,8L,6L,2L,8L,8L,2L,8L,6L,2L,6L,6L,8L,2L,6L,6L,6L,8L,9L,2L,2L,8L,2L,8L,2L,8L,6L,4L,2L,2L,8L,8L,2L,8L,6L,8L,2L,8L,6L,8L,9L,6L,6L,2L,6L,2L,2L,2L,8L,6L,8L,6L,8L,2L,8L,8L,8L,8L,8L,8L,6L,2L,6L,2L,8L,6L,8L,8L,8L,8L,8L,6L,8L,8L,6L,8L,2L,8L,2L,8L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086356Inst : IEnumerable<long>
{
public static readonly long[] Value=A086356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086356.Bytes);
public long this[int i]=>Value[i];

public static A086356Inst Instance=new A086356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086357
{
public static readonly long[] Value={ 2L,6L,3L,2L,6L,9L,1L,6L,8L,2L,8L,8L,8L,8L,6L,8L,6L,7L,8L,2L,8L,8L,8L,6L,2L,8L,1L,6L,8L,2L,2L,2L,8L,6L,8L,8L,8L,6L,4L,6L,2L,8L,2L,6L,6L,2L,2L,2L,6L,6L,8L,6L,2L,8L,8L,8L,5L,8L,6L,8L,2L,8L,8L,1L,2L,2L,8L,6L,8L,2L,2L,8L,2L,8L,8L,2L,2L,8L,8L,9L,6L,8L,4L,6L,8L,8L,8L,2L,8L,6L,8L,1L,6L,2L,2L,8L,1L,6L,6L,8L,6L,9L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086357Inst : IEnumerable<long>
{
public static readonly long[] Value=A086357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086357.Bytes);
public long this[int i]=>Value[i];

public static A086357Inst Instance=new A086357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086358
{
public static readonly long[] Value={ 1L,2L,6L,6L,3L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086358Inst : IEnumerable<long>
{
public static readonly long[] Value=A086358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086358.Bytes);
public long this[int i]=>Value[i];

public static A086358Inst Instance=new A086358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086359
{
public static readonly long[] Value={ 2L,6L,2L,7L,9L,6L,3L,9L,2L,4L,3L,7L,2L,9L,9L,9L,9L,6L,3L,9L,3L,6L,9L,9L,9L,9L,2L,4L,3L,4L,5L,9L,3L,6L,9L,7L,5L,6L,2L,7L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,6L,3L,9L,3L,6L,9L,9L,9L,9L,3L,6L,9L,6L,3L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,2L,4L,3L,4L,5L,9L,3L,6L,9L,4L,8L,6L,5L,4L,9L,9L,9L,9L,3L,6L,9L,6L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086359Inst : IEnumerable<long>
{
public static readonly long[] Value=A086359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086359.Bytes);
public long this[int i]=>Value[i];

public static A086359Inst Instance=new A086359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086360
{
public static readonly long[] Value={ 2L,6L,3L,3L,6L,6L,3L,3L,6L,3L,3L,3L,6L,6L,3L,6L,3L,3L,3L,6L,6L,6L,3L,6L,6L,3L,3L,6L,6L,3L,3L,6L,3L,3L,6L,6L,6L,6L,3L,6L,3L,3L,6L,6L,3L,3L,3L,3L,6L,6L,3L,6L,6L,3L,6L,3L,6L,6L,6L,3L,3L,6L,6L,3L,3L,6L,6L,6L,3L,3L,6L,3L,3L,3L,3L,6L,3L,3L,6L,6L,3L,3L,6L,6L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086360Inst : IEnumerable<long>
{
public static readonly long[] Value=A086360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086360.Bytes);
public long this[int i]=>Value[i];

public static A086360Inst Instance=new A086360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086361
{
public static readonly long[] Value={ 13L,61L,127L,73L,61L,397L,211L,97L,163L,181L,463L,5689L,547L,1093L,271L,673L,1123L,10909L,229L,241L,4663L,661L,967L,1873L,7951L,1093L,16363L,5209L,349L,541L,373L,7873L,397L,409L,421L,433L,4219L,9349L,15679L,1201L,1723L,7309L,15739L,3433L,811L,1933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086361Inst : IEnumerable<long>
{
public static readonly long[] Value=A086361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086361.Bytes);
public long this[int i]=>Value[i];

public static A086361Inst Instance=new A086361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086362
{
public static readonly long[] Value={ 5L,17L,239L,41L,131L,1889L,419L,89L,101L,113L,2543L,2789L,149L,881L,173L,9293L,491L,14249L,3191L,1973L,3539L,21377L,7103L,281L,5987L,38153L,317L,2789L,6971L,353L,214943L,42677L,3299L,11801L,2267L,27773L,29867L,10529L,461L,1181L,2663L,129209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086362Inst : IEnumerable<long>
{
public static readonly long[] Value=A086362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086362.Bytes);
public long this[int i]=>Value[i];

public static A086362Inst Instance=new A086362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086363
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,5L,4L,6L,9L,14L,10L,14L,20L,29L,43L,26L,36L,50L,70L,99L,142L,76L,102L,138L,188L,258L,357L,499L,232L,308L,410L,548L,736L,994L,1351L,1850L,764L,996L,1304L,1714L,2262L,2998L,3992L,5343L,7193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086363Inst : IEnumerable<long>
{
public static readonly long[] Value=A086363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086363.Bytes);
public long this[int i]=>Value[i];

public static A086363Inst Instance=new A086363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086364
{
public static readonly long[] Value={ 1L,2L,2L,2L,9L,4L,2L,27L,36L,10L,2L,65L,195L,140L,26L,2L,143L,840L,1180L,540L,76L,2L,301L,3171L,7735L,6510L,2142L,232L,2L,619L,11060L,43659L,59920L,34692L,8624L,764L,2L,1257L,36707L,223566L,467691L,423612L,180852L,35856L,2620L,2L,2535L,117960L,1071350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086364Inst : IEnumerable<long>
{
public static readonly long[] Value=A086364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086364.Bytes);
public long this[int i]=>Value[i];

public static A086364Inst Instance=new A086364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086365
{
public static readonly BigInteger[] Value={ 1L,4L,15L,75L,428L,2781L,20093L,159340L,1372163L,12725447L,126238060L,1332071241L,14881206473L,175297058228L,2169832010759L,28136696433171L,381199970284620L,5383103100853189L,79065882217154085L,1205566492711167004L,BigInteger.Parse("19049651311462785947") };
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
public class A086365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086365Inst Instance=new A086365Inst();

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