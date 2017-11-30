using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A133769
{
public static readonly long[] Value={ 9L,23L,0L,9L,23L,0L,12L,0L,11L,7L,20L,4L,9L,0L,0L,9L,10L,0L,13L,0L,7L,9L,0L,8L,20L,12L,23L,7L,0L,0L,11L,0L,3L,0L,9L,2L,4L,11L,7L,9L,8L,3L,6L,0L,0L,10L,9L,15L,0L,17L,4L,0L,12L,4L,7L,11L,6L,5L,12L,0L,11L,4L,0L,11L,15L,9L,10L,0L,13L,0L,5L,5L,12L,2L,8L,11L,12L,0L,8L,15L,0L,23L,6L,0L,8L,3L,6L,11L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133769Inst : IEnumerable<long>
{
public static readonly long[] Value=A133769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133769.Bytes);
public long this[int i]=>Value[i];

public static A133769Inst Instance=new A133769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133770
{
public static readonly long[] Value={ 2L,1L,2L,2L,4L,3L,2L,4L,3L,4L,2L,4L,3L,4L,4L,6L,5L,2L,4L,3L,4L,4L,6L,5L,4L,6L,5L,6L,2L,4L,3L,4L,4L,6L,5L,4L,6L,5L,6L,4L,6L,5L,6L,6L,8L,7L,2L,4L,3L,4L,4L,6L,5L,4L,6L,5L,6L,4L,6L,5L,6L,6L,8L,7L,4L,6L,5L,6L,6L,8L,7L,6L,8L,7L,8L,2L,4L,3L,4L,4L,6L,5L,4L,6L,5L,6L,4L,6L,5L,6L,6L,8L,7L,4L,6L,5L,6L,6L,8L,7L,6L,8L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133770Inst : IEnumerable<long>
{
public static readonly long[] Value=A133770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133770.Bytes);
public long this[int i]=>Value[i];

public static A133770Inst Instance=new A133770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133771
{
public static readonly long[] Value={ 2L,1L,1L,2L,3L,1L,3L,2L,3L,1L,4L,5L,3L,3L,2L,3L,1L,5L,4L,5L,3L,4L,5L,3L,3L,2L,3L,1L,6L,7L,5L,5L,4L,5L,3L,5L,4L,5L,3L,4L,5L,3L,3L,2L,3L,1L,7L,6L,7L,5L,6L,7L,5L,5L,4L,5L,3L,6L,7L,5L,5L,4L,5L,3L,5L,4L,5L,3L,4L,5L,3L,3L,2L,3L,1L,8L,9L,7L,7L,6L,7L,5L,7L,6L,7L,5L,6L,7L,5L,5L,4L,5L,3L,7L,6L,7L,5L,6L,7L,5L,5L,4L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133771Inst : IEnumerable<long>
{
public static readonly long[] Value=A133771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133771.Bytes);
public long this[int i]=>Value[i];

public static A133771Inst Instance=new A133771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133772
{
public static readonly long[] Value={ 1L,3L,3L,5L,5L,5L,3L,5L,7L,7L,9L,7L,7L,7L,9L,7L,7L,3L,5L,7L,7L,9L,9L,9L,7L,9L,11L,11L,13L,9L,9L,9L,11L,9L,9L,7L,9L,11L,11L,13L,9L,9L,9L,11L,9L,9L,3L,5L,7L,7L,9L,9L,9L,7L,9L,11L,11L,13L,11L,11L,11L,13L,11L,11L,7L,9L,11L,11L,13L,13L,13L,11L,13L,15L,15L,17L,11L,11L,11L,13L,11L,11L,9L,11L,13L,13L,15L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133772Inst : IEnumerable<long>
{
public static readonly long[] Value=A133772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133772.Bytes);
public long this[int i]=>Value[i];

public static A133772Inst Instance=new A133772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133773
{
public static readonly long[] Value={ 1L,1L,3L,5L,3L,3L,7L,5L,5L,5L,9L,5L,5L,7L,5L,5L,5L,11L,9L,9L,7L,5L,7L,7L,9L,7L,7L,7L,13L,7L,7L,9L,7L,7L,7L,11L,9L,9L,7L,5L,7L,7L,9L,7L,7L,7L,15L,13L,13L,11L,9L,11L,11L,11L,9L,9L,7L,5L,9L,9L,11L,9L,9L,9L,13L,11L,11L,9L,7L,9L,9L,11L,9L,9L,9L,17L,9L,9L,11L,9L,9L,9L,13L,11L,11L,9L,7L,9L,9L,11L,9L,9L,9L,15L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133773Inst : IEnumerable<long>
{
public static readonly long[] Value=A133773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133773.Bytes);
public long this[int i]=>Value[i];

public static A133773Inst Instance=new A133773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133774
{
public static readonly long[] Value={ 1L,3L,3L,3L,6L,6L,5L,6L,6L,6L,5L,9L,9L,8L,9L,9L,9L,7L,8L,8L,9L,10L,9L,9L,8L,9L,9L,9L,7L,12L,12L,11L,12L,12L,12L,10L,11L,11L,12L,13L,12L,12L,11L,12L,12L,12L,9L,10L,10L,11L,12L,11L,11L,11L,12L,12L,13L,14L,12L,12L,11L,12L,12L,12L,10L,11L,11L,12L,13L,12L,12L,11L,12L,12L,12L,9L,15L,15L,14L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133774Inst : IEnumerable<long>
{
public static readonly long[] Value=A133774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133774.Bytes);
public long this[int i]=>Value[i];

public static A133774Inst Instance=new A133774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133775
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,5L,7L,6L,5L,5L,4L,8L,8L,8L,7L,8L,8L,11L,10L,9L,9L,8L,8L,8L,9L,8L,7L,7L,6L,11L,11L,11L,10L,11L,11L,12L,11L,10L,10L,9L,11L,11L,11L,10L,11L,11L,15L,14L,13L,13L,12L,12L,12L,13L,12L,11L,11L,10L,11L,11L,11L,10L,11L,11L,13L,12L,11L,11L,10L,10L,10L,11L,10L,9L,9L,8L,14L,14L,14L,13L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133775Inst : IEnumerable<long>
{
public static readonly long[] Value=A133775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133775.Bytes);
public long this[int i]=>Value[i];

public static A133775Inst Instance=new A133775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133776
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,1L,3L,2L,2L,2L,4L,2L,2L,3L,2L,2L,2L,5L,4L,4L,3L,2L,3L,3L,4L,3L,3L,3L,6L,3L,3L,4L,3L,3L,3L,5L,4L,4L,3L,2L,3L,3L,4L,3L,3L,3L,7L,6L,6L,5L,4L,5L,5L,5L,4L,4L,3L,2L,4L,4L,5L,4L,4L,4L,6L,5L,5L,4L,3L,4L,4L,5L,4L,4L,4L,8L,4L,4L,5L,4L,4L,4L,6L,5L,5L,4L,3L,4L,4L,5L,4L,4L,4L,7L,6L,6L,5L,4L,5L,5L,5L,4L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133776Inst : IEnumerable<long>
{
public static readonly long[] Value=A133776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133776.Bytes);
public long this[int i]=>Value[i];

public static A133776Inst Instance=new A133776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133777
{
public static readonly long[] Value={ 1L,1L,1L,2L,15L,47L,840L,4539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133777Inst : IEnumerable<long>
{
public static readonly long[] Value=A133777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133777.Bytes);
public long this[int i]=>Value[i];

public static A133777Inst Instance=new A133777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133778
{
public static readonly long[] Value={ 15015L,41055L,46035L,5581695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133778Inst : IEnumerable<long>
{
public static readonly long[] Value=A133778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133778.Bytes);
public long this[int i]=>Value[i];

public static A133778Inst Instance=new A133778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133779
{
public static readonly long[] Value={ 1L,0L,1L,3L,4L,1L,5L,6L,1L,7L,4L,8L,1L,3L,9L,5L,10L,1L,11L,6L,12L,1L,13L,7L,14L,1L,3L,5L,15L,4L,8L,16L,1L,17L,6L,9L,18L,1L,19L,10L,20L,1L,3L,7L,21L,11L,22L,1L,23L,6L,8L,12L,24L,1L,5L,25L,13L,26L,1L,3L,9L,27L,4L,7L,14L,28L,1L,29L,10L,15L,30L,1L,31L,4L,8L,16L,32L,1L,3L,11L,33L,17L,34L,1L,5L,7L,35L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133779Inst : IEnumerable<long>
{
public static readonly long[] Value=A133779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133779.Bytes);
public long this[int i]=>Value[i];

public static A133779Inst Instance=new A133779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133780
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,3L,1L,2L,1L,2L,1L,2L,3L,4L,1L,2L,1L,2L,1L,2L,3L,1L,2L,4L,5L,1L,2L,1L,2L,3L,4L,1L,2L,1L,2L,1L,2L,3L,5L,6L,1L,2L,1L,2L,1L,2L,3L,4L,1L,2L,1L,2L,4L,5L,1L,2L,3L,6L,7L,1L,2L,1L,2L,1L,2L,3L,4L,1L,2L,1L,2L,1L,2L,3L,1L,2L,7L,8L,1L,2L,1L,2L,3L,4L,5L,6L,1L,2L,1L,2L,1L,2L,3L,1L,2L,1L,2L,1L,2L,3L,4L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133780Inst : IEnumerable<long>
{
public static readonly long[] Value=A133780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133780.Bytes);
public long this[int i]=>Value[i];

public static A133780Inst Instance=new A133780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133781
{
public static readonly long[] Value={ 127L,131L,151L,173L,1117L,2131L,2179L,3191L,4231L,4297L,6311L,6373L,7411L,7433L,7477L,7537L,7591L,9613L,9677L,9719L,9733L,9791L,9833L,2897L,2971L,21011L,21031L,31079L,31091L,31139L,31271L,31319L,31379L,31391L,41491L,41513L,41579L,51631L,51673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133781Inst : IEnumerable<long>
{
public static readonly long[] Value=A133781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133781.Bytes);
public long this[int i]=>Value[i];

public static A133781Inst Instance=new A133781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133782
{
public static readonly long[] Value={ 31L,32L,36L,40L,187L,321L,327L,452L,580L,590L,821L,831L,940L,942L,946L,955L,965L,1186L,1194L,1198L,1200L,1208L,1213L,419L,429L,2362L,2367L,3348L,3350L,3353L,3372L,3375L,3381L,3383L,4339L,4341L,4347L,5284L,5288L,7995L,8000L,8001L,8009L,8011L,8016L,8887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133782Inst : IEnumerable<long>
{
public static readonly long[] Value=A133782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133782.Bytes);
public long this[int i]=>Value[i];

public static A133782Inst Instance=new A133782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133783
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,23L,31L,41L,43L,53L,61L,113L,131L,151L,163L,211L,223L,233L,241L,251L,263L,311L,313L,331L,353L,421L,431L,433L,443L,461L,463L,521L,523L,541L,563L,613L,631L,641L,643L,653L,661L,1123L,1151L,1153L,1163L,1213L,1223L,1231L,1321L,1361L,1423L,1433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133783Inst : IEnumerable<long>
{
public static readonly long[] Value=A133783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133783.Bytes);
public long this[int i]=>Value[i];

public static A133783Inst Instance=new A133783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133816
{
public static readonly long[] Value={ 9L,16L,7L,5L,14L,2L,5L,18L,21L,3L,6L,5L,10L,4L,3L,3L,9L,8L,15L,7L,8L,16L,13L,4L,13L,8L,21L,3L,6L,12L,3L,18L,4L,3L,15L,7L,8L,5L,2L,5L,12L,6L,21L,3L,6L,9L,4L,5L,7L,7L,10L,22L,3L,22L,13L,12L,17L,2L,3L,14L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133816Inst : IEnumerable<long>
{
public static readonly long[] Value=A133816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133816.Bytes);
public long this[int i]=>Value[i];

public static A133816Inst Instance=new A133816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133817
{
public static readonly long[] Value={ 15L,7L,8L,20L,21L,3L,6L,5L,10L,4L,3L,3L,9L,13L,2L,5L,12L,6L,3L,22L,13L,12L,17L,2L,2L,4L,5L,7L,7L,10L,22L,3L,22L,13L,12L,17L,2L,3L,14L,13L,4L,10L,14L,2L,5L,11L,13L,15L,7L,8L,20L,21L,3L,6L,8L,13L,4L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133817Inst : IEnumerable<long>
{
public static readonly long[] Value=A133817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133817.Bytes);
public long this[int i]=>Value[i];

public static A133817Inst Instance=new A133817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133818
{
public static readonly long[] Value={ 945L,36465L,229425L,801009L,2070705L,4456305L,8473905L,14737905L,23961009L,36954225L,54626865L,77986545L,108139185L,146289009L,193738545L,251888625L,322238385L,406385265L,506025009L,622951665L,759057585L,916333425L,1096868145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133818Inst : IEnumerable<long>
{
public static readonly long[] Value=A133818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133818.Bytes);
public long this[int i]=>Value[i];

public static A133818Inst Instance=new A133818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133819
{
public static readonly long[] Value={ 1L,1L,4L,1L,4L,9L,1L,4L,9L,16L,1L,4L,9L,16L,25L,1L,4L,9L,16L,25L,36L,1L,4L,9L,16L,25L,36L,49L,1L,4L,9L,16L,25L,36L,49L,64L,1L,4L,9L,16L,25L,36L,49L,64L,81L,1L,4L,9L,16L,25L,36L,49L,64L,81L,100L,1L,4L,9L,16L,25L,36L,49L,64L,81L,100L,121L,1L,4L,9L,16L,25L,36L,49L,64L,81L,100L,121L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133819Inst : IEnumerable<long>
{
public static readonly long[] Value=A133819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133819.Bytes);
public long this[int i]=>Value[i];

public static A133819Inst Instance=new A133819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133820
{
public static readonly long[] Value={ 1L,1L,8L,1L,8L,27L,1L,8L,27L,64L,1L,8L,27L,64L,125L,1L,8L,27L,64L,125L,216L,1L,8L,27L,64L,125L,216L,343L,1L,8L,27L,64L,125L,216L,343L,512L,1L,8L,27L,64L,125L,216L,343L,512L,729L,1L,8L,27L,64L,125L,216L,343L,512L,729L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133820Inst : IEnumerable<long>
{
public static readonly long[] Value=A133820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133820.Bytes);
public long this[int i]=>Value[i];

public static A133820Inst Instance=new A133820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133821
{
public static readonly long[] Value={ 1L,1L,16L,1L,16L,81L,1L,16L,81L,256L,1L,16L,81L,256L,625L,1L,16L,81L,256L,625L,1296L,1L,16L,81L,256L,625L,1296L,2401L,1L,16L,81L,256L,625L,1296L,2401L,4096L,1L,16L,81L,256L,625L,1296L,2401L,4096L,6561L,1L,16L,81L,256L,625L,1296L,2401L,4096L,6561L,10000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133821Inst : IEnumerable<long>
{
public static readonly long[] Value=A133821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133821.Bytes);
public long this[int i]=>Value[i];

public static A133821Inst Instance=new A133821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133822
{
public static readonly BigInteger[] Value={ 0L,1L,2L,6L,36L,360L,4542L,68544L,1226344L,25409664L,596628250L,15651680000L,453879958092L,14417575231488L,497825878940054L,18565202648401920L,743653004987969360L,BigInteger.Parse("31843195958676979712"),BigInteger.Parse("1451524546915205994162"),BigInteger.Parse("70176819912743307902976"),BigInteger.Parse("3586765354156262980637940") };
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
public class A133822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133822Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133822.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133822Inst Instance=new A133822Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133823
{
public static readonly long[] Value={ 1L,1L,8L,1L,1L,8L,27L,8L,1L,1L,8L,27L,64L,27L,8L,1L,1L,8L,27L,64L,125L,64L,27L,8L,1L,1L,8L,27L,64L,125L,216L,125L,64L,27L,8L,1L,1L,8L,27L,64L,125L,216L,343L,216L,125L,64L,27L,8L,1L,1L,8L,27L,64L,125L,216L,343L,512L,343L,216L,125L,64L,27L,8L,1L,1L,8L,27L,64L,125L,216L,343L,512L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133823Inst : IEnumerable<long>
{
public static readonly long[] Value=A133823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133823.Bytes);
public long this[int i]=>Value[i];

public static A133823Inst Instance=new A133823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133824
{
public static readonly long[] Value={ 1L,1L,16L,1L,1L,16L,81L,16L,1L,1L,16L,81L,256L,81L,16L,1L,1L,16L,81L,256L,625L,256L,81L,16L,1L,1L,16L,81L,256L,625L,1296L,625L,256L,81L,16L,1L,1L,16L,81L,256L,625L,1296L,2401L,1296L,625L,256L,81L,16L,1L,1L,16L,81L,256L,625L,1296L,2401L,4096L,2401L,1296L,625L,256L,81L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133824Inst : IEnumerable<long>
{
public static readonly long[] Value=A133824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133824.Bytes);
public long this[int i]=>Value[i];

public static A133824Inst Instance=new A133824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133825
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,6L,3L,1L,1L,3L,6L,10L,6L,3L,1L,1L,3L,6L,10L,15L,10L,6L,3L,1L,1L,3L,6L,10L,15L,21L,15L,10L,6L,3L,1L,1L,3L,6L,10L,15L,21L,28L,21L,15L,10L,6L,3L,1L,1L,3L,6L,10L,15L,21L,28L,36L,28L,21L,15L,10L,6L,3L,1L,1L,3L,6L,10L,15L,21L,28L,36L,45L,36L,28L,21L,15L,10L,6L,3L,1L,1L,3L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133825Inst : IEnumerable<long>
{
public static readonly long[] Value=A133825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133825.Bytes);
public long this[int i]=>Value[i];

public static A133825Inst Instance=new A133825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133826
{
public static readonly long[] Value={ 1L,1L,4L,1L,1L,4L,10L,4L,1L,1L,4L,10L,20L,10L,4L,1L,1L,4L,10L,20L,35L,20L,10L,4L,1L,1L,4L,10L,20L,35L,56L,35L,20L,10L,4L,1L,1L,4L,10L,20L,35L,56L,84L,56L,35L,20L,10L,4L,1L,1L,4L,10L,20L,35L,56L,84L,120L,84L,56L,35L,20L,10L,4L,1L,1L,4L,10L,20L,35L,56L,84L,120L,165L,120L,84L,56L,35L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133826Inst : IEnumerable<long>
{
public static readonly long[] Value=A133826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133826.Bytes);
public long this[int i]=>Value[i];

public static A133826Inst Instance=new A133826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133827
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,2L,0L,0L,0L,0L,0L,2L,1L,0L,2L,0L,0L,0L,2L,0L,0L,2L,0L,0L,1L,0L,2L,0L,0L,0L,0L,1L,0L,2L,0L,2L,0L,0L,2L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,2L,0L,2L,0L,0L,0L,3L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133827Inst : IEnumerable<long>
{
public static readonly long[] Value=A133827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133827.Bytes);
public long this[int i]=>Value[i];

public static A133827Inst Instance=new A133827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133828
{
public static readonly long[] Value={ 1L,0L,1L,4L,1L,6L,1L,4L,1L,5L,1L,6L,1L,7L,1L,4L,1L,6L,1L,10L,1L,11L,1L,6L,1L,13L,1L,4L,1L,10L,1L,4L,1L,17L,1L,6L,1L,19L,1L,8L,1L,14L,1L,4L,1L,23L,1L,6L,1L,5L,1L,4L,1L,6L,1L,4L,1L,29L,1L,10L,1L,31L,1L,4L,1L,6L,1L,4L,1L,5L,1L,6L,1L,37L,1L,4L,1L,6L,1L,8L,1L,41L,1L,12L,1L,43L,1L,4L,1L,15L,1L,4L,1L,47L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133828Inst : IEnumerable<long>
{
public static readonly long[] Value=A133828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133828.Bytes);
public long this[int i]=>Value[i];

public static A133828Inst Instance=new A133828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133829
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,4L,2L,2L,3L,5L,2L,4L,2L,2L,6L,2L,2L,4L,2L,5L,7L,2L,2L,4L,2L,2L,3L,8L,2L,6L,2L,2L,3L,2L,2L,9L,2L,2L,3L,5L,2L,7L,2L,2L,10L,2L,2L,4L,2L,5L,3L,2L,2L,4L,11L,8L,3L,2L,2L,6L,2L,2L,7L,2L,2L,12L,2L,2L,3L,5L,2L,9L,2L,2L,6L,2L,2L,13L,2L,5L,3L,2L,2L,8L,2L,2L,3L,2L,2L,10L,14L,2L,3L,2L,2L,4L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133829Inst : IEnumerable<long>
{
public static readonly long[] Value=A133829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133829.Bytes);
public long this[int i]=>Value[i];

public static A133829Inst Instance=new A133829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133830
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,0L,3L,3L,2L,1L,4L,5L,1L,1L,11L,1L,6L,5L,4L,7L,3L,9L,0L,17L,15L,1L,15L,1L,6L,0L,4L,9L,14L,13L,3L,11L,25L,0L,6L,7L,0L,17L,7L,15L,2L,0L,30L,23L,6L,21L,2L,33L,1L,0L,3L,0L,14L,5L,6L,21L,19L,0L,30L,3L,1L,5L,34L,19L,26L,17L,19L,17L,5L,33L,15L,23L,27L,33L,4L,3L,26L,1L,39L,35L,19L,9L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133830Inst : IEnumerable<long>
{
public static readonly long[] Value=A133830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133830.Bytes);
public long this[int i]=>Value[i];

public static A133830Inst Instance=new A133830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133831
{
public static readonly long[] Value={ 2L,1L,1L,1L,2L,1L,1L,9L,3L,3L,2L,1L,4L,5L,1L,1L,11L,1L,6L,5L,4L,7L,3L,9L,27L,17L,15L,1L,15L,1L,6L,458465L,4L,9L,14L,13L,3L,11L,25L,57L,6L,7L,46L,17L,7L,15L,2L,1009L,30L,23L,6L,21L,2L,33L,1L,1265L,3L,69L,14L,5L,6L,21L,19L,2241L,30L,3L,1L,5L,34L,19L,26L,17L,19L,17L,5L,33L,15L,23L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133831Inst : IEnumerable<long>
{
public static readonly long[] Value=A133831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133831.Bytes);
public long this[int i]=>Value[i];

public static A133831Inst Instance=new A133831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133848
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,5L,7L,9L,11L,15L,23L,35L,51L,71L,239L,411L,587L,767L,951L,1325L,2075L,3201L,4703L,6581L,22185L,38165L,54521L,71253L,88361L,123141L,192889L,297605L,437289L,611941L,2062927L,3548881L,5069803L,6625693L,8216551L,11450719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133848Inst : IEnumerable<long>
{
public static readonly long[] Value=A133848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133848.Bytes);
public long this[int i]=>Value[i];

public static A133848Inst Instance=new A133848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133849
{
public static readonly BigInteger[] Value={ BigInteger.Parse("20169691981106018776756331"),33426748355L,5391411025L,26957055125L,134785275625L,673926378125L,3369631890625L,16848159453125L,84240797265625L,421203986328125L,2106019931640625L,10530099658203125L,52650498291015625L,263252491455078125L,1316262457275390625L,6581312286376953125L };
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
public class A133849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133849Inst Instance=new A133849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133850
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,2L,3L,5L,3L,5L,3L,6L,7L,8L,4L,8L,6L,10L,8L,10L,7L,14L,10L,16L,12L,14L,9L,16L,14L,17L,12L,17L,16L,25L,15L,20L,20L,23L,20L,25L,20L,28L,22L,25L,23L,30L,23L,31L,28L,33L,28L,35L,32L,36L,30L,33L,32L,44L,35L,34L,37L,42L,43L,49L,39L,42L,42L,44L,49L,49L,40L,45L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133850Inst : IEnumerable<long>
{
public static readonly long[] Value=A133850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133850.Bytes);
public long this[int i]=>Value[i];

public static A133850Inst Instance=new A133850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133851
{
public static readonly long[] Value={ 1L,0L,0L,4L,0L,0L,16L,0L,0L,64L,0L,0L,256L,0L,0L,1024L,0L,0L,4096L,0L,0L,16384L,0L,0L,65536L,0L,0L,262144L,0L,0L,1048576L,0L,0L,4194304L,0L,0L,16777216L,0L,0L,67108864L,0L,0L,268435456L,0L,0L,1073741824L,0L,0L,4294967296L,0L,0L,17179869184L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133851Inst : IEnumerable<long>
{
public static readonly long[] Value=A133851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133851.Bytes);
public long this[int i]=>Value[i];

public static A133851Inst Instance=new A133851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133852
{
public static readonly long[] Value={ -2L,-3L,-4L,-4L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133852Inst : IEnumerable<long>
{
public static readonly long[] Value=A133852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133852.Bytes);
public long this[int i]=>Value[i];

public static A133852Inst Instance=new A133852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133853
{
public static readonly BigInteger[] Value={ 0L,1L,65L,4161L,266305L,17043521L,1090785345L,69810262081L,4467856773185L,285942833483841L,18300341342965825L,1171221845949812801L,BigInteger.Parse("74958198140788019265"),BigInteger.Parse("4797324681010433232961"),BigInteger.Parse("307028779584667726909505"),BigInteger.Parse("19649841893418734522208321") };
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
public class A133853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133853Inst Instance=new A133853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133854
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,5L,7L,9L,11L,13L,17L,25L,37L,53L,73L,97L,321L,549L,781L,1017L,1257L,1501L,1995L,2985L,4471L,6453L,8931L,11905L,39433L,67457L,95977L,124993L,154505L,184513L,245273L,367041L,549817L,793601L,1098393L,1464193L,4849891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133854Inst : IEnumerable<long>
{
public static readonly long[] Value=A133854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133854.Bytes);
public long this[int i]=>Value[i];

public static A133854Inst Instance=new A133854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133855
{
public static readonly long[] Value={ 19L,41L,71L,79L,89L,101L,103L,113L,139L,197L,199L,223L,271L,281L,307L,349L,353L,367L,379L,401L,439L,449L,461L,463L,491L,499L,521L,571L,607L,617L,619L,641L,643L,701L,727L,739L,761L,769L,811L,821L,859L,881L,911L,919L,929L,941L,953L,967L,991L,1039L,1061L,1063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133855Inst : IEnumerable<long>
{
public static readonly long[] Value=A133855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133855.Bytes);
public long this[int i]=>Value[i];

public static A133855Inst Instance=new A133855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133856
{
public static readonly long[] Value={ 0L,4L,14L,8L,11L,22420L,78L,17L,24L,20L,25L,24L,63L,30L,42L,69L,128L,50L,119L,204L,2816L,76L,52L,288L,64L,66L,184L,153L,67L,268L,78L,210L,438L,295L,96L,74L,136L,128L,2900L,1898L,130L,92L,381L,106L,18626L,97L,98L,1650L,747L,109L,214L,113L,312L,354L,1702L,560L,2798L,123L,171L,554L,11210L,834L,208L,990L,9271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133856Inst : IEnumerable<long>
{
public static readonly long[] Value=A133856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133856.Bytes);
public long this[int i]=>Value[i];

public static A133856Inst Instance=new A133856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133857
{
public static readonly long[] Value={ 2L,25667L,28807L,142031L,157051L,180181L,414269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133857Inst : IEnumerable<long>
{
public static readonly long[] Value=A133857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133857.Bytes);
public long this[int i]=>Value[i];

public static A133857Inst Instance=new A133857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133858
{
public static readonly long[] Value={ 14639L,1771559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133858Inst : IEnumerable<long>
{
public static readonly long[] Value=A133858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133858.Bytes);
public long this[int i]=>Value[i];

public static A133858Inst Instance=new A133858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133859
{
public static readonly long[] Value={ 7681L,39367L,7812499L,135967277L,4715895383L,822557039L,48718117843L,513127081109L,147534349327L,21203414421907L,52879244321341L,15069267560119L,798099274499279L,164129642266943L,1740228634955257L,149381307185023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133859Inst : IEnumerable<long>
{
public static readonly long[] Value=A133859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133859.Bytes);
public long this[int i]=>Value[i];

public static A133859Inst Instance=new A133859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133860
{
public static readonly long[] Value={ 12289L,472391L,78124999L,135967277L,24262286441L,38050596989L,5498076927457L,8388044818849L,30794280412669L,45941644105613L,1205285836084793L,7909086479714171L,1438991183761177L,47101607991825047L,18067554193458689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133860Inst : IEnumerable<long>
{
public static readonly long[] Value=A133860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133860.Bytes);
public long this[int i]=>Value[i];

public static A133860Inst Instance=new A133860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133861
{
public static readonly long[] Value={ 12289L,1062881L,292968749L,7909306973L,1194631280321L,2395794301259L,38413406256881L,77460384757423L,30794280412669L,4161130688896397L,3748333074529501L,240404931594746129L,191828075390557213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133861Inst : IEnumerable<long>
{
public static readonly long[] Value=A133861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133861.Bytes);
public long this[int i]=>Value[i];

public static A133861Inst Instance=new A133861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133862
{
public static readonly ulong[] Value={ 12289L,1062881L,853235443L,92233439147L,3143820659087L,58713568184837L,2359162908109223L,2649283656602003L,53928980532177631L,557792163777408809L,2084452633098194627L,8958368398788306367L,15810453676175767201UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133862Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A133862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133862.Bytes);
public ulong this[int i]=>Value[i];

public static A133862Inst Instance=new A133862Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133863
{
public static readonly BigInteger[] Value={ 40961L,19131877L,2441406251L,115385868869L,138090848575723L,358661570404751L,44510586506850631L,252317900773542353L,4465433274456775633L,BigInteger.Parse("39171440762351329829"),11887418854442931407UL,14582408526413537791UL };
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
public class A133863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133863.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133863Inst Instance=new A133863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133896
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,12L,13L,14L,15L,21L,22L,23L,26L,30L,31L,34L,35L,39L,42L,43L,44L,50L,51L,52L,53L,58L,59L,60L,61L,62L,66L,67L,68L,69L,70L,71L,75L,76L,77L,78L,79L,84L,85L,86L,87L,93L,94L,95L,98L,102L,103L,106L,107L,111L,114L,115L,116L,122L,123L,124L,125L,130L,131L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133896Inst : IEnumerable<long>
{
public static readonly long[] Value=A133896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133896.Bytes);
public long this[int i]=>Value[i];

public static A133896Inst Instance=new A133896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133897
{
public static readonly long[] Value={ 42L,43L,44L,45L,46L,47L,48L,91L,92L,93L,94L,95L,96L,97L,140L,141L,142L,143L,144L,145L,146L,189L,190L,191L,192L,193L,194L,195L,238L,239L,240L,241L,242L,243L,244L,287L,288L,289L,290L,291L,292L,293L,336L,337L,338L,339L,340L,341L,342L,385L,386L,387L,388L,389L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133897Inst : IEnumerable<long>
{
public static readonly long[] Value=A133897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133897.Bytes);
public long this[int i]=>Value[i];

public static A133897Inst Instance=new A133897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133898
{
public static readonly long[] Value={ 56L,57L,58L,59L,60L,61L,62L,63L,120L,121L,122L,123L,124L,125L,126L,127L,184L,185L,186L,187L,188L,189L,190L,191L,248L,249L,250L,251L,252L,253L,254L,255L,312L,313L,314L,315L,316L,317L,318L,319L,376L,377L,378L,379L,380L,381L,382L,383L,440L,441L,442L,443L,444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133898Inst : IEnumerable<long>
{
public static readonly long[] Value=A133898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133898.Bytes);
public long this[int i]=>Value[i];

public static A133898Inst Instance=new A133898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133899
{
public static readonly long[] Value={ 72L,73L,74L,75L,76L,77L,78L,79L,80L,153L,154L,155L,156L,157L,158L,159L,160L,161L,234L,235L,236L,237L,238L,239L,240L,241L,242L,315L,316L,317L,318L,319L,320L,321L,322L,323L,396L,397L,398L,399L,400L,401L,402L,403L,404L,477L,478L,479L,480L,481L,482L,483L,484L,485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133899Inst : IEnumerable<long>
{
public static readonly long[] Value=A133899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133899.Bytes);
public long this[int i]=>Value[i];

public static A133899Inst Instance=new A133899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133900
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,72L,49L,64L,81L,400L,121L,864L,169L,784L,675L,256L,289L,2592L,361L,1600L,1323L,3872L,529L,3456L,625L,5408L,729L,3136L,841L,324000L,961L,1024L,9801L,18496L,6125L,31104L,1369L,23104L,13689L,32000L,1681L,254016L,1849L,15488L,30375L,33856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133900Inst : IEnumerable<long>
{
public static readonly long[] Value=A133900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133900.Bytes);
public long this[int i]=>Value[i];

public static A133900Inst Instance=new A133900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133901
{
public static readonly long[] Value={ 33L,99L,1119111L,10110901101L,11110901111L,101109901101L,1011109011101L,1110109010111L,10111099011101L,100110090011001L,100111090111001L,101011090110101L,111001090100111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133901Inst : IEnumerable<long>
{
public static readonly long[] Value=A133901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133901.Bytes);
public long this[int i]=>Value[i];

public static A133901Inst Instance=new A133901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133902
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,2L,1L,2L,1L,3L,12L,24L,2L,4L,2L,8L,1L,2L,1L,2L,1L,4L,2L,4L,1L,3L,12L,48L,12L,24L,12L,24L,3L,1L,4L,16L,4L,8L,4L,16L,2L,4L,2L,4L,1L,6L,3L,6L,1L,3L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133902Inst : IEnumerable<long>
{
public static readonly long[] Value=A133902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133902.Bytes);
public long this[int i]=>Value[i];

public static A133902Inst Instance=new A133902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133903
{
public static readonly long[] Value={ 1L,2L,4L,6L,2L,4L,8L,10L,14L,17L,21L,7L,13L,15L,5L,9L,3L,1L,7L,9L,3L,1L,5L,7L,13L,16L,20L,24L,8L,10L,18L,6L,2L,6L,2L,6L,2L,4L,8L,12L,4L,6L,2L,4L,8L,14L,18L,6L,2L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133903Inst : IEnumerable<long>
{
public static readonly long[] Value=A133903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133903.Bytes);
public long this[int i]=>Value[i];

public static A133903Inst Instance=new A133903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133904
{
public static readonly long[] Value={ 1L,2L,1L,3L,6L,3L,13L,15L,19L,22L,11L,123L,375L,377L,381L,1147L,1152L,576L,288L,144L,72L,36L,18L,9L,17L,20L,10L,5L,11L,13L,21L,23L,29L,33L,37L,41L,50L,25L,29L,33L,41L,1683L,5055L,5057L,5063L,5069L,5073L,5075L,5085L,5088L,2544L,1272L,636L,368L,184L,92L,46L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133904Inst : IEnumerable<long>
{
public static readonly long[] Value=A133904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133904.Bytes);
public long this[int i]=>Value[i];

public static A133904Inst Instance=new A133904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133905
{
public static readonly long[] Value={ 4L,9L,25L,10L,26L,9L,9L,9L,6L,4L,4L,34L,34L,85L,289L,4L,4L,57L,87L,8L,8L,25L,25L,25L,134L,4L,4L,15L,15L,111L,111L,4L,4L,8L,8L,10L,10L,121L,121L,82L,86L,4L,4L,49L,49L,49L,49L,4L,4L,265L,68L,10L,10L,8L,8L,6L,9L,4L,4L,194L,194L,469L,249L,4L,4L,44L,44L,146L,146L,16L,16L,6L,6L,4L,4L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133905Inst : IEnumerable<long>
{
public static readonly long[] Value=A133905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133905.Bytes);
public long this[int i]=>Value[i];

public static A133905Inst Instance=new A133905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133906
{
public static readonly long[] Value={ 2L,3L,5L,2L,2L,7L,9L,2L,2L,3L,3L,2L,2L,17L,17L,2L,2L,3L,3L,2L,2L,23L,25L,2L,2L,4L,3L,2L,2L,31L,37L,2L,2L,8L,8L,2L,2L,3L,41L,2L,2L,4L,4L,2L,2L,3L,3L,2L,2L,5L,5L,2L,2L,3L,3L,2L,2L,4L,4L,2L,2L,67L,3L,2L,2L,44L,44L,2L,2L,16L,16L,2L,2L,3L,4L,2L,2L,5L,5L,2L,2L,3L,3L,2L,2L,89L,9L,2L,2L,3L,3L,2L,2L,97L,97L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133906Inst : IEnumerable<long>
{
public static readonly long[] Value=A133906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133906.Bytes);
public long this[int i]=>Value[i];

public static A133906Inst Instance=new A133906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133907
{
public static readonly long[] Value={ 2L,3L,5L,2L,2L,7L,11L,2L,2L,3L,3L,2L,2L,17L,17L,2L,2L,3L,3L,2L,2L,23L,29L,2L,2L,5L,3L,2L,2L,31L,37L,2L,2L,37L,37L,2L,2L,3L,41L,2L,2L,43L,47L,2L,2L,3L,3L,2L,2L,5L,5L,2L,2L,3L,3L,2L,2L,59L,61L,2L,2L,67L,3L,2L,2L,67L,71L,2L,2L,71L,73L,2L,2L,3L,5L,2L,2L,5L,5L,2L,2L,3L,3L,2L,2L,89L,89L,2L,2L,3L,3L,2L,2L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133907Inst : IEnumerable<long>
{
public static readonly long[] Value=A133907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133907.Bytes);
public long this[int i]=>Value[i];

public static A133907Inst Instance=new A133907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133908
{
public static readonly long[] Value={ 3L,3L,5L,5L,7L,7L,11L,11L,3L,3L,3L,13L,17L,17L,17L,17L,19L,3L,3L,3L,23L,23L,29L,29L,5L,5L,3L,3L,3L,31L,37L,37L,37L,37L,37L,3L,3L,3L,41L,41L,43L,43L,47L,47L,3L,3L,3L,53L,7L,5L,5L,5L,5L,3L,3L,3L,59L,59L,61L,61L,67L,67L,3L,3L,3L,67L,71L,71L,71L,71L,73L,3L,3L,3L,5L,5L,5L,5L,5L,83L,3L,3L,3L,89L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133908Inst : IEnumerable<long>
{
public static readonly long[] Value=A133908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133908.Bytes);
public long this[int i]=>Value[i];

public static A133908Inst Instance=new A133908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133909
{
public static readonly long[] Value={ 3L,3L,5L,5L,7L,7L,9L,9L,3L,3L,3L,13L,17L,17L,17L,17L,19L,3L,3L,3L,23L,23L,25L,25L,5L,5L,3L,3L,3L,31L,37L,37L,37L,37L,37L,3L,3L,3L,41L,41L,43L,43L,47L,47L,3L,3L,3L,49L,7L,5L,5L,5L,5L,3L,3L,3L,9L,9L,9L,61L,67L,67L,3L,3L,3L,67L,71L,71L,71L,71L,73L,3L,3L,3L,5L,5L,5L,5L,5L,83L,3L,3L,3L,89L,89L,89L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133909Inst : IEnumerable<long>
{
public static readonly long[] Value=A133909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133909.Bytes);
public long this[int i]=>Value[i];

public static A133909Inst Instance=new A133909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133910
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,4L,1L,6L,1L,4L,3L,1L,1L,8L,1L,4L,3L,8L,1L,6L,1L,8L,1L,4L,1L,360L,1L,1L,9L,16L,5L,24L,1L,16L,9L,20L,1L,144L,1L,8L,15L,16L,1L,18L,1L,16L,9L,8L,1L,16L,5L,28L,9L,16L,1L,360L,1L,16L,21L,1L,5L,288L,1L,16L,9L,1120L,1L,24L,1L,32L,9L,16L,7L,288L,1L,20L,1L,64L,1L,6048L,5L,32L,27L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133910Inst : IEnumerable<long>
{
public static readonly long[] Value=A133910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133910.Bytes);
public long this[int i]=>Value[i];

public static A133910Inst Instance=new A133910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133911
{
public static readonly long[] Value={ 0L,2L,2L,4L,2L,5L,2L,6L,4L,6L,2L,8L,2L,6L,5L,8L,2L,9L,2L,8L,5L,7L,2L,10L,4L,7L,6L,8L,2L,12L,2L,10L,6L,8L,5L,12L,2L,8L,6L,11L,2L,12L,2L,9L,8L,8L,2L,13L,4L,10L,6L,9L,2L,12L,5L,11L,6L,8L,2L,14L,2L,8L,8L,12L,5L,13L,2L,10L,6L,13L,2L,14L,2L,9L,8L,10L,5L,13L,2L,13L,8L,10L,2L,17L,5L,9L,7L,11L,2L,16L,5L,10L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133911Inst : IEnumerable<long>
{
public static readonly long[] Value=A133911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133911.Bytes);
public long this[int i]=>Value[i];

public static A133911Inst Instance=new A133911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134008
{
public static readonly long[] Value={ 6L,36L,286L,2556L,24310L,240276L,2437006L,25173996L,263567590L,2787694596L,29716508926L,318719062236L,3434943872470L,37162689280116L,403310957409646L,4387917394947276L,47836135613930950L,522357603781540836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134008Inst : IEnumerable<long>
{
public static readonly long[] Value=A134008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134008.Bytes);
public long this[int i]=>Value[i];

public static A134008Inst Instance=new A134008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134009
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,16L,28L,48L,83L,144L,249L,431L,747L,1294L,2241L,3882L,6724L,11646L,20171L,34937L,60513L,104812L,181540L,314437L,544621L,943311L,1633863L,2829934L,4901589L,8489801L,14704767L,25469404L,44114302L,76408212L,132342905L,229224635L,397028714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134009Inst : IEnumerable<long>
{
public static readonly long[] Value=A134009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134009.Bytes);
public long this[int i]=>Value[i];

public static A134009Inst Instance=new A134009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134010
{
public static readonly long[] Value={ 1L,1L,4L,27L,256L,3125L,46656L,823543L,16777216L,387420489L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,400L,441L,484L,529L,576L,625L,676L,729L,784L,841L,27000L,29791L,32768L,35937L,39304L,42875L,46656L,50653L,54872L,59319L,2560000L,2825761L,3111696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134010Inst : IEnumerable<long>
{
public static readonly long[] Value=A134010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134010.Bytes);
public long this[int i]=>Value[i];

public static A134010Inst Instance=new A134010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134011
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134011Inst : IEnumerable<long>
{
public static readonly long[] Value=A134011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134011.Bytes);
public long this[int i]=>Value[i];

public static A134011Inst Instance=new A134011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134012
{
public static readonly long[] Value={ 1L,6L,11L,6L,1L,1L,6L,11L,6L,1L,1L,6L,11L,6L,1L,1L,6L,11L,6L,1L,1L,6L,11L,6L,1L,1L,6L,11L,6L,1L,1L,6L,11L,6L,1L,1L,6L,11L,6L,1L,1L,6L,11L,6L,1L,1L,6L,11L,6L,1L,1L,6L,11L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134012Inst : IEnumerable<long>
{
public static readonly long[] Value=A134012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134012.Bytes);
public long this[int i]=>Value[i];

public static A134012Inst Instance=new A134012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134013
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,0L,0L,1L,4L,0L,0L,2L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,3L,4L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,1L,6L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,2L,4L,0L,0L,0L,0L,0L,0L,1L,4L,0L,0L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134013Inst : IEnumerable<long>
{
public static readonly long[] Value=A134013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134013.Bytes);
public long this[int i]=>Value[i];

public static A134013Inst Instance=new A134013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134014
{
public static readonly long[] Value={ 1L,-2L,0L,0L,4L,-4L,0L,0L,4L,-2L,0L,0L,0L,-4L,0L,0L,4L,-4L,0L,0L,8L,0L,0L,0L,0L,-6L,0L,0L,0L,-4L,0L,0L,4L,0L,0L,0L,4L,-4L,0L,0L,8L,-4L,0L,0L,0L,-4L,0L,0L,0L,-2L,0L,0L,8L,-4L,0L,0L,0L,0L,0L,0L,0L,-4L,0L,0L,4L,-8L,0L,0L,8L,0L,0L,0L,4L,-4L,0L,0L,0L,0L,0L,0L,8L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134014Inst : IEnumerable<long>
{
public static readonly long[] Value=A134014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134014.Bytes);
public long this[int i]=>Value[i];

public static A134014Inst Instance=new A134014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134015
{
public static readonly long[] Value={ 1L,0L,0L,-2L,2L,0L,0L,-2L,1L,0L,0L,0L,2L,0L,0L,-2L,2L,0L,0L,-4L,0L,0L,0L,0L,3L,0L,0L,0L,2L,0L,0L,-2L,0L,0L,0L,-2L,2L,0L,0L,-4L,2L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,-4L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,-2L,4L,0L,0L,-4L,0L,0L,0L,-2L,2L,0L,0L,0L,0L,0L,0L,-4L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134015Inst : IEnumerable<long>
{
public static readonly long[] Value=A134015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134015.Bytes);
public long this[int i]=>Value[i];

public static A134015Inst Instance=new A134015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134016
{
public static readonly long[] Value={ 2L,6L,10L,23L,42L,98L,178L,415L,754L,1758L,3194L,7447L,13530L,31546L,57314L,133631L,242786L,566070L,1028458L,2397911L,4356618L,10157714L,18454930L,43028767L,78176338L,182272782L,331160282L,772119895L,1402817466L,3270752362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134016Inst : IEnumerable<long>
{
public static readonly long[] Value=A134016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134016.Bytes);
public long this[int i]=>Value[i];

public static A134016Inst Instance=new A134016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134017
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,3L,4L,2L,1L,1L,2L,4L,3L,5L,3L,4L,2L,1L,1L,2L,4L,3L,5L,3L,4L,2L,1L,1L,2L,4L,3L,5L,3L,4L,2L,1L,1L,2L,4L,3L,5L,3L,4L,2L,1L,1L,2L,4L,3L,5L,3L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134017Inst : IEnumerable<long>
{
public static readonly long[] Value=A134017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134017.Bytes);
public long this[int i]=>Value[i];

public static A134017Inst Instance=new A134017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134018
{
public static readonly long[] Value={ 0L,1L,3L,10L,45L,226L,1113L,5230L,23565L,102826L,438273L,1836550L,7601685L,31183426L,127084233L,515429470L,2083077405L,8396552026L,33779262993L,135696871990L,544528258725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134018Inst : IEnumerable<long>
{
public static readonly long[] Value=A134018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134018.Bytes);
public long this[int i]=>Value[i];

public static A134018Inst Instance=new A134018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134019
{
public static readonly long[] Value={ 1L,2L,4L,11L,46L,227L,1114L,5231L,23566L,102827L,438274L,1836551L,7601686L,31183427L,127084234L,515429471L,2083077406L,8396552027L,33779262994L,135696871991L,544528258726L,2183337968627L,8749031918554L,35043178292111L,140313885993646L,561679104393227L,2247987182714914L,8995761194057831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134019Inst : IEnumerable<long>
{
public static readonly long[] Value=A134019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134019.Bytes);
public long this[int i]=>Value[i];

public static A134019Inst Instance=new A134019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134020
{
public static readonly long[] Value={ 8L,15L,35L,143L,323L,899L,1763L,3599L,5183L,10403L,11663L,19043L,22499L,32399L,36863L,39203L,51983L,57599L,72899L,79523L,97343L,121103L,176399L,186623L,213443L,272483L,324899L,359999L,381923L,412163L,435599L,656099L,675683L,685583L,736163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134020Inst : IEnumerable<long>
{
public static readonly long[] Value=A134020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134020.Bytes);
public long this[int i]=>Value[i];

public static A134020Inst Instance=new A134020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134021
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134021Inst : IEnumerable<long>
{
public static readonly long[] Value=A134021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134021.Bytes);
public long this[int i]=>Value[i];

public static A134021Inst Instance=new A134021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134022
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,1L,1L,1L,0L,0L,1L,0L,0L,3L,2L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,0L,0L,1L,0L,0L,2L,1L,1L,1L,0L,0L,1L,0L,0L,4L,3L,3L,3L,2L,2L,3L,2L,2L,3L,2L,2L,2L,1L,1L,2L,1L,1L,3L,2L,2L,2L,1L,1L,2L,1L,1L,3L,2L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,0L,0L,1L,0L,0L,2L,1L,1L,1L,0L,0L,1L,0L,0L,3L,2L,2L,2L,1L,1L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134022Inst : IEnumerable<long>
{
public static readonly long[] Value=A134022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134022.Bytes);
public long this[int i]=>Value[i];

public static A134022Inst Instance=new A134022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134023
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,1L,2L,1L,0L,1L,0L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,4L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134023Inst : IEnumerable<long>
{
public static readonly long[] Value=A134023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134023.Bytes);
public long this[int i]=>Value[i];

public static A134023Inst Instance=new A134023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134232
{
public static readonly long[] Value={ 1L,2L,2L,3L,7L,3L,4L,15L,14L,4L,5L,26L,38L,23L,5L,6L,40L,80L,75L,34L,6L,7L,57L,145L,185L,129L,47L,7L,8L,77L,238L,385L,364L,203L,62L,8L,0L,9L,100L,364L,714L,854L,644L,300L,79L,9L,10L,126L,528L,1218L,1764L,1680L,1056L,423L,98L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134232Inst : IEnumerable<long>
{
public static readonly long[] Value=A134232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134232.Bytes);
public long this[int i]=>Value[i];

public static A134232Inst Instance=new A134232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134233
{
public static readonly long[] Value={ 1L,5L,1L,9L,10L,1L,13L,27L,15L,1L,17L,52L,54L,20L,1L,21L,85L,130L,90L,25L,25L,126L,255L,260L,135L,30L,1L,29L,175L,441L,595L,455L,189L,35L,33L,232L,700L,1176L,1190L,728L,252L,40L,1L,37L,297L,1044L,2100L,2646L,2142L,1092L,324L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134233Inst : IEnumerable<long>
{
public static readonly long[] Value=A134233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134233.Bytes);
public long this[int i]=>Value[i];

public static A134233Inst Instance=new A134233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134234
{
public static readonly long[] Value={ 1L,4L,1L,6L,8L,1L,8L,10L,12L,1L,10L,12L,14L,16L,1L,12L,14L,16L,18L,20L,1L,14L,16L,18L,20L,22L,24L,1L,16L,18L,20L,22L,24L,26L,28L,1L,18L,20L,22L,24L,26L,28L,30L,32L,1L,20L,22L,24L,26L,28L,30L,32L,34L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134234Inst : IEnumerable<long>
{
public static readonly long[] Value=A134234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134234.Bytes);
public long this[int i]=>Value[i];

public static A134234Inst Instance=new A134234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134235
{
public static readonly long[] Value={ 1L,4L,2L,5L,7L,3L,6L,8L,10L,4L,7L,9L,11L,13L,5L,8L,10L,12L,14L,16L,6L,9L,11L,13L,15L,17L,19L,7L,10L,12L,14L,16L,18L,20L,22L,8L,11L,13L,15L,17L,19L,21L,23L,25L,9L,12L,14L,16L,18L,20L,22L,24L,26L,28L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134235Inst : IEnumerable<long>
{
public static readonly long[] Value=A134235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134235.Bytes);
public long this[int i]=>Value[i];

public static A134235Inst Instance=new A134235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134236
{
public static readonly long[] Value={ 210L,210210L,212010L,212100L,221010L,221100L,210210210L,210212010L,210212100L,210221010L,210221100L,212010210L,212012010L,212012100L,212021010L,212021100L,212100210L,212102010L,212102100L,212120010L,212120100L,212121000L,212201010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134236Inst : IEnumerable<long>
{
public static readonly long[] Value=A134236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134236.Bytes);
public long this[int i]=>Value[i];

public static A134236Inst Instance=new A134236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134237
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,3L,7L,8L,9L,4L,9L,10L,11L,12L,5L,11L,12L,13L,14L,15L,6L,13L,14L,15L,16L,17L,18L,7L,15L,16L,17L,18L,19L,20L,21L,8L,17L,18L,19L,20L,21L,22L,23L,24L,9L,19L,20L,21L,22L,23L,24L,25L,26L,27L,10L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,11L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134237Inst : IEnumerable<long>
{
public static readonly long[] Value=A134237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134237.Bytes);
public long this[int i]=>Value[i];

public static A134237Inst Instance=new A134237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134238
{
public static readonly long[] Value={ 1L,5L,14L,28L,47L,71L,100L,134L,173L,217L,266L,320L,379L,443L,512L,586L,665L,749L,838L,932L,1031L,1135L,1244L,1358L,1477L,1601L,1730L,1864L,2003L,2147L,2296L,2450L,2609L,2773L,2942L,3116L,3295L,3479L,3668L,3862L,4061L,4265L,4474L,4688L,4907L,5131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134238Inst : IEnumerable<long>
{
public static readonly long[] Value=A134238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134238.Bytes);
public long this[int i]=>Value[i];

public static A134238Inst Instance=new A134238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134239
{
public static readonly long[] Value={ 1L,4L,2L,6L,9L,3L,8L,20L,16L,4L,10L,35L,45L,25L,5L,12L,54L,96L,84L,36L,6L,14L,77L,175L,210L,140L,49L,7L,16L,104L,288L,440L,400L,216L,64L,8L,18L,135L,441L,819L,945L,693L,315L,81L,9L,20L,170L,640L,1400L,1960L,1820L,1120L,440L,100L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134239Inst : IEnumerable<long>
{
public static readonly long[] Value=A134239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134239.Bytes);
public long this[int i]=>Value[i];

public static A134239Inst Instance=new A134239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134240
{
public static readonly long[] Value={ 79L,127L,163L,331L,379L,397L,439L,487L,499L,541L,673L,701L,739L,757L,769L,787L,907L,937L,947L,967L,977L,991L,1009L,1103L,1123L,1163L,1187L,1213L,1249L,1367L,1399L,1523L,1549L,1567L,1579L,1597L,1753L,1801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134240Inst : IEnumerable<long>
{
public static readonly long[] Value=A134240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134240.Bytes);
public long this[int i]=>Value[i];

public static A134240Inst Instance=new A134240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134241
{
public static readonly long[] Value={ 0L,0L,0L,384L,4800L,25920L,91200L,248640L,572544L,1169280L,2183040L,3801600L,6262080L,9856704L,14938560L,21927360L,31315200L,43672320L,59652864L,80000640L,105554880L,137256000L,176151360L,223401024L,280283520L,348201600L,428688000L,523411200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134241Inst : IEnumerable<long>
{
public static readonly long[] Value=A134241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134241.Bytes);
public long this[int i]=>Value[i];

public static A134241Inst Instance=new A134241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134242
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,-2L,11L,-3L,-11L,29L,493L,-2711L,-12406L,2636317L,-10597579L,-439018457L,1165403153L,118734633647L,-105428488301L,-4070802683898L,1695077946695371L,56532812889378221L,-252968859037883917L,BigInteger.Parse("-425882179787933647571"),BigInteger.Parse("123624959518930226565553"),BigInteger.Parse("32729394708071881944913"),BigInteger.Parse("-5814212300444136523052695") };
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
public class A134242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134242Inst Instance=new A134242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134243
{
public static readonly long[] Value={ 1L,2L,2L,3L,12L,4L,6L,4L,12L,6L,15L,60L,120L,60L,20L,60L,3L,5L,60L,120L,8L,1260L,2520L,168L,56L,168L,168L,840L,84L,840L,21L,140L,420L,630L,120L,280L,420L,840L,504L,2520L,840L,840L,315L,2520L,2520L,315L,84L,90L,30L,180L,360L,120L,120L,210L,24L,495L,1980L,2640L,55440L,315L,55440L,45L,2772L,6930L,27720L,9240L,770L,1848L,27720L,27720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134243Inst : IEnumerable<long>
{
public static readonly long[] Value=A134243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134243.Bytes);
public long this[int i]=>Value[i];

public static A134243Inst Instance=new A134243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134244
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,38L,47L,86L,108L,122L,322L,345L,446L,556L,665L,756L,1122L,1476L,4838L,6274L,10556L,12383L,38774L,42776L,46239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134244Inst : IEnumerable<long>
{
public static readonly long[] Value=A134244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134244.Bytes);
public long this[int i]=>Value[i];

public static A134244Inst Instance=new A134244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134245
{
public static readonly long[] Value={ 2L,8L,88L,384L,1056L,2310L,207936L,417219L,2978610L,6215400L,9216124L,205006774L,255230655L,576178034L,1157525280L,2038109955L,3053762208L,10584038058L,25042362120L,1025402527504L,2304427934330L,11623068703428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134245Inst : IEnumerable<long>
{
public static readonly long[] Value=A134245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134245.Bytes);
public long this[int i]=>Value[i];

public static A134245Inst Instance=new A134245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134246
{
public static readonly long[] Value={ 2L,4L,22L,64L,132L,231L,5472L,8877L,34635L,57550L,75542L,636667L,739799L,1291879L,2081880L,3064827L,4039368L,9433189L,16966370L,211947608L,367298045L,1101086463L,1541079585L,16915330550L,20775909209L,24450416187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134246Inst : IEnumerable<long>
{
public static readonly long[] Value=A134246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134246.Bytes);
public long this[int i]=>Value[i];

public static A134246Inst Instance=new A134246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134247
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,1L,4L,12L,9L,1L,5L,22L,30L,14L,1L,6L,35L,70L,60L,20L,1L,7L,51L,135L,170L,105L,27L,1L,8L,70L,231L,385L,350L,168L,35L,1L,9L,92L,364L,756L,910L,644L,252L,44L,1L,10L,117L,540L,1344L,2016L,1890L,1092L,360L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134247Inst : IEnumerable<long>
{
public static readonly long[] Value=A134247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134247.Bytes);
public long this[int i]=>Value[i];

public static A134247Inst Instance=new A134247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134696
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,10L,42L,48L,56L,66L,70L,86L,108L,126L,134L,214L,248L,459L,1479L,1722L,3076L,5064L,5102L,7602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134696Inst : IEnumerable<long>
{
public static readonly long[] Value=A134696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134696.Bytes);
public long this[int i]=>Value[i];

public static A134696Inst Instance=new A134696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134697
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,10L,11L,13L,14L,17L,22L,24L,27L,33L,38L,39L,41L,53L,54L,71L,76L,81L,83L,87L,91L,96L,99L,104L,124L,129L,142L,150L,266L,268L,311L,361L,408L,445L,512L,589L,694L,725L,750L,851L,874L,939L,954L,1110L,1153L,1417L,1755L,1816L,1830L,1966L,2149L,2308L,2561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134697Inst : IEnumerable<long>
{
public static readonly long[] Value=A134697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134697.Bytes);
public long this[int i]=>Value[i];

public static A134697Inst Instance=new A134697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134698
{
public static readonly long[] Value={ 32564L,232564L,256432L,322564L,325642L,325643L,325644L,325645L,325646L,325648L,325664L,332564L,432564L,532564L,632564L,643256L,832564L,2232564L,2256432L,2322564L,2325642L,2325643L,2325644L,2325645L,2325646L,2325648L,2325664L,2332564L,2432564L,2532564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134698Inst : IEnumerable<long>
{
public static readonly long[] Value=A134698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134698.Bytes);
public long this[int i]=>Value[i];

public static A134698Inst Instance=new A134698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134699
{
public static readonly long[] Value={ 1L,3L,1L,3L,1L,1L,6L,3L,1L,1L,3L,1L,1L,1L,1L,9L,5L,3L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,10L,6L,3L,3L,1L,1L,1L,1L,6L,3L,3L,1L,1L,1L,1L,1L,1L,9L,5L,3L,3L,3L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134699Inst : IEnumerable<long>
{
public static readonly long[] Value=A134699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134699.Bytes);
public long this[int i]=>Value[i];

public static A134699Inst Instance=new A134699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134700
{
public static readonly long[] Value={ 1L,3L,1L,5L,1L,1L,8L,3L,1L,1L,10L,3L,1L,1L,1L,14L,5L,3L,1L,1L,1L,16L,5L,3L,1L,1L,1L,1L,20L,8L,3L,3L,1L,1L,1L,1L,23L,8L,5L,3L,1L,1L,1L,1L,127L,10L,5L,3L,3L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134700Inst : IEnumerable<long>
{
public static readonly long[] Value=A134700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134700.Bytes);
public long this[int i]=>Value[i];

public static A134700Inst Instance=new A134700Inst();

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