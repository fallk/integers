using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040744
{
public static readonly long[] Value={ 27L,1L,3L,1L,1L,1L,5L,1L,1L,7L,2L,1L,1L,17L,1L,12L,1L,17L,1L,1L,2L,7L,1L,1L,5L,1L,1L,1L,3L,1L,54L,1L,3L,1L,1L,1L,5L,1L,1L,7L,2L,1L,1L,17L,1L,12L,1L,17L,1L,1L,2L,7L,1L,1L,5L,1L,1L,1L,3L,1L,54L,1L,3L,1L,1L,1L,5L,1L,1L,7L,2L,1L,1L,17L,1L,12L,1L,17L,1L,1L,2L,7L,1L,1L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040744Inst : IEnumerable<long>
{
public static readonly long[] Value=A040744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040744.Bytes);
public long this[int i]=>Value[i];

public static A040744Inst Instance=new A040744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040743
{
public static readonly long[] Value={ 27L,1L,3L,3L,2L,4L,1L,1L,1L,1L,2L,27L,2L,1L,1L,1L,1L,4L,2L,3L,3L,1L,54L,1L,3L,3L,2L,4L,1L,1L,1L,1L,2L,27L,2L,1L,1L,1L,1L,4L,2L,3L,3L,1L,54L,1L,3L,3L,2L,4L,1L,1L,1L,1L,2L,27L,2L,1L,1L,1L,1L,4L,2L,3L,3L,1L,54L,1L,3L,3L,2L,4L,1L,1L,1L,1L,2L,27L,2L,1L,1L,1L,1L,4L,2L,3L,3L,1L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040743Inst : IEnumerable<long>
{
public static readonly long[] Value=A040743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040743.Bytes);
public long this[int i]=>Value[i];

public static A040743Inst Instance=new A040743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040742
{
public static readonly long[] Value={ 27L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040742Inst : IEnumerable<long>
{
public static readonly long[] Value=A040742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040742.Bytes);
public long this[int i]=>Value[i];

public static A040742Inst Instance=new A040742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040741
{
public static readonly long[] Value={ 27L,1L,2L,1L,2L,1L,1L,17L,1L,10L,6L,1L,5L,3L,3L,2L,1L,1L,1L,1L,1L,1L,2L,3L,3L,5L,1L,6L,10L,1L,17L,1L,1L,2L,1L,2L,1L,54L,1L,2L,1L,2L,1L,1L,17L,1L,10L,6L,1L,5L,3L,3L,2L,1L,1L,1L,1L,1L,1L,2L,3L,3L,5L,1L,6L,10L,1L,17L,1L,1L,2L,1L,2L,1L,54L,1L,2L,1L,2L,1L,1L,17L,1L,10L,6L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040741Inst : IEnumerable<long>
{
public static readonly long[] Value=A040741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040741.Bytes);
public long this[int i]=>Value[i];

public static A040741Inst Instance=new A040741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040740
{
public static readonly long[] Value={ 27L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040740Inst : IEnumerable<long>
{
public static readonly long[] Value=A040740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040740.Bytes);
public long this[int i]=>Value[i];

public static A040740Inst Instance=new A040740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040739
{
public static readonly long[] Value={ 27L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040739Inst : IEnumerable<long>
{
public static readonly long[] Value=A040739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040739.Bytes);
public long this[int i]=>Value[i];

public static A040739Inst Instance=new A040739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040738
{
public static readonly long[] Value={ 27L,1L,2L,10L,1L,2L,1L,3L,1L,1L,17L,1L,8L,3L,1L,1L,2L,1L,2L,5L,5L,1L,26L,1L,5L,5L,2L,1L,2L,1L,1L,3L,8L,1L,17L,1L,1L,3L,1L,2L,1L,10L,2L,1L,54L,1L,2L,10L,1L,2L,1L,3L,1L,1L,17L,1L,8L,3L,1L,1L,2L,1L,2L,5L,5L,1L,26L,1L,5L,5L,2L,1L,2L,1L,1L,3L,8L,1L,17L,1L,1L,3L,1L,2L,1L,10L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040738Inst : IEnumerable<long>
{
public static readonly long[] Value=A040738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040738.Bytes);
public long this[int i]=>Value[i];

public static A040738Inst Instance=new A040738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040737
{
public static readonly long[] Value={ 27L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040737Inst : IEnumerable<long>
{
public static readonly long[] Value=A040737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040737.Bytes);
public long this[int i]=>Value[i];

public static A040737Inst Instance=new A040737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040736
{
public static readonly long[] Value={ 27L,1L,1L,1L,3L,1L,1L,2L,2L,1L,6L,4L,1L,7L,10L,1L,12L,1L,10L,7L,1L,4L,6L,1L,2L,2L,1L,1L,3L,1L,1L,1L,54L,1L,1L,1L,3L,1L,1L,2L,2L,1L,6L,4L,1L,7L,10L,1L,12L,1L,10L,7L,1L,4L,6L,1L,2L,2L,1L,1L,3L,1L,1L,1L,54L,1L,1L,1L,3L,1L,1L,2L,2L,1L,6L,4L,1L,7L,10L,1L,12L,1L,10L,7L,1L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040736Inst : IEnumerable<long>
{
public static readonly long[] Value=A040736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040736.Bytes);
public long this[int i]=>Value[i];

public static A040736Inst Instance=new A040736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040735
{
public static readonly long[] Value={ 27L,1L,1L,1L,1L,1L,5L,1L,1L,17L,1L,6L,1L,17L,1L,1L,5L,1L,1L,1L,1L,1L,54L,1L,1L,1L,1L,1L,5L,1L,1L,17L,1L,6L,1L,17L,1L,1L,5L,1L,1L,1L,1L,1L,54L,1L,1L,1L,1L,1L,5L,1L,1L,17L,1L,6L,1L,17L,1L,1L,5L,1L,1L,1L,1L,1L,54L,1L,1L,1L,1L,1L,5L,1L,1L,17L,1L,6L,1L,17L,1L,1L,5L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040735Inst : IEnumerable<long>
{
public static readonly long[] Value=A040735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040735.Bytes);
public long this[int i]=>Value[i];

public static A040735Inst Instance=new A040735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040734
{
public static readonly long[] Value={ 27L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040734Inst : IEnumerable<long>
{
public static readonly long[] Value=A040734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040734.Bytes);
public long this[int i]=>Value[i];

public static A040734Inst Instance=new A040734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040733
{
public static readonly long[] Value={ 27L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040733Inst : IEnumerable<long>
{
public static readonly long[] Value=A040733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040733.Bytes);
public long this[int i]=>Value[i];

public static A040733Inst Instance=new A040733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040716
{
public static readonly long[] Value={ 27L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040716Inst : IEnumerable<long>
{
public static readonly long[] Value=A040716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040716.Bytes);
public long this[int i]=>Value[i];

public static A040716Inst Instance=new A040716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040715
{
public static readonly long[] Value={ 27L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040715Inst : IEnumerable<long>
{
public static readonly long[] Value=A040715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040715.Bytes);
public long this[int i]=>Value[i];

public static A040715Inst Instance=new A040715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040714
{
public static readonly long[] Value={ 27L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040714Inst : IEnumerable<long>
{
public static readonly long[] Value=A040714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040714.Bytes);
public long this[int i]=>Value[i];

public static A040714Inst Instance=new A040714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040713
{
public static readonly long[] Value={ 27L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040713Inst : IEnumerable<long>
{
public static readonly long[] Value=A040713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040713.Bytes);
public long this[int i]=>Value[i];

public static A040713Inst Instance=new A040713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040712
{
public static readonly long[] Value={ 27L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040712Inst : IEnumerable<long>
{
public static readonly long[] Value=A040712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040712.Bytes);
public long this[int i]=>Value[i];

public static A040712Inst Instance=new A040712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040711
{
public static readonly long[] Value={ 27L,5L,2L,2L,1L,1L,3L,3L,2L,1L,8L,2L,1L,2L,1L,17L,2L,1L,1L,7L,5L,1L,10L,27L,10L,1L,5L,7L,1L,1L,2L,17L,1L,2L,1L,2L,8L,1L,2L,3L,3L,1L,1L,2L,2L,5L,54L,5L,2L,2L,1L,1L,3L,3L,2L,1L,8L,2L,1L,2L,1L,17L,2L,1L,1L,7L,5L,1L,10L,27L,10L,1L,5L,7L,1L,1L,2L,17L,1L,2L,1L,2L,8L,1L,2L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040711Inst : IEnumerable<long>
{
public static readonly long[] Value=A040711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040711.Bytes);
public long this[int i]=>Value[i];

public static A040711Inst Instance=new A040711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040710
{
public static readonly long[] Value={ 27L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040710Inst : IEnumerable<long>
{
public static readonly long[] Value=A040710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040710.Bytes);
public long this[int i]=>Value[i];

public static A040710Inst Instance=new A040710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040709
{
public static readonly long[] Value={ 27L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040709Inst : IEnumerable<long>
{
public static readonly long[] Value=A040709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040709.Bytes);
public long this[int i]=>Value[i];

public static A040709Inst Instance=new A040709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040708
{
public static readonly long[] Value={ 27L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040708Inst : IEnumerable<long>
{
public static readonly long[] Value=A040708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040708.Bytes);
public long this[int i]=>Value[i];

public static A040708Inst Instance=new A040708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040707
{
public static readonly long[] Value={ 27L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040707Inst : IEnumerable<long>
{
public static readonly long[] Value=A040707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040707.Bytes);
public long this[int i]=>Value[i];

public static A040707Inst Instance=new A040707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040706
{
public static readonly long[] Value={ 27L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040706Inst : IEnumerable<long>
{
public static readonly long[] Value=A040706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040706.Bytes);
public long this[int i]=>Value[i];

public static A040706Inst Instance=new A040706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040705
{
public static readonly long[] Value={ 27L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040705Inst : IEnumerable<long>
{
public static readonly long[] Value=A040705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040705.Bytes);
public long this[int i]=>Value[i];

public static A040705Inst Instance=new A040705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040704
{
public static readonly long[] Value={ 27L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040704Inst : IEnumerable<long>
{
public static readonly long[] Value=A040704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040704.Bytes);
public long this[int i]=>Value[i];

public static A040704Inst Instance=new A040704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040703
{
public static readonly long[] Value={ 27L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040703Inst : IEnumerable<long>
{
public static readonly long[] Value=A040703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040703.Bytes);
public long this[int i]=>Value[i];

public static A040703Inst Instance=new A040703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040702
{
public static readonly long[] Value={ 27L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040702Inst : IEnumerable<long>
{
public static readonly long[] Value=A040702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040702.Bytes);
public long this[int i]=>Value[i];

public static A040702Inst Instance=new A040702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040701
{
public static readonly long[] Value={ 26L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040701Inst : IEnumerable<long>
{
public static readonly long[] Value=A040701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040701.Bytes);
public long this[int i]=>Value[i];

public static A040701Inst Instance=new A040701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040684
{
public static readonly long[] Value={ 26L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040684Inst : IEnumerable<long>
{
public static readonly long[] Value=A040684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040684.Bytes);
public long this[int i]=>Value[i];

public static A040684Inst Instance=new A040684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040683
{
public static readonly long[] Value={ 26L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040683Inst : IEnumerable<long>
{
public static readonly long[] Value=A040683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040683.Bytes);
public long this[int i]=>Value[i];

public static A040683Inst Instance=new A040683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040682
{
public static readonly long[] Value={ 26L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L,52L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L,52L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L,52L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L,52L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L,52L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040682Inst : IEnumerable<long>
{
public static readonly long[] Value=A040682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040682.Bytes);
public long this[int i]=>Value[i];

public static A040682Inst Instance=new A040682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040681
{
public static readonly long[] Value={ 26L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040681Inst : IEnumerable<long>
{
public static readonly long[] Value=A040681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040681.Bytes);
public long this[int i]=>Value[i];

public static A040681Inst Instance=new A040681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040680
{
public static readonly long[] Value={ 26L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040680Inst : IEnumerable<long>
{
public static readonly long[] Value=A040680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040680.Bytes);
public long this[int i]=>Value[i];

public static A040680Inst Instance=new A040680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040679
{
public static readonly long[] Value={ 26L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040679Inst : IEnumerable<long>
{
public static readonly long[] Value=A040679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040679.Bytes);
public long this[int i]=>Value[i];

public static A040679Inst Instance=new A040679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040678
{
public static readonly long[] Value={ 26L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040678Inst : IEnumerable<long>
{
public static readonly long[] Value=A040678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040678.Bytes);
public long this[int i]=>Value[i];

public static A040678Inst Instance=new A040678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040677
{
public static readonly long[] Value={ 26L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040677Inst : IEnumerable<long>
{
public static readonly long[] Value=A040677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040677.Bytes);
public long this[int i]=>Value[i];

public static A040677Inst Instance=new A040677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040676
{
public static readonly long[] Value={ 26L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040676Inst : IEnumerable<long>
{
public static readonly long[] Value=A040676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040676.Bytes);
public long this[int i]=>Value[i];

public static A040676Inst Instance=new A040676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040675
{
public static readonly long[] Value={ 26L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040675Inst : IEnumerable<long>
{
public static readonly long[] Value=A040675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040675.Bytes);
public long this[int i]=>Value[i];

public static A040675Inst Instance=new A040675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040674
{
public static readonly long[] Value={ 26L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040674Inst : IEnumerable<long>
{
public static readonly long[] Value=A040674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040674.Bytes);
public long this[int i]=>Value[i];

public static A040674Inst Instance=new A040674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040673
{
public static readonly long[] Value={ 26L,2L,5L,2L,1L,1L,1L,1L,12L,1L,1L,1L,1L,2L,5L,2L,52L,2L,5L,2L,1L,1L,1L,1L,12L,1L,1L,1L,1L,2L,5L,2L,52L,2L,5L,2L,1L,1L,1L,1L,12L,1L,1L,1L,1L,2L,5L,2L,52L,2L,5L,2L,1L,1L,1L,1L,12L,1L,1L,1L,1L,2L,5L,2L,52L,2L,5L,2L,1L,1L,1L,1L,12L,1L,1L,1L,1L,2L,5L,2L,52L,2L,5L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040673Inst : IEnumerable<long>
{
public static readonly long[] Value=A040673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040673.Bytes);
public long this[int i]=>Value[i];

public static A040673Inst Instance=new A040673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040672
{
public static readonly long[] Value={ 26L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040672Inst : IEnumerable<long>
{
public static readonly long[] Value=A040672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040672.Bytes);
public long this[int i]=>Value[i];

public static A040672Inst Instance=new A040672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040671
{
public static readonly long[] Value={ 26L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040671Inst : IEnumerable<long>
{
public static readonly long[] Value=A040671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040671.Bytes);
public long this[int i]=>Value[i];

public static A040671Inst Instance=new A040671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040670
{
public static readonly long[] Value={ 26L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040670Inst : IEnumerable<long>
{
public static readonly long[] Value=A040670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040670.Bytes);
public long this[int i]=>Value[i];

public static A040670Inst Instance=new A040670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040669
{
public static readonly long[] Value={ 26L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040669Inst : IEnumerable<long>
{
public static readonly long[] Value=A040669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040669.Bytes);
public long this[int i]=>Value[i];

public static A040669Inst Instance=new A040669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040652
{
public static readonly long[] Value={ 26L,17L,2L,1L,5L,8L,1L,1L,25L,1L,1L,8L,5L,1L,2L,17L,52L,17L,2L,1L,5L,8L,1L,1L,25L,1L,1L,8L,5L,1L,2L,17L,52L,17L,2L,1L,5L,8L,1L,1L,25L,1L,1L,8L,5L,1L,2L,17L,52L,17L,2L,1L,5L,8L,1L,1L,25L,1L,1L,8L,5L,1L,2L,17L,52L,17L,2L,1L,5L,8L,1L,1L,25L,1L,1L,8L,5L,1L,2L,17L,52L,17L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040652Inst : IEnumerable<long>
{
public static readonly long[] Value=A040652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040652.Bytes);
public long this[int i]=>Value[i];

public static A040652Inst Instance=new A040652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040651
{
public static readonly long[] Value={ 26L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040651Inst : IEnumerable<long>
{
public static readonly long[] Value=A040651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040651.Bytes);
public long this[int i]=>Value[i];

public static A040651Inst Instance=new A040651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040650
{
public static readonly long[] Value={ 26L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040650Inst : IEnumerable<long>
{
public static readonly long[] Value=A040650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040650.Bytes);
public long this[int i]=>Value[i];

public static A040650Inst Instance=new A040650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040649
{
public static readonly long[] Value={ 25L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040649Inst : IEnumerable<long>
{
public static readonly long[] Value=A040649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040649.Bytes);
public long this[int i]=>Value[i];

public static A040649Inst Instance=new A040649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040648
{
public static readonly long[] Value={ 25L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040648Inst : IEnumerable<long>
{
public static readonly long[] Value=A040648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040648.Bytes);
public long this[int i]=>Value[i];

public static A040648Inst Instance=new A040648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040647
{
public static readonly long[] Value={ 25L,1L,16L,3L,5L,2L,3L,1L,1L,6L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,6L,1L,1L,3L,2L,5L,3L,16L,1L,50L,1L,16L,3L,5L,2L,3L,1L,1L,6L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,6L,1L,1L,3L,2L,5L,3L,16L,1L,50L,1L,16L,3L,5L,2L,3L,1L,1L,6L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,6L,1L,1L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040647Inst : IEnumerable<long>
{
public static readonly long[] Value=A040647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040647.Bytes);
public long this[int i]=>Value[i];

public static A040647Inst Instance=new A040647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040646
{
public static readonly long[] Value={ 25L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040646Inst : IEnumerable<long>
{
public static readonly long[] Value=A040646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040646.Bytes);
public long this[int i]=>Value[i];

public static A040646Inst Instance=new A040646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040645
{
public static readonly long[] Value={ 25L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040645Inst : IEnumerable<long>
{
public static readonly long[] Value=A040645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040645.Bytes);
public long this[int i]=>Value[i];

public static A040645Inst Instance=new A040645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040644
{
public static readonly long[] Value={ 25L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040644Inst : IEnumerable<long>
{
public static readonly long[] Value=A040644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040644.Bytes);
public long this[int i]=>Value[i];

public static A040644Inst Instance=new A040644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040643
{
public static readonly long[] Value={ 25L,1L,6L,2L,2L,3L,1L,9L,1L,1L,2L,1L,12L,4L,1L,1L,1L,1L,1L,16L,1L,1L,1L,1L,1L,4L,12L,1L,2L,1L,1L,9L,1L,3L,2L,2L,6L,1L,50L,1L,6L,2L,2L,3L,1L,9L,1L,1L,2L,1L,12L,4L,1L,1L,1L,1L,1L,16L,1L,1L,1L,1L,1L,4L,12L,1L,2L,1L,1L,9L,1L,3L,2L,2L,6L,1L,50L,1L,6L,2L,2L,3L,1L,9L,1L,1L,2L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040643Inst : IEnumerable<long>
{
public static readonly long[] Value=A040643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040643.Bytes);
public long this[int i]=>Value[i];

public static A040643Inst Instance=new A040643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040642
{
public static readonly long[] Value={ 25L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040642Inst : IEnumerable<long>
{
public static readonly long[] Value=A040642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040642.Bytes);
public long this[int i]=>Value[i];

public static A040642Inst Instance=new A040642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040641
{
public static readonly long[] Value={ 25L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040641Inst : IEnumerable<long>
{
public static readonly long[] Value=A040641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040641.Bytes);
public long this[int i]=>Value[i];

public static A040641Inst Instance=new A040641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040640
{
public static readonly long[] Value={ 25L,1L,4L,5L,1L,1L,6L,1L,4L,1L,6L,1L,1L,5L,4L,1L,50L,1L,4L,5L,1L,1L,6L,1L,4L,1L,6L,1L,1L,5L,4L,1L,50L,1L,4L,5L,1L,1L,6L,1L,4L,1L,6L,1L,1L,5L,4L,1L,50L,1L,4L,5L,1L,1L,6L,1L,4L,1L,6L,1L,1L,5L,4L,1L,50L,1L,4L,5L,1L,1L,6L,1L,4L,1L,6L,1L,1L,5L,4L,1L,50L,1L,4L,5L,1L,1L,6L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040640Inst : IEnumerable<long>
{
public static readonly long[] Value=A040640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040640.Bytes);
public long this[int i]=>Value[i];

public static A040640Inst Instance=new A040640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040639
{
public static readonly long[] Value={ 25L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040639Inst : IEnumerable<long>
{
public static readonly long[] Value=A040639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040639.Bytes);
public long this[int i]=>Value[i];

public static A040639Inst Instance=new A040639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040638
{
public static readonly long[] Value={ 25L,1L,3L,3L,5L,2L,2L,1L,1L,2L,1L,5L,1L,2L,1L,1L,2L,2L,5L,3L,3L,1L,50L,1L,3L,3L,5L,2L,2L,1L,1L,2L,1L,5L,1L,2L,1L,1L,2L,2L,5L,3L,3L,1L,50L,1L,3L,3L,5L,2L,2L,1L,1L,2L,1L,5L,1L,2L,1L,1L,2L,2L,5L,3L,3L,1L,50L,1L,3L,3L,5L,2L,2L,1L,1L,2L,1L,5L,1L,2L,1L,1L,2L,2L,5L,3L,3L,1L,50L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040638Inst : IEnumerable<long>
{
public static readonly long[] Value=A040638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040638.Bytes);
public long this[int i]=>Value[i];

public static A040638Inst Instance=new A040638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040637
{
public static readonly long[] Value={ 25L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040637Inst : IEnumerable<long>
{
public static readonly long[] Value=A040637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040637.Bytes);
public long this[int i]=>Value[i];

public static A040637Inst Instance=new A040637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040620
{
public static readonly long[] Value={ 25L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040620Inst : IEnumerable<long>
{
public static readonly long[] Value=A040620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040620.Bytes);
public long this[int i]=>Value[i];

public static A040620Inst Instance=new A040620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040619
{
public static readonly long[] Value={ 25L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040619Inst : IEnumerable<long>
{
public static readonly long[] Value=A040619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040619.Bytes);
public long this[int i]=>Value[i];

public static A040619Inst Instance=new A040619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040618
{
public static readonly long[] Value={ 25L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040618Inst : IEnumerable<long>
{
public static readonly long[] Value=A040618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040618.Bytes);
public long this[int i]=>Value[i];

public static A040618Inst Instance=new A040618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040617
{
public static readonly long[] Value={ 25L,2L,1L,3L,1L,16L,8L,2L,1L,1L,5L,25L,5L,1L,1L,2L,8L,16L,1L,3L,1L,2L,50L,2L,1L,3L,1L,16L,8L,2L,1L,1L,5L,25L,5L,1L,1L,2L,8L,16L,1L,3L,1L,2L,50L,2L,1L,3L,1L,16L,8L,2L,1L,1L,5L,25L,5L,1L,1L,2L,8L,16L,1L,3L,1L,2L,50L,2L,1L,3L,1L,16L,8L,2L,1L,1L,5L,25L,5L,1L,1L,2L,8L,16L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040617Inst : IEnumerable<long>
{
public static readonly long[] Value=A040617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040617.Bytes);
public long this[int i]=>Value[i];

public static A040617Inst Instance=new A040617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040616
{
public static readonly long[] Value={ 25L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040616Inst : IEnumerable<long>
{
public static readonly long[] Value=A040616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040616.Bytes);
public long this[int i]=>Value[i];

public static A040616Inst Instance=new A040616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040615
{
public static readonly long[] Value={ 25L,3L,6L,1L,9L,3L,1L,3L,1L,5L,1L,1L,5L,1L,3L,1L,3L,9L,1L,6L,3L,50L,3L,6L,1L,9L,3L,1L,3L,1L,5L,1L,1L,5L,1L,3L,1L,3L,9L,1L,6L,3L,50L,3L,6L,1L,9L,3L,1L,3L,1L,5L,1L,1L,5L,1L,3L,1L,3L,9L,1L,6L,3L,50L,3L,6L,1L,9L,3L,1L,3L,1L,5L,1L,1L,5L,1L,3L,1L,3L,9L,1L,6L,3L,50L,3L,6L,1L,9L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040615Inst : IEnumerable<long>
{
public static readonly long[] Value=A040615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040615.Bytes);
public long this[int i]=>Value[i];

public static A040615Inst Instance=new A040615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040614
{
public static readonly long[] Value={ 25L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040614Inst : IEnumerable<long>
{
public static readonly long[] Value=A040614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040614.Bytes);
public long this[int i]=>Value[i];

public static A040614Inst Instance=new A040614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040613
{
public static readonly long[] Value={ 25L,3L,1L,1L,2L,4L,4L,1L,4L,1L,4L,4L,2L,1L,1L,3L,50L,3L,1L,1L,2L,4L,4L,1L,4L,1L,4L,4L,2L,1L,1L,3L,50L,3L,1L,1L,2L,4L,4L,1L,4L,1L,4L,4L,2L,1L,1L,3L,50L,3L,1L,1L,2L,4L,4L,1L,4L,1L,4L,4L,2L,1L,1L,3L,50L,3L,1L,1L,2L,4L,4L,1L,4L,1L,4L,4L,2L,1L,1L,3L,50L,3L,1L,1L,2L,4L,4L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040613Inst : IEnumerable<long>
{
public static readonly long[] Value=A040613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040613.Bytes);
public long this[int i]=>Value[i];

public static A040613Inst Instance=new A040613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040612
{
public static readonly long[] Value={ 25L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040612Inst : IEnumerable<long>
{
public static readonly long[] Value=A040612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040612.Bytes);
public long this[int i]=>Value[i];

public static A040612Inst Instance=new A040612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040611
{
public static readonly long[] Value={ 25L,4L,5L,2L,1L,3L,1L,1L,12L,16L,1L,2L,1L,16L,12L,1L,1L,3L,1L,2L,5L,4L,50L,4L,5L,2L,1L,3L,1L,1L,12L,16L,1L,2L,1L,16L,12L,1L,1L,3L,1L,2L,5L,4L,50L,4L,5L,2L,1L,3L,1L,1L,12L,16L,1L,2L,1L,16L,12L,1L,1L,3L,1L,2L,5L,4L,50L,4L,5L,2L,1L,3L,1L,1L,12L,16L,1L,2L,1L,16L,12L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040611Inst : IEnumerable<long>
{
public static readonly long[] Value=A040611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040611.Bytes);
public long this[int i]=>Value[i];

public static A040611Inst Instance=new A040611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040610
{
public static readonly long[] Value={ 25L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040610Inst : IEnumerable<long>
{
public static readonly long[] Value=A040610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040610.Bytes);
public long this[int i]=>Value[i];

public static A040610Inst Instance=new A040610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040609
{
public static readonly long[] Value={ 25L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040609Inst : IEnumerable<long>
{
public static readonly long[] Value=A040609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040609.Bytes);
public long this[int i]=>Value[i];

public static A040609Inst Instance=new A040609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040608
{
public static readonly long[] Value={ 25L,5L,1L,1L,2L,1L,4L,3L,6L,1L,7L,1L,1L,7L,1L,6L,3L,4L,1L,2L,1L,1L,5L,50L,5L,1L,1L,2L,1L,4L,3L,6L,1L,7L,1L,1L,7L,1L,6L,3L,4L,1L,2L,1L,1L,5L,50L,5L,1L,1L,2L,1L,4L,3L,6L,1L,7L,1L,1L,7L,1L,6L,3L,4L,1L,2L,1L,1L,5L,50L,5L,1L,1L,2L,1L,4L,3L,6L,1L,7L,1L,1L,7L,1L,6L,3L,4L,1L,2L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040608Inst : IEnumerable<long>
{
public static readonly long[] Value=A040608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040608.Bytes);
public long this[int i]=>Value[i];

public static A040608Inst Instance=new A040608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040607
{
public static readonly long[] Value={ 25L,6L,3L,1L,2L,2L,1L,1L,2L,16L,2L,1L,1L,2L,2L,1L,3L,6L,50L,6L,3L,1L,2L,2L,1L,1L,2L,16L,2L,1L,1L,2L,2L,1L,3L,6L,50L,6L,3L,1L,2L,2L,1L,1L,2L,16L,2L,1L,1L,2L,2L,1L,3L,6L,50L,6L,3L,1L,2L,2L,1L,1L,2L,16L,2L,1L,1L,2L,2L,1L,3L,6L,50L,6L,3L,1L,2L,2L,1L,1L,2L,16L,2L,1L,1L,2L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040607Inst : IEnumerable<long>
{
public static readonly long[] Value=A040607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040607.Bytes);
public long this[int i]=>Value[i];

public static A040607Inst Instance=new A040607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040606
{
public static readonly long[] Value={ 25L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040606Inst : IEnumerable<long>
{
public static readonly long[] Value=A040606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040606.Bytes);
public long this[int i]=>Value[i];

public static A040606Inst Instance=new A040606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040605
{
public static readonly long[] Value={ 25L,8L,2L,1L,4L,1L,9L,4L,2L,6L,1L,2L,1L,2L,1L,1L,1L,1L,4L,2L,2L,2L,1L,16L,25L,16L,1L,2L,2L,2L,4L,1L,1L,1L,1L,2L,1L,2L,1L,6L,2L,4L,9L,1L,4L,1L,2L,8L,50L,8L,2L,1L,4L,1L,9L,4L,2L,6L,1L,2L,1L,2L,1L,1L,1L,1L,4L,2L,2L,2L,1L,16L,25L,16L,1L,2L,2L,2L,4L,1L,1L,1L,1L,2L,1L,2L,1L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040605Inst : IEnumerable<long>
{
public static readonly long[] Value=A040605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040605.Bytes);
public long this[int i]=>Value[i];

public static A040605Inst Instance=new A040605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040556
{
public static readonly long[] Value={ 24L,9L,1L,1L,1L,1L,1L,3L,11L,1L,3L,2L,6L,2L,3L,1L,11L,3L,1L,1L,1L,1L,1L,9L,48L,9L,1L,1L,1L,1L,1L,3L,11L,1L,3L,2L,6L,2L,3L,1L,11L,3L,1L,1L,1L,1L,1L,9L,48L,9L,1L,1L,1L,1L,1L,3L,11L,1L,3L,2L,6L,2L,3L,1L,11L,3L,1L,1L,1L,1L,1L,9L,48L,9L,1L,1L,1L,1L,1L,3L,11L,1L,3L,2L,6L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040556Inst : IEnumerable<long>
{
public static readonly long[] Value=A040556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040556.Bytes);
public long this[int i]=>Value[i];

public static A040556Inst Instance=new A040556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040555
{
public static readonly long[] Value={ 24L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040555Inst : IEnumerable<long>
{
public static readonly long[] Value=A040555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040555.Bytes);
public long this[int i]=>Value[i];

public static A040555Inst Instance=new A040555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040554
{
public static readonly long[] Value={ 24L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040554Inst : IEnumerable<long>
{
public static readonly long[] Value=A040554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040554.Bytes);
public long this[int i]=>Value[i];

public static A040554Inst Instance=new A040554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040553
{
public static readonly long[] Value={ 24L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040553Inst : IEnumerable<long>
{
public static readonly long[] Value=A040553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040553.Bytes);
public long this[int i]=>Value[i];

public static A040553Inst Instance=new A040553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040552
{
public static readonly long[] Value={ 24L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040552Inst : IEnumerable<long>
{
public static readonly long[] Value=A040552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040552.Bytes);
public long this[int i]=>Value[i];

public static A040552Inst Instance=new A040552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040551
{
public static readonly long[] Value={ 23L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040551Inst : IEnumerable<long>
{
public static readonly long[] Value=A040551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040551.Bytes);
public long this[int i]=>Value[i];

public static A040551Inst Instance=new A040551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040550
{
public static readonly long[] Value={ 23L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040550Inst : IEnumerable<long>
{
public static readonly long[] Value=A040550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040550.Bytes);
public long this[int i]=>Value[i];

public static A040550Inst Instance=new A040550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040549
{
public static readonly long[] Value={ 23L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040549Inst : IEnumerable<long>
{
public static readonly long[] Value=A040549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040549.Bytes);
public long this[int i]=>Value[i];

public static A040549Inst Instance=new A040549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040548
{
public static readonly long[] Value={ 23L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040548Inst : IEnumerable<long>
{
public static readonly long[] Value=A040548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040548.Bytes);
public long this[int i]=>Value[i];

public static A040548Inst Instance=new A040548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040547
{
public static readonly long[] Value={ 23L,1L,8L,1L,1L,2L,1L,1L,1L,15L,3L,2L,1L,6L,7L,1L,4L,2L,3L,4L,2L,23L,2L,4L,3L,2L,4L,1L,7L,6L,1L,2L,3L,15L,1L,1L,1L,2L,1L,1L,8L,1L,46L,1L,8L,1L,1L,2L,1L,1L,1L,15L,3L,2L,1L,6L,7L,1L,4L,2L,3L,4L,2L,23L,2L,4L,3L,2L,4L,1L,7L,6L,1L,2L,3L,15L,1L,1L,1L,2L,1L,1L,8L,1L,46L,1L,8L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040547Inst : IEnumerable<long>
{
public static readonly long[] Value=A040547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040547.Bytes);
public long this[int i]=>Value[i];

public static A040547Inst Instance=new A040547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040546
{
public static readonly long[] Value={ 23L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040546Inst : IEnumerable<long>
{
public static readonly long[] Value=A040546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040546.Bytes);
public long this[int i]=>Value[i];

public static A040546Inst Instance=new A040546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040545
{
public static readonly long[] Value={ 23L,1L,5L,1L,5L,9L,2L,1L,2L,3L,3L,2L,1L,2L,9L,5L,1L,5L,1L,46L,1L,5L,1L,5L,9L,2L,1L,2L,3L,3L,2L,1L,2L,9L,5L,1L,5L,1L,46L,1L,5L,1L,5L,9L,2L,1L,2L,3L,3L,2L,1L,2L,9L,5L,1L,5L,1L,46L,1L,5L,1L,5L,9L,2L,1L,2L,3L,3L,2L,1L,2L,9L,5L,1L,5L,1L,46L,1L,5L,1L,5L,9L,2L,1L,2L,3L,3L,2L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040545Inst : IEnumerable<long>
{
public static readonly long[] Value=A040545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040545.Bytes);
public long this[int i]=>Value[i];

public static A040545Inst Instance=new A040545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040544
{
public static readonly long[] Value={ 23L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040544Inst : IEnumerable<long>
{
public static readonly long[] Value=A040544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040544.Bytes);
public long this[int i]=>Value[i];

public static A040544Inst Instance=new A040544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040543
{
public static readonly long[] Value={ 23L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040543Inst : IEnumerable<long>
{
public static readonly long[] Value=A040543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040543.Bytes);
public long this[int i]=>Value[i];

public static A040543Inst Instance=new A040543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040542
{
public static readonly long[] Value={ 23L,1L,3L,1L,3L,1L,1L,8L,1L,22L,1L,8L,1L,1L,3L,1L,3L,1L,46L,1L,3L,1L,3L,1L,1L,8L,1L,22L,1L,8L,1L,1L,3L,1L,3L,1L,46L,1L,3L,1L,3L,1L,1L,8L,1L,22L,1L,8L,1L,1L,3L,1L,3L,1L,46L,1L,3L,1L,3L,1L,1L,8L,1L,22L,1L,8L,1L,1L,3L,1L,3L,1L,46L,1L,3L,1L,3L,1L,1L,8L,1L,22L,1L,8L,1L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040542Inst : IEnumerable<long>
{
public static readonly long[] Value=A040542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040542.Bytes);
public long this[int i]=>Value[i];

public static A040542Inst Instance=new A040542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040541
{
public static readonly long[] Value={ 23L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040541Inst : IEnumerable<long>
{
public static readonly long[] Value=A040541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040541.Bytes);
public long this[int i]=>Value[i];

public static A040541Inst Instance=new A040541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040524
{
public static readonly long[] Value={ 23L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040524Inst : IEnumerable<long>
{
public static readonly long[] Value=A040524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040524.Bytes);
public long this[int i]=>Value[i];

public static A040524Inst Instance=new A040524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040523
{
public static readonly long[] Value={ 23L,2L,1L,1L,2L,1L,2L,1L,7L,15L,2L,6L,5L,23L,5L,6L,2L,15L,7L,1L,2L,1L,2L,1L,1L,2L,46L,2L,1L,1L,2L,1L,2L,1L,7L,15L,2L,6L,5L,23L,5L,6L,2L,15L,7L,1L,2L,1L,2L,1L,1L,2L,46L,2L,1L,1L,2L,1L,2L,1L,7L,15L,2L,6L,5L,23L,5L,6L,2L,15L,7L,1L,2L,1L,2L,1L,1L,2L,46L,2L,1L,1L,2L,1L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040523Inst : IEnumerable<long>
{
public static readonly long[] Value=A040523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040523.Bytes);
public long this[int i]=>Value[i];

public static A040523Inst Instance=new A040523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040522
{
public static readonly long[] Value={ 23L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040522Inst : IEnumerable<long>
{
public static readonly long[] Value=A040522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040522.Bytes);
public long this[int i]=>Value[i];

public static A040522Inst Instance=new A040522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040521
{
public static readonly long[] Value={ 23L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040521Inst : IEnumerable<long>
{
public static readonly long[] Value=A040521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040521.Bytes);
public long this[int i]=>Value[i];

public static A040521Inst Instance=new A040521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040520
{
public static readonly long[] Value={ 23L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040520Inst : IEnumerable<long>
{
public static readonly long[] Value=A040520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040520.Bytes);
public long this[int i]=>Value[i];

public static A040520Inst Instance=new A040520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040519
{
public static readonly long[] Value={ 23L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040519Inst : IEnumerable<long>
{
public static readonly long[] Value=A040519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040519.Bytes);
public long this[int i]=>Value[i];

public static A040519Inst Instance=new A040519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040518
{
public static readonly long[] Value={ 23L,3L,1L,1L,3L,1L,1L,1L,22L,1L,1L,1L,3L,1L,1L,3L,46L,3L,1L,1L,3L,1L,1L,1L,22L,1L,1L,1L,3L,1L,1L,3L,46L,3L,1L,1L,3L,1L,1L,1L,22L,1L,1L,1L,3L,1L,1L,3L,46L,3L,1L,1L,3L,1L,1L,1L,22L,1L,1L,1L,3L,1L,1L,3L,46L,3L,1L,1L,3L,1L,1L,1L,22L,1L,1L,1L,3L,1L,1L,3L,46L,3L,1L,1L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040518Inst : IEnumerable<long>
{
public static readonly long[] Value=A040518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040518.Bytes);
public long this[int i]=>Value[i];

public static A040518Inst Instance=new A040518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040517
{
public static readonly long[] Value={ 23L,3L,1L,5L,1L,8L,2L,4L,1L,2L,3L,1L,1L,11L,15L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,15L,11L,1L,1L,3L,2L,1L,4L,2L,8L,1L,5L,1L,3L,46L,3L,1L,5L,1L,8L,2L,4L,1L,2L,3L,1L,1L,11L,15L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,15L,11L,1L,1L,3L,2L,1L,4L,2L,8L,1L,5L,1L,3L,46L,3L,1L,5L,1L,8L,2L,4L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040517Inst : IEnumerable<long>
{
public static readonly long[] Value=A040517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040517.Bytes);
public long this[int i]=>Value[i];

public static A040517Inst Instance=new A040517Inst();

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