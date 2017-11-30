using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A039632
{
public static readonly long[] Value={ 2L,11L,66L,347L,1780L,8871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039632Inst : IEnumerable<long>
{
public static readonly long[] Value=A039632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039632.Bytes);
public long this[int i]=>Value[i];

public static A039632Inst Instance=new A039632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039633
{
public static readonly long[] Value={ 2L,12L,66L,353L,1783L,8898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039633Inst : IEnumerable<long>
{
public static readonly long[] Value=A039633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039633.Bytes);
public long this[int i]=>Value[i];

public static A039633Inst Instance=new A039633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039634
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,2L,5L,11L,3L,13L,7L,7L,2L,17L,2L,19L,5L,5L,11L,23L,3L,3L,13L,13L,7L,29L,7L,31L,2L,2L,17L,17L,2L,37L,19L,19L,5L,41L,5L,43L,11L,11L,23L,47L,3L,3L,3L,3L,13L,53L,13L,13L,7L,7L,29L,59L,7L,61L,31L,31L,2L,2L,2L,67L,17L,17L,17L,71L,2L,73L,37L,37L,19L,19L,19L,79L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039634Inst : IEnumerable<long>
{
public static readonly long[] Value=A039634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039634.Bytes);
public long this[int i]=>Value[i];

public static A039634Inst Instance=new A039634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039635
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,5L,5L,11L,3L,13L,7L,2L,2L,17L,5L,19L,5L,11L,11L,23L,3L,13L,13L,7L,7L,29L,2L,31L,2L,17L,17L,5L,5L,37L,19L,5L,5L,41L,11L,43L,11L,23L,23L,47L,3L,13L,13L,13L,13L,53L,7L,7L,7L,29L,29L,59L,2L,61L,31L,2L,2L,17L,17L,67L,17L,5L,5L,71L,5L,73L,37L,19L,19L,5L,5L,79L,5L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039635Inst : IEnumerable<long>
{
public static readonly long[] Value=A039635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039635.Bytes);
public long this[int i]=>Value[i];

public static A039635Inst Instance=new A039635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039636
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,3L,3L,2L,1L,3L,1L,2L,2L,4L,1L,4L,1L,3L,3L,2L,1L,4L,4L,2L,2L,3L,1L,3L,1L,5L,5L,2L,2L,5L,1L,2L,2L,4L,1L,4L,1L,3L,3L,2L,1L,5L,5L,5L,5L,3L,1L,3L,3L,4L,4L,2L,1L,4L,1L,2L,2L,6L,6L,6L,1L,3L,3L,3L,1L,6L,1L,2L,2L,3L,3L,3L,1L,5L,5L,2L,1L,5L,5L,2L,2L,4L,1L,4L,4L,3L,3L,2L,2L,6L,1L,6L,6L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039636Inst : IEnumerable<long>
{
public static readonly long[] Value=A039636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039636.Bytes);
public long this[int i]=>Value[i];

public static A039636Inst Instance=new A039636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039637
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,3L,1L,2L,4L,4L,1L,3L,1L,3L,2L,2L,1L,4L,2L,2L,3L,3L,1L,5L,1L,5L,2L,2L,4L,4L,1L,2L,4L,4L,1L,3L,1L,3L,2L,2L,1L,5L,3L,3L,3L,3L,1L,4L,4L,4L,2L,2L,1L,6L,1L,2L,6L,6L,3L,3L,1L,3L,5L,5L,1L,5L,1L,2L,3L,3L,5L,5L,1L,5L,2L,2L,1L,4L,2L,2L,4L,4L,1L,3L,3L,3L,2L,2L,6L,6L,1L,4L,4L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039637Inst : IEnumerable<long>
{
public static readonly long[] Value=A039637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039637.Bytes);
public long this[int i]=>Value[i];

public static A039637Inst Instance=new A039637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039638
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,2L,2L,11L,7L,7L,2L,5L,5L,23L,13L,29L,7L,2L,17L,2L,19L,41L,11L,3L,3L,3L,53L,13L,7L,31L,2L,17L,17L,37L,37L,19L,5L,83L,43L,89L,11L,47L,3L,3L,3L,13L,13L,113L,7L,29L,59L,7L,31L,2L,131L,67L,67L,17L,17L,17L,73L,19L,19L,19L,79L,41L,5L,173L,43L,11L,179L,11L,23L,47L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039638Inst : IEnumerable<long>
{
public static readonly long[] Value=A039638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039638.Bytes);
public long this[int i]=>Value[i];

public static A039638Inst Instance=new A039638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039639
{
public static readonly long[] Value={ 3L,2L,3L,2L,3L,7L,2L,5L,3L,7L,2L,19L,5L,11L,3L,13L,7L,31L,17L,2L,37L,5L,5L,11L,3L,3L,13L,13L,13L,7L,2L,2L,17L,17L,37L,19L,79L,41L,5L,43L,11L,11L,3L,97L,3L,3L,53L,7L,7L,7L,29L,7L,7L,31L,2L,2L,67L,17L,139L,17L,71L,73L,19L,19L,157L,79L,83L,5L,43L,43L,11L,11L,23L,23L,47L,3L,97L,199L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039639Inst : IEnumerable<long>
{
public static readonly long[] Value=A039639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039639.Bytes);
public long this[int i]=>Value[i];

public static A039639Inst Instance=new A039639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039640
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,2L,5L,11L,7L,2L,5L,5L,11L,23L,13L,29L,2L,17L,5L,5L,5L,41L,11L,3L,13L,13L,53L,7L,7L,2L,17L,17L,5L,37L,19L,5L,41L,83L,43L,89L,23L,3L,3L,13L,13L,53L,7L,113L,29L,29L,2L,2L,2L,2L,131L,67L,17L,5L,5L,71L,73L,5L,5L,5L,79L,83L,11L,173L,11L,11L,179L,23L,47L,3L,191L,97L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039640Inst : IEnumerable<long>
{
public static readonly long[] Value=A039640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039640.Bytes);
public long this[int i]=>Value[i];

public static A039640Inst Instance=new A039640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039641
{
public static readonly long[] Value={ 3L,2L,3L,2L,3L,7L,5L,5L,3L,2L,2L,19L,11L,11L,3L,7L,2L,31L,17L,5L,37L,5L,11L,23L,13L,13L,13L,7L,7L,29L,2L,17L,5L,5L,19L,19L,79L,41L,11L,11L,23L,23L,3L,97L,13L,13L,53L,7L,29L,29L,59L,2L,61L,2L,17L,17L,17L,17L,139L,71L,71L,37L,5L,5L,157L,5L,83L,43L,11L,11L,89L,23L,23L,47L,3L,3L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039641Inst : IEnumerable<long>
{
public static readonly long[] Value=A039641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039641.Bytes);
public long this[int i]=>Value[i];

public static A039641Inst Instance=new A039641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039642
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,4L,2L,3L,3L,5L,4L,4L,2L,3L,2L,4L,6L,3L,6L,3L,2L,4L,6L,6L,6L,2L,4L,5L,3L,7L,4L,4L,3L,3L,4L,6L,2L,3L,2L,5L,3L,7L,7L,7L,5L,5L,2L,6L,4L,3L,6L,4L,8L,2L,3L,3L,5L,5L,5L,3L,5L,5L,5L,3L,4L,7L,2L,4L,6L,2L,6L,5L,4L,2L,3L,8L,8L,8L,6L,6L,3L,6L,3L,6L,7L,7L,7L,7L,2L,2L,7L,4L,5L,2L,3L,9L,9L,4L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039642Inst : IEnumerable<long>
{
public static readonly long[] Value=A039642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039642.Bytes);
public long this[int i]=>Value[i];

public static A039642Inst Instance=new A039642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039643
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,2L,4L,3L,4L,3L,5L,2L,4L,3L,5L,3L,4L,2L,3L,6L,2L,5L,5L,4L,6L,6L,4L,4L,4L,5L,7L,7L,4L,4L,3L,4L,2L,3L,6L,3L,5L,5L,7L,2L,7L,7L,3L,6L,6L,6L,4L,6L,6L,4L,8L,8L,3L,5L,2L,5L,3L,3L,5L,5L,2L,3L,3L,7L,4L,4L,6L,6L,5L,5L,4L,8L,3L,2L,8L,8L,6L,2L,6L,6L,6L,6L,7L,2L,7L,5L,5L,7L,4L,4L,5L,5L,3L,9L,3L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039643Inst : IEnumerable<long>
{
public static readonly long[] Value=A039643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039643.Bytes);
public long this[int i]=>Value[i];

public static A039643Inst Instance=new A039643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039644
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,3L,2L,3L,5L,4L,4L,3L,2L,3L,2L,6L,3L,5L,5L,5L,2L,4L,6L,4L,4L,2L,5L,5L,7L,4L,4L,6L,3L,4L,6L,3L,2L,3L,2L,4L,7L,7L,5L,5L,3L,6L,2L,4L,4L,8L,8L,8L,8L,2L,3L,5L,7L,7L,3L,3L,7L,7L,7L,3L,3L,6L,2L,6L,6L,2L,5L,4L,8L,2L,3L,6L,6L,6L,4L,4L,7L,7L,7L,7L,7L,5L,5L,5L,2L,2L,4L,5L,9L,2L,3L,6L,3L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039644Inst : IEnumerable<long>
{
public static readonly long[] Value=A039644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039644.Bytes);
public long this[int i]=>Value[i];

public static A039644Inst Instance=new A039644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039661
{
public static readonly long[] Value={ 2L,3L,1L,4L,0L,6L,9L,2L,6L,3L,2L,7L,7L,9L,2L,6L,9L,0L,0L,5L,7L,2L,9L,0L,8L,6L,3L,6L,7L,9L,4L,8L,5L,4L,7L,3L,8L,0L,2L,6L,6L,1L,0L,6L,2L,4L,2L,6L,0L,0L,2L,1L,1L,9L,9L,3L,4L,4L,5L,0L,4L,6L,4L,0L,9L,5L,2L,4L,3L,4L,2L,3L,5L,0L,6L,9L,0L,4L,5L,2L,7L,8L,3L,5L,1L,6L,9L,7L,1L,9L,9L,7L,0L,6L,7L,5L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039661Inst : IEnumerable<long>
{
public static readonly long[] Value=A039661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039661.Bytes);
public long this[int i]=>Value[i];

public static A039661Inst Instance=new A039661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039662
{
public static readonly long[] Value={ 1L,0L,8L,4L,1L,0L,1L,5L,1L,2L,2L,3L,1L,1L,1L,3L,6L,1L,5L,1L,1L,2L,9L,0L,8L,1L,1L,4L,0L,6L,4L,1L,5L,0L,9L,1L,1L,2L,2L,1L,5L,8L,0L,9L,0L,9L,3L,9L,0L,9L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039662Inst : IEnumerable<long>
{
public static readonly long[] Value=A039662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039662.Bytes);
public long this[int i]=>Value[i];

public static A039662Inst Instance=new A039662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039663
{
public static readonly long[] Value={ 0L,9L,4L,2L,5L,1L,2L,2L,3L,1L,1L,1L,3L,6L,1L,5L,1L,1L,2L,17L,1L,1L,10L,4L,1L,14L,1L,1L,2L,2L,1L,5L,26L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039663Inst : IEnumerable<long>
{
public static readonly long[] Value=A039663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039663.Bytes);
public long this[int i]=>Value[i];

public static A039663Inst Instance=new A039663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039664
{
public static readonly long[] Value={ 353L,651L,2487L,2501L,2829L,3723L,3973L,4267L,4333L,4449L,4949L,5281L,5463L,5491L,5543L,5729L,6167L,6609L,6801L,7101L,7209L,7339L,7703L,8373L,8433L,8493L,8517L,8577L,8637L,9137L,9243L,9431L,9519L,9639L,9797L,9877L,10419L,10939L,11681L,11757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039664Inst : IEnumerable<long>
{
public static readonly long[] Value=A039664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039664.Bytes);
public long this[int i]=>Value[i];

public static A039664Inst Instance=new A039664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039665
{
public static readonly long[] Value={ 242L,243L,244L,245L,3655L,3656L,3657L,3658L,4503L,4504L,4505L,4506L,5943L,5944L,5945L,5946L,6853L,6854L,6855L,6856L,7256L,7257L,7258L,7259L,8392L,8393L,8394L,8395L,9367L,9368L,9369L,9370L,10983L,10984L,10985L,10986L,11605L,11606L,11607L,11608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039665Inst : IEnumerable<long>
{
public static readonly long[] Value=A039665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039665.Bytes);
public long this[int i]=>Value[i];

public static A039665Inst Instance=new A039665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039666
{
public static readonly long[] Value={ 1L,3L,15L,30L,35L,56L,70L,78L,105L,140L,168L,190L,210L,248L,264L,357L,420L,570L,616L,630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039666Inst : IEnumerable<long>
{
public static readonly long[] Value=A039666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039666.Bytes);
public long this[int i]=>Value[i];

public static A039666Inst Instance=new A039666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039667
{
public static readonly long[] Value={ 192L,219L,273L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039667Inst : IEnumerable<long>
{
public static readonly long[] Value=A039667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039667.Bytes);
public long this[int i]=>Value[i];

public static A039667Inst Instance=new A039667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039668
{
public static readonly long[] Value={ 1L,0L,6L,5L,20L,17L,56L,45L,156L,115L,344L,85L,356L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039668Inst : IEnumerable<long>
{
public static readonly long[] Value=A039668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039668.Bytes);
public long this[int i]=>Value[i];

public static A039668Inst Instance=new A039668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039669
{
public static readonly long[] Value={ 4L,7L,15L,21L,45L,75L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039669Inst : IEnumerable<long>
{
public static readonly long[] Value=A039669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039669.Bytes);
public long this[int i]=>Value[i];

public static A039669Inst Instance=new A039669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039670
{
public static readonly long[] Value={ 72L,78L,84L,90L,216L,222L,228L,234L,76326L,76332L,76338L,76344L,101526L,101532L,101538L,101544L,116646L,116652L,116658L,116664L,146886L,146892L,146898L,146904L,298086L,298092L,298098L,298104L,369366L,369372L,369378L,369384L,624966L,624972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039670Inst : IEnumerable<long>
{
public static readonly long[] Value=A039670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039670.Bytes);
public long this[int i]=>Value[i];

public static A039670Inst Instance=new A039670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039671
{
public static readonly long[] Value={ 1L,1L,3L,8L,21L,53L,130L,310L,724L,1661L,3757L,8398L,18588L,40800L,88918L,192592L,414907L,889631L,1899554L,4040864L,8567342L,18109698L,38176280L,80278798L,168432854L,352658013L,736977583L,1537420460L,3202035086L,6658948608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039671Inst : IEnumerable<long>
{
public static readonly long[] Value=A039671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039671.Bytes);
public long this[int i]=>Value[i];

public static A039671Inst Instance=new A039671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039672
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,10L,11L,13L,16L,19L,20L,23L,25L,28L,29L,32L,37L,38L,40L,41L,49L,50L,52L,56L,58L,59L,61L,65L,68L,74L,76L,77L,82L,83L,86L,88L,91L,97L,101L,103L,104L,106L,115L,118L,121L,122L,124L,130L,131L,133L,136L,137L,149L,151L,154L,155L,158L,163L,164L,166L,173L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039672Inst : IEnumerable<long>
{
public static readonly long[] Value=A039672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039672.Bytes);
public long this[int i]=>Value[i];

public static A039672Inst Instance=new A039672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039673
{
public static readonly long[] Value={ 2L,4L,5L,7L,11L,13L,23L,25L,38L,40L,50L,52L,56L,58L,59L,61L,74L,76L,86L,88L,101L,103L,104L,106L,122L,124L,131L,133L,149L,151L,164L,166L,173L,175L,185L,187L,200L,202L,236L,238L,248L,250L,254L,256L,266L,268L,275L,277L,281L,283L,308L,310L,329L,331L,344L,346L,380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039673Inst : IEnumerable<long>
{
public static readonly long[] Value=A039673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039673.Bytes);
public long this[int i]=>Value[i];

public static A039673Inst Instance=new A039673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039674
{
public static readonly long[] Value={ 11L,77L,88L,101L,121L,131L,151L,181L,202L,212L,262L,353L,424L,464L,505L,515L,535L,545L,676L,707L,757L,787L,868L,919L,929L,949L,979L,1001L,1661L,2002L,2992L,4334L,5665L,5995L,6226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039674Inst : IEnumerable<long>
{
public static readonly long[] Value=A039674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039674.Bytes);
public long this[int i]=>Value[i];

public static A039674Inst Instance=new A039674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039675
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,19L,23L,29L,37L,41L,59L,61L,83L,97L,101L,103L,131L,137L,149L,151L,163L,173L,181L,211L,223L,227L,277L,281L,283L,331L,347L,353L,367L,379L,389L,397L,401L,421L,433L,443L,461L,463L,479L,491L,509L,541L,547L,563L,569L,571L,577L,601L,607L,613L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039675Inst : IEnumerable<long>
{
public static readonly long[] Value=A039675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039675.Bytes);
public long this[int i]=>Value[i];

public static A039675Inst Instance=new A039675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039676
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,3L,3L,1L,3L,2L,3L,1L,3L,5L,1L,2L,1L,8L,1L,2L,4L,2L,1L,2L,4L,3L,6L,2L,1L,5L,1L,3L,2L,3L,6L,4L,2L,1L,2L,9L,3L,3L,1L,2L,6L,1L,2L,3L,1L,12L,2L,3L,1L,3L,5L,1L,2L,7L,2L,6L,1L,3L,2L,3L,6L,4L,2L,3L,3L,3L,1L,8L,3L,4L,8L,1L,2L,9L,1L,2L,3L,1L,2L,6L,4L,2L,7L,2L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039676Inst : IEnumerable<long>
{
public static readonly long[] Value=A039676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039676.Bytes);
public long this[int i]=>Value[i];

public static A039676Inst Instance=new A039676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039725
{
public static readonly long[] Value={ 6L,9L,10L,12L,15L,18L,20L,21L,24L,27L,28L,30L,33L,35L,36L,39L,40L,42L,44L,45L,48L,50L,51L,52L,54L,56L,57L,60L,63L,66L,69L,70L,72L,75L,78L,80L,81L,84L,87L,88L,90L,93L,96L,98L,99L,100L,102L,104L,105L,108L,110L,111L,112L,114L,117L,120L,123L,126L,129L,130L,132L,135L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039725Inst : IEnumerable<long>
{
public static readonly long[] Value=A039725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039725.Bytes);
public long this[int i]=>Value[i];

public static A039725Inst Instance=new A039725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039726
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,19L,29L,37L,47L,67L,103L,179L,191L,223L,271L,293L,317L,577L,643L,673L,809L,863L,877L,1049L,1093L,1129L,1151L,1381L,1613L,1637L,2089L,2131L,2311L,2957L,3623L,3833L,4253L,4271L,4423L,4673L,5939L,7717L,8167L,9133L,9533L,9539L,9679L,11059L,11743L,11969L,14759L,15859L,15971L,16139L,17431L,17713L,17761L,19309L,19373L,20747L,20983L,23741L,25261L,25933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039726Inst : IEnumerable<long>
{
public static readonly long[] Value=A039726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039726.Bytes);
public long this[int i]=>Value[i];

public static A039726Inst Instance=new A039726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039727
{
public static readonly long[] Value={ 0L,1L,0L,3L,0L,1L,4L,3L,4L,5L,5L,4L,7L,0L,0L,13L,2L,9L,4L,7L,9L,10L,10L,9L,14L,7L,6L,13L,22L,7L,13L,12L,19L,8L,5L,16L,11L,16L,32L,5L,18L,19L,11L,18L,32L,5L,12L,7L,3L,12L,19L,22L,37L,14L,18L,25L,46L,7L,26L,25L,23L,28L,36L,19L,12L,53L,3L,34L,15L,0L,40L,29L,21L,10L,2L,9L,54L,15L,14L,57L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039727Inst : IEnumerable<long>
{
public static readonly long[] Value=A039727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039727.Bytes);
public long this[int i]=>Value[i];

public static A039727Inst Instance=new A039727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039728
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,4L,4L,4L,5L,5L,6L,6L,6L,6L,8L,7L,7L,8L,8L,8L,8L,10L,10L,10L,11L,11L,12L,12L,12L,12L,12L,16L,12L,15L,14L,13L,15L,15L,14L,16L,15L,16L,16L,16L,16L,20L,19L,20L,19L,20L,20L,21L,20L,22L,23L,22L,23L,24L,24L,24L,24L,24L,24L,32L,26L,27L,28L,24L,27L,27L,25L,30L,26L,27L,29L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039728Inst : IEnumerable<long>
{
public static readonly long[] Value=A039728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039728.Bytes);
public long this[int i]=>Value[i];

public static A039728Inst Instance=new A039728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039729
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,6L,6L,7L,8L,8L,9L,10L,10L,11L,12L,12L,13L,13L,14L,15L,15L,15L,16L,17L,18L,18L,19L,20L,21L,22L,23L,23L,24L,25L,26L,27L,27L,27L,28L,29L,29L,30L,31L,32L,32L,33L,33L,33L,34L,35L,36L,37L,38L,39L,39L,39L,40L,40L,41L,42L,43L,44L,45L,46L,46L,47L,47L,48L,49L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039729Inst : IEnumerable<long>
{
public static readonly long[] Value=A039729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039729.Bytes);
public long this[int i]=>Value[i];

public static A039729Inst Instance=new A039729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039730
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,6L,7L,8L,8L,8L,8L,8L,8L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,17L,17L,18L,19L,20L,21L,22L,23L,23L,24L,24L,25L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,33L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039730Inst : IEnumerable<long>
{
public static readonly long[] Value=A039730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039730.Bytes);
public long this[int i]=>Value[i];

public static A039730Inst Instance=new A039730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039731
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,6L,8L,10L,12L,14L,18L,18L,20L,18L,24L,28L,30L,30L,34L,36L,38L,40L,42L,44L,48L,50L,48L,50L,54L,60L,64L,66L,68L,70L,72L,78L,80L,78L,84L,82L,84L,94L,96L,96L,98L,104L,110L,100L,102L,106L,112L,114L,124L,126L,126L,132L,134L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039731Inst : IEnumerable<long>
{
public static readonly long[] Value=A039731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039731.Bytes);
public long this[int i]=>Value[i];

public static A039731Inst Instance=new A039731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039732
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,5L,6L,7L,9L,9L,10L,9L,12L,14L,15L,15L,17L,18L,19L,20L,21L,22L,24L,25L,24L,25L,27L,30L,32L,33L,34L,35L,36L,39L,40L,39L,42L,41L,42L,47L,48L,48L,49L,52L,55L,50L,51L,53L,56L,57L,62L,63L,63L,66L,67L,69L,66L,67L,72L,75L,77L,78L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039732Inst : IEnumerable<long>
{
public static readonly long[] Value=A039732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039732.Bytes);
public long this[int i]=>Value[i];

public static A039732Inst Instance=new A039732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039733
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,5L,6L,7L,7L,8L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,14L,15L,16L,16L,16L,17L,17L,17L,19L,19L,20L,20L,22L,22L,22L,23L,24L,24L,25L,25L,25L,25L,26L,26L,28L,30L,31L,31L,31L,31L,31L,31L,32L,33L,33L,33L,34L,35L,35L,35L,37L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039733Inst : IEnumerable<long>
{
public static readonly long[] Value=A039733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039733.Bytes);
public long this[int i]=>Value[i];

public static A039733Inst Instance=new A039733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039734
{
public static readonly long[] Value={ 2L,3L,5L,7L,7L,11L,11L,13L,17L,17L,19L,23L,23L,29L,29L,31L,31L,37L,37L,37L,41L,43L,47L,53L,53L,53L,59L,59L,59L,67L,67L,71L,71L,79L,79L,79L,83L,89L,89L,97L,97L,97L,97L,101L,101L,107L,113L,127L,127L,127L,127L,127L,127L,131L,137L,137L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039734Inst : IEnumerable<long>
{
public static readonly long[] Value=A039734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039734.Bytes);
public long this[int i]=>Value[i];

public static A039734Inst Instance=new A039734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039735
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,1L,1L,1L,2L,4L,6L,6L,6L,4L,2L,1L,1L,1L,2L,5L,9L,15L,21L,24L,24L,20L,13L,5L,2L,1L,1L,2L,5L,10L,21L,41L,65L,97L,130L,144L,135L,98L,51L,16L,5L,1L,1L,2L,5L,11L,24L,56L,115L,221L,401L,658L,956L,1217L,1264L,1042L,631L,275L,72L,14L,1L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039735Inst : IEnumerable<long>
{
public static readonly long[] Value=A039735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039735.Bytes);
public long this[int i]=>Value[i];

public static A039735Inst Instance=new A039735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039736
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,1L,3L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,3L,2L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,3L,2L,1L,2L,3L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,3L,2L,2L,3L,1L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,2L,1L,3L,1L,2L,2L,2L,3L,2L,1L,3L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,3L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039736Inst : IEnumerable<long>
{
public static readonly long[] Value=A039736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039736.Bytes);
public long this[int i]=>Value[i];

public static A039736Inst Instance=new A039736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039737
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,0L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039737Inst : IEnumerable<long>
{
public static readonly long[] Value=A039737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039737.Bytes);
public long this[int i]=>Value[i];

public static A039737Inst Instance=new A039737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039738
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039738Inst : IEnumerable<long>
{
public static readonly long[] Value=A039738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039738.Bytes);
public long this[int i]=>Value[i];

public static A039738Inst Instance=new A039738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039739
{
public static readonly long[] Value={ 1L,1L,3L,3L,1L,5L,3L,3L,5L,3L,1L,5L,3L,11L,5L,3L,1L,7L,3L,1L,3L,3L,5L,9L,5L,3L,11L,9L,5L,7L,3L,5L,3L,9L,7L,1L,3L,11L,5L,15L,13L,3L,1L,5L,3L,3L,3L,27L,25L,21L,15L,13L,3L,5L,11L,5L,3L,1L,17L,15L,5L,7L,3L,1L,9L,3L,9L,11L,9L,5L,3L,15L,9L,3L,3L,5L,1L,21L,13L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039739Inst : IEnumerable<long>
{
public static readonly long[] Value=A039739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039739.Bytes);
public long this[int i]=>Value[i];

public static A039739Inst Instance=new A039739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039740
{
public static readonly long[] Value={ 1L,4L,12L,44L,182L,796L,3612L,16786L,79426L,381250L,1851832L,9086022L,44970688L,224279188L,1126038472L,5687027204L,28873452032L,147281732692L,754443210294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039740Inst : IEnumerable<long>
{
public static readonly long[] Value=A039740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039740.Bytes);
public long this[int i]=>Value[i];

public static A039740Inst Instance=new A039740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039805
{
public static readonly long[] Value={ 1L,3L,1L,6L,3L,1L,13L,9L,3L,1L,23L,19L,9L,3L,1L,44L,42L,22L,9L,3L,1L,74L,80L,48L,22L,9L,3L,1L,129L,154L,99L,51L,22L,9L,3L,1L,210L,273L,193L,105L,51L,22L,9L,3L,1L,345L,484L,362L,212L,108L,51L,22L,9L,3L,1L,542L,815L,651L,401L,218L,108L,51L,22L,9L,3L,1L,858L,1369L,1147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039805Inst : IEnumerable<long>
{
public static readonly long[] Value=A039805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039805.Bytes);
public long this[int i]=>Value[i];

public static A039805Inst Instance=new A039805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039806
{
public static readonly long[] Value={ 1L,4L,1L,10L,4L,1L,26L,14L,4L,1L,55L,36L,14L,4L,1L,121L,91L,40L,14L,4L,1L,237L,202L,101L,40L,14L,4L,1L,468L,439L,238L,105L,40L,14L,4L,1L,867L,887L,524L,248L,105L,40L,14L,4L,1L,1597L,1758L,1105L,560L,252L,105L,40L,14L,4L,1L,2821L,3325L,2223L,1190L,570L,252L,105L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039806Inst : IEnumerable<long>
{
public static readonly long[] Value=A039806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039806.Bytes);
public long this[int i]=>Value[i];

public static A039806Inst Instance=new A039806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039807
{
public static readonly long[] Value={ 1L,5L,1L,15L,5L,1L,45L,20L,5L,1L,110L,60L,20L,5L,1L,271L,170L,65L,20L,5L,1L,599L,426L,185L,65L,20L,5L,1L,1309L,1025L,486L,190L,65L,20L,5L,1L,2690L,2299L,1185L,501L,190L,65L,20L,5L,1L,5436L,4999L,2750L,1245L,506L,190L,65L,20L,5L,1L,10545L,10380L,6069L,2910L,1260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039807Inst : IEnumerable<long>
{
public static readonly long[] Value=A039807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039807.Bytes);
public long this[int i]=>Value[i];

public static A039807Inst Instance=new A039807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039808
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,20L,47L,109L,258L,609L,1447L,3434L,8175L,19449L,46327L,110330L,262882L,626317L,1492515L,3556540L,8475679L,20198343L,48136276L,114716767L,273393363L,651550405L,1552783297L,3700609736L,8819356189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039808Inst : IEnumerable<long>
{
public static readonly long[] Value=A039808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039808.Bytes);
public long this[int i]=>Value[i];

public static A039808Inst Instance=new A039808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039809
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,32L,83L,223L,594L,1600L,4297L,11589L,31216L,84212L,227091L,612712L,1652913L,4459962L,12033405L,32469682L,87611105L,236402465L,637884103L,1721218224L,4644392797L,12532091909L,33815653370L,91245738923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039809Inst : IEnumerable<long>
{
public static readonly long[] Value=A039809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039809.Bytes);
public long this[int i]=>Value[i];

public static A039809Inst Instance=new A039809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039810
{
public static readonly long[] Value={ 1L,2L,1L,5L,6L,1L,15L,32L,12L,1L,52L,175L,110L,20L,1L,203L,1012L,945L,280L,30L,1L,877L,6230L,8092L,3465L,595L,42L,1L,4140L,40819L,70756L,40992L,10010L,1120L,56L,1L,21147L,283944L,638423L,479976L,156072L,24570L,1932L,72L,1L,115975L,2090424L,5971350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039810Inst : IEnumerable<long>
{
public static readonly long[] Value=A039810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039810.Bytes);
public long this[int i]=>Value[i];

public static A039810Inst Instance=new A039810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039811
{
public static readonly long[] Value={ 1L,3L,1L,12L,9L,1L,60L,75L,18L,1L,358L,660L,255L,30L,1L,2471L,6288L,3465L,645L,45L,1L,19302L,65051L,47838L,12495L,1365L,63L,1L,167894L,728556L,685580L,235193L,35700L,2562L,84L,1L,1606137L,8792910L,10285488L,4444188L,877653L,86940L,4410L,108L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039811Inst : IEnumerable<long>
{
public static readonly long[] Value=A039811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039811.Bytes);
public long this[int i]=>Value[i];

public static A039811Inst Instance=new A039811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039812
{
public static readonly long[] Value={ 1L,4L,1L,22L,12L,1L,154L,136L,24L,1L,1304L,1650L,460L,40L,1L,12915L,21904L,8550L,1160L,60L,1L,146115L,318521L,162904L,30590L,2450L,84L,1L,1855570L,5051988L,3246068L,789824L,86940L,4592L,112L,1L,26097835L,86910426L,68151304L,20606796L,2919504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039812Inst : IEnumerable<long>
{
public static readonly long[] Value=A039812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039812.Bytes);
public long this[int i]=>Value[i];

public static A039812Inst Instance=new A039812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039813
{
public static readonly long[] Value={ 1L,5L,1L,35L,15L,1L,315L,215L,30L,1L,3455L,3325L,725L,50L,1L,44590L,56605L,17100L,1825L,75L,1L,660665L,1060780L,415555L,60900L,3850L,105L,1L,11035095L,21772595L,10606470L,1998605L,172550L,7210L,140L,1L,204904830L,486459105L,286281665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039813Inst : IEnumerable<long>
{
public static readonly long[] Value=A039813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039813.Bytes);
public long this[int i]=>Value[i];

public static A039813Inst Instance=new A039813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039814
{
public static readonly long[] Value={ 1L,-2L,1L,7L,-6L,1L,-35L,40L,-12L,1L,228L,-315L,130L,-20L,1L,-1834L,2908L,-1485L,320L,-30L,1L,17582L,-30989L,18508L,-5005L,665L,-42L,1L,-195866L,375611L,-253400L,81088L,-13650L,1232L,-56L,1L,2487832L,-5112570L,3805723L,-1389612L,279048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039814Inst : IEnumerable<long>
{
public static readonly long[] Value=A039814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039814.Bytes);
public long this[int i]=>Value[i];

public static A039814Inst Instance=new A039814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039815
{
public static readonly long[] Value={ 1L,-3L,1L,15L,-9L,1L,-105L,87L,-18L,1L,947L,-975L,285L,-30L,1L,-10472L,12657L,-4680L,705L,-45L,1L,137337L,-188090L,82887L,-15960L,1470L,-63L,1L,-2085605L,3159699L,-1598954L,370237L,-43890L,2730L,-84L,1L,36017472L,-59326371L,33613353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039815Inst : IEnumerable<long>
{
public static readonly long[] Value=A039815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039815.Bytes);
public long this[int i]=>Value[i];

public static A039815Inst Instance=new A039815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039816
{
public static readonly long[] Value={ 1L,-4L,1L,26L,-12L,1L,-234L,152L,-24L,1L,2696L,-2210L,500L,-40L,1L,-37919L,36976L,-10710L,1240L,-60L,1L,630521L,-704837L,245896L,-36750L,2590L,-84L,1L,-12111114L,15132932L,-6120324L,1109696L,-101500L,4816L,-112L,1L,264051201L,-362099010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039816Inst : IEnumerable<long>
{
public static readonly long[] Value=A039816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039816.Bytes);
public long this[int i]=>Value[i];

public static A039816Inst Instance=new A039816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039817
{
public static readonly long[] Value={ 1L,-5L,1L,40L,-15L,1L,-440L,235L,-30L,1L,6170L,-4200L,775L,-50L,1L,-105315L,86020L,-20475L,1925L,-75L,1L,2120610L,-2001055L,577570L,-70525L,4025L,-105L,1L,-49242470L,52305780L,-17609620L,2623145L,-195300L,7490L,-140L,1L,1296133195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039817Inst : IEnumerable<long>
{
public static readonly long[] Value=A039817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039817.Bytes);
public long this[int i]=>Value[i];

public static A039817Inst Instance=new A039817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039818
{
public static readonly long[] Value={ 4409L,67307L,86573L,111857L,198349L,259507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039818Inst : IEnumerable<long>
{
public static readonly long[] Value=A039818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039818.Bytes);
public long this[int i]=>Value[i];

public static A039818Inst Instance=new A039818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039819
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,6L,8L,9L,8L,8L,12L,12L,10L,12L,8L,12L,8L,12L,8L,12L,8L,8L,12L,18L,8L,12L,9L,12L,8L,20L,8L,18L,12L,18L,8L,8L,8L,12L,24L,12L,8L,16L,18L,8L,9L,12L,14L,18L,18L,8L,24L,8L,12L,24L,12L,8L,20L,12L,8L,8L,24L,18L,5L,8L,12L,16L,8L,24L,18L,12L,8L,30L,12L,8L,24L,12L,8L,8L,18L,12L,8L,24L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039819Inst : IEnumerable<long>
{
public static readonly long[] Value=A039819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039819.Bytes);
public long this[int i]=>Value[i];

public static A039819Inst Instance=new A039819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039820
{
public static readonly long[] Value={ 1L,2L,3L,38L,212L,2538L,6888L,66592L,100001L,100002L,100003L,200001L,200002L,210771L,300001L,1000001L,1000002L,1000003L,1000004L,1000005L,1055041L,2000001L,2000002L,2000003L,2000005L,2059962L,2131888L,2356384L,3000001L,3000002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039820Inst : IEnumerable<long>
{
public static readonly long[] Value=A039820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039820.Bytes);
public long this[int i]=>Value[i];

public static A039820Inst Instance=new A039820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039821
{
public static readonly BigInteger[] Value={ 1L,1L,10L,21L,798L,1738L,157300L,334477L,57434806L,119394366L,33601489740L,68858583810L,28797022447980L,58526378304180L,34009655736503400L,68787420596367165L,BigInteger.Parse("52951950764170220070") };
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
public class A039821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A039821.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A039821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A039821Inst Instance=new A039821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039822
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,5L,8L,14L,18L,24L,30L,37L,43L,50L,58L,66L,74L,83L,93L,103L,113L,124L,136L,148L,160L,173L,187L,201L,215L,230L,246L,262L,278L,295L,313L,331L,349L,368L,388L,408L,428L,449L,471L,493L,515L,538L,562L,586L,610L,635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039822Inst : IEnumerable<long>
{
public static readonly long[] Value=A039822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039822.Bytes);
public long this[int i]=>Value[i];

public static A039822Inst Instance=new A039822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039823
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,11L,15L,19L,23L,28L,34L,40L,46L,53L,61L,69L,77L,86L,96L,106L,116L,127L,139L,151L,163L,176L,190L,204L,218L,233L,249L,265L,281L,298L,316L,334L,352L,371L,391L,411L,431L,452L,474L,496L,518L,541L,565L,589L,613L,638L,664L,690L,716L,743L,771L,799L,827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039823Inst : IEnumerable<long>
{
public static readonly long[] Value=A039823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039823.Bytes);
public long this[int i]=>Value[i];

public static A039823Inst Instance=new A039823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039824
{
public static readonly long[] Value={ 1L,2L,4L,11L,20L,31L,46L,61L,78L,97L,118L,141L,166L,193L,222L,253L,286L,321L,358L,397L,438L,481L,526L,573L,622L,673L,726L,781L,838L,897L,958L,1021L,1086L,1153L,1222L,1293L,1366L,1441L,1518L,1597L,1678L,1761L,1846L,1933L,2022L,2113L,2206L,2301L,2398L,2497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039824Inst : IEnumerable<long>
{
public static readonly long[] Value=A039824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039824.Bytes);
public long this[int i]=>Value[i];

public static A039824Inst Instance=new A039824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039825
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,12L,16L,20L,24L,29L,35L,41L,47L,54L,62L,70L,78L,87L,97L,107L,117L,128L,140L,152L,164L,177L,191L,205L,219L,234L,250L,266L,282L,299L,317L,335L,353L,372L,392L,412L,432L,453L,475L,497L,519L,542L,566L,590L,614L,639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039825Inst : IEnumerable<long>
{
public static readonly long[] Value=A039825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039825.Bytes);
public long this[int i]=>Value[i];

public static A039825Inst Instance=new A039825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039826
{
public static readonly long[] Value={ 1L,2L,3L,7L,15L,36L,87L,217L,549L,1423L,3735L,9911L,26513L,71581L,194681L,532481L,1464029L,4045117L,11225159L,31268577L,87404465L,245101771L,689323849L,1943817227L,5494808425L,15568077235L,44200775239L,125739619467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039826Inst : IEnumerable<long>
{
public static readonly long[] Value=A039826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039826.Bytes);
public long this[int i]=>Value[i];

public static A039826Inst Instance=new A039826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039827
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,19L,26L,34L,44L,54L,65L,77L,90L,104L,119L,135L,152L,170L,189L,209L,230L,252L,275L,299L,324L,350L,377L,405L,434L,464L,495L,527L,560L,594L,629L,665L,702L,740L,779L,819L,860L,902L,945L,989L,1034L,1080L,1127L,1175L,1224L,1274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039827Inst : IEnumerable<long>
{
public static readonly long[] Value=A039827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039827.Bytes);
public long this[int i]=>Value[i];

public static A039827Inst Instance=new A039827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039828
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,8L,14L,23L,40L,69L,123L,221L,397L,722L,1314L,2410L,4441L,8215L,15260L,28460L,53222L,99820L,187692L,353743L,668273L,1264854L,2399207L,4559828L,8679280L,16547220L,31592878L,60400688L,115633260L,221625505L,425313967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039828Inst : IEnumerable<long>
{
public static readonly long[] Value=A039828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039828.Bytes);
public long this[int i]=>Value[i];

public static A039828Inst Instance=new A039828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039829
{
public static readonly long[] Value={ 2L,2L,3L,4L,6L,10L,13L,17L,36L,48L,33L,39L,86L,100L,60L,68L,148L,166L,95L,105L,226L,248L,138L,150L,320L,346L,189L,203L,430L,460L,248L,264L,556L,590L,315L,333L,698L,736L,390L,410L,856L,898L,473L,495L,1030L,1076L,564L,588L,1220L,1270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039829Inst : IEnumerable<long>
{
public static readonly long[] Value=A039829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039829.Bytes);
public long this[int i]=>Value[i];

public static A039829Inst Instance=new A039829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039830
{
public static readonly long[] Value={ 2L,4L,4L,6L,16L,22L,15L,19L,46L,56L,34L,40L,92L,106L,61L,69L,154L,172L,96L,106L,232L,254L,139L,151L,326L,352L,190L,204L,436L,466L,249L,265L,562L,596L,316L,334L,704L,742L,391L,411L,862L,904L,474L,496L,1036L,1082L,565L,589L,1226L,1276L,664L,690L,1432L,1486L,771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039830Inst : IEnumerable<long>
{
public static readonly long[] Value=A039830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039830.Bytes);
public long this[int i]=>Value[i];

public static A039830Inst Instance=new A039830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039831
{
public static readonly long[] Value={ 1L,2L,4L,13L,57L,315L,2057L,15484L,132317L,1261560L,13281295L,153218597L,1921565205L,26008169266L,377922606876L,5871153031163L,97096594212804L,1702487540383101L,31551431772637772L,616331122530164638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039831Inst : IEnumerable<long>
{
public static readonly long[] Value=A039831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039831.Bytes);
public long this[int i]=>Value[i];

public static A039831Inst Instance=new A039831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039832
{
public static readonly long[] Value={ 14L,21L,26L,33L,34L,38L,57L,85L,86L,93L,94L,118L,122L,133L,141L,142L,145L,158L,177L,201L,202L,205L,213L,214L,217L,218L,253L,298L,301L,302L,326L,334L,381L,393L,394L,445L,446L,453L,481L,501L,514L,526L,537L,542L,553L,565L,622L,633L,634L,694L,697L,698L,706L,717L,745L,766L,778L,793L,802L,817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039832Inst : IEnumerable<long>
{
public static readonly long[] Value=A039832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039832.Bytes);
public long this[int i]=>Value[i];

public static A039832Inst Instance=new A039832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039833
{
public static readonly long[] Value={ 33L,85L,93L,141L,201L,213L,217L,301L,393L,445L,633L,697L,921L,1041L,1137L,1261L,1345L,1401L,1641L,1761L,1837L,1893L,1941L,1981L,2101L,2181L,2217L,2305L,2361L,2433L,2461L,2517L,2641L,2721L,2733L,3097L,3385L,3601L,3693L,3865L,3901L,3957L,4285L,4413L,4533L,4593L,4881L,5601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039833Inst : IEnumerable<long>
{
public static readonly long[] Value=A039833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039833.Bytes);
public long this[int i]=>Value[i];

public static A039833Inst Instance=new A039833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039834
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,2L,-3L,5L,-8L,13L,-21L,34L,-55L,89L,-144L,233L,-377L,610L,-987L,1597L,-2584L,4181L,-6765L,10946L,-17711L,28657L,-46368L,75025L,-121393L,196418L,-317811L,514229L,-832040L,1346269L,-2178309L,3524578L,-5702887L,9227465L,-14930352L,24157817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039834Inst : IEnumerable<long>
{
public static readonly long[] Value=A039834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039834.Bytes);
public long this[int i]=>Value[i];

public static A039834Inst Instance=new A039834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039835
{
public static readonly BigInteger[] Value={ 1L,10L,493L,3382L,158905L,1089154L,51167077L,350704366L,16475640049L,112925716858L,5305104928861L,36361730124070L,1708227311453353L,11708364174233842L,550043889183050965L,3770056902373173214L,BigInteger.Parse("177112424089630957537"),BigInteger.Parse("1213946614199987541226") };
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
public class A039835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A039835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A039835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A039835Inst Instance=new A039835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039836
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039836Inst : IEnumerable<long>
{
public static readonly long[] Value=A039836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039836.Bytes);
public long this[int i]=>Value[i];

public static A039836Inst Instance=new A039836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039885
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,5L,9L,11L,15L,25L,29L,42L,59L,70L,100L,129L,165L,218L,274L,353L,448L,568L,717L,891L,1116L,1393L,1718L,2136L,2625L,3200L,3955L,4802L,5852L,7136L,8570L,10423L,12550L,15075L,18162L,21652L,25964L,30973L,36868L,43925L,51977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039885Inst : IEnumerable<long>
{
public static readonly long[] Value=A039885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039885.Bytes);
public long this[int i]=>Value[i];

public static A039885Inst Instance=new A039885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039886
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,5L,8L,11L,12L,17L,24L,36L,44L,57L,76L,100L,126L,162L,208L,273L,335L,417L,521L,670L,835L,1022L,1246L,1544L,1914L,2359L,2848L,3455L,4195L,5125L,6191L,7452L,8927L,10738L,12893L,15422L,18375L,21897L,26032L,30939L,36599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039886Inst : IEnumerable<long>
{
public static readonly long[] Value=A039886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039886.Bytes);
public long this[int i]=>Value[i];

public static A039886Inst Instance=new A039886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039887
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,9L,10L,14L,23L,27L,39L,55L,66L,92L,122L,155L,202L,261L,326L,427L,531L,675L,843L,1047L,1322L,1620L,2017L,2489L,3021L,3757L,4542L,5554L,6766L,8143L,9897L,11926L,14335L,17264L,20626L,24708L,29495L,35149L,41827L,49637L,58806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039887Inst : IEnumerable<long>
{
public static readonly long[] Value=A039887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039887.Bytes);
public long this[int i]=>Value[i];

public static A039887Inst Instance=new A039887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039888
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,5L,7L,9L,15L,18L,25L,33L,47L,66L,81L,102L,135L,180L,240L,291L,363L,462L,599L,761L,929L,1138L,1421L,1780L,2214L,2679L,3261L,3989L,4902L,5970L,7195L,8666L,10475L,12642L,15202L,18172L,21736L,25954L,30961L,36803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039888Inst : IEnumerable<long>
{
public static readonly long[] Value=A039888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039888.Bytes);
public long this[int i]=>Value[i];

public static A039888Inst Instance=new A039888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039889
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,6L,9L,11L,17L,26L,32L,46L,60L,78L,111L,138L,183L,236L,297L,399L,489L,630L,794L,978L,1262L,1541L,1923L,2392L,2907L,3638L,4418L,5406L,6617L,7980L,9755L,11772L,14193L,17148L,20514L,24688L,29549L,35242L,42111L,50017L,59446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039889Inst : IEnumerable<long>
{
public static readonly long[] Value=A039889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039889.Bytes);
public long this[int i]=>Value[i];

public static A039889Inst Instance=new A039889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039890
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,5L,8L,12L,13L,19L,26L,40L,51L,62L,82L,111L,148L,190L,231L,301L,382L,492L,612L,759L,951L,1184L,1470L,1813L,2219L,2749L,3340L,4081L,4954L,6032L,7337L,8826L,10602L,12760L,15361L,18487L,21976L,26170L,31163L,37206L,44270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039890Inst : IEnumerable<long>
{
public static readonly long[] Value=A039890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039890.Bytes);
public long this[int i]=>Value[i];

public static A039890Inst Instance=new A039890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039891
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,9L,10L,15L,24L,29L,43L,56L,71L,102L,127L,172L,217L,277L,365L,457L,586L,737L,913L,1164L,1442L,1794L,2223L,2726L,3367L,4148L,5044L,6178L,7483L,9082L,11053L,13283L,16045L,19266L,23064L,27785L,33033L,39515L,47003L,55736L,66461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039891Inst : IEnumerable<long>
{
public static readonly long[] Value=A039891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039891.Bytes);
public long this[int i]=>Value[i];

public static A039891Inst Instance=new A039891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039892
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,5L,7L,8L,14L,17L,24L,32L,42L,58L,74L,95L,125L,158L,209L,259L,327L,414L,521L,655L,812L,998L,1243L,1531L,1890L,2304L,2806L,3423L,4173L,5052L,6108L,7342L,8858L,10647L,12759L,15252L,18189L,21682L,25831L,30627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039892Inst : IEnumerable<long>
{
public static readonly long[] Value=A039892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039892.Bytes);
public long this[int i]=>Value[i];

public static A039892Inst Instance=new A039892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039893
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,6L,8L,11L,17L,24L,31L,42L,56L,76L,101L,129L,167L,217L,279L,360L,449L,571L,719L,900L,1130L,1394L,1730L,2144L,2630L,3241L,3948L,4827L,5882L,7127L,8642L,10425L,12575L,15141L,18138L,21749L,25974L,31011L,36946L,43877L,52083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039893Inst : IEnumerable<long>
{
public static readonly long[] Value=A039893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039893.Bytes);
public long this[int i]=>Value[i];

public static A039893Inst Instance=new A039893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039894
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,5L,7L,11L,13L,18L,25L,35L,45L,59L,75L,102L,130L,168L,211L,267L,343L,431L,536L,675L,828L,1042L,1280L,1574L,1935L,2363L,2894L,3522L,4261L,5183L,6241L,7552L,9062L,10874L,13047L,15589L,18609L,22163L,26315L,31298L,37051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039894Inst : IEnumerable<long>
{
public static readonly long[] Value=A039894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039894.Bytes);
public long this[int i]=>Value[i];

public static A039894Inst Instance=new A039894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039895
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,8L,10L,15L,22L,28L,39L,53L,69L,93L,118L,157L,202L,260L,332L,418L,533L,675L,841L,1054L,1303L,1624L,2012L,2475L,3034L,3714L,4538L,5543L,6720L,8137L,9831L,11869L,14295L,17157L,20538L,24579L,29331L,34985L,41579L,49344L,58507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039895Inst : IEnumerable<long>
{
public static readonly long[] Value=A039895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039895.Bytes);
public long this[int i]=>Value[i];

public static A039895Inst Instance=new A039895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039896
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,11L,15L,22L,30L,40L,56L,77L,101L,135L,173L,231L,297L,385L,490L,622L,792L,1002L,1255L,1575L,1951L,2436L,3010L,3718L,4565L,5593L,6842L,8349L,10143L,12310L,14868L,17977L,21637L,26015L,31185L,37316L,44583L,53174L,63261L,75175L,89104L,105558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039896Inst : IEnumerable<long>
{
public static readonly long[] Value=A039896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039896.Bytes);
public long this[int i]=>Value[i];

public static A039896Inst Instance=new A039896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039897
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,7L,11L,17L,23L,32L,44L,63L,85L,114L,149L,198L,260L,341L,436L,559L,712L,910L,1149L,1446L,1803L,2254L,2803L,3478L,4282L,5267L,6453L,7905L,9635L,11716L,14191L,17180L,20735L,24985L,29998L,35965L,43019L,51404L,61257L,72880L,86510L,102580L,121405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039897Inst : IEnumerable<long>
{
public static readonly long[] Value=A039897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039897.Bytes);
public long this[int i]=>Value[i];

public static A039897Inst Instance=new A039897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039898
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,5L,9L,12L,18L,26L,35L,50L,67L,90L,122L,158L,212L,272L,355L,457L,582L,745L,941L,1185L,1494L,1858L,2325L,2875L,3561L,4388L,5386L,6604L,8061L,9815L,11936L,14440L,17482L,21058L,25352L,30438L,36460L,43610L,52040L,61980L,73727L,87464L,103695L,122619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039898Inst : IEnumerable<long>
{
public static readonly long[] Value=A039898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039898.Bytes);
public long this[int i]=>Value[i];

public static A039898Inst Instance=new A039898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039899
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,5L,8L,12L,18L,25L,36L,49L,68L,91L,123L,162L,214L,278L,362L,464L,596L,757L,961L,1209L,1521L,1897L,2366L,2931L,3627L,4463L,5487L,6711L,8200L,9976L,12121L,14672L,17738L,21371L,25716L,30852L,36964L,44168L,52709L,62746L,74600L,88497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039899Inst : IEnumerable<long>
{
public static readonly long[] Value=A039899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039899.Bytes);
public long this[int i]=>Value[i];

public static A039899Inst Instance=new A039899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039900
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,6L,9L,13L,19L,27L,38L,52L,71L,95L,127L,167L,220L,285L,370L,474L,607L,770L,976L,1226L,1540L,1920L,2391L,2960L,3660L,4501L,5529L,6760L,8254L,10038L,12190L,14750L,17825L,21470L,25825L,30975L,37101L,44322L,52879L,62937L,74811L,88733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039900Inst : IEnumerable<long>
{
public static readonly long[] Value=A039900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039900.Bytes);
public long this[int i]=>Value[i];

public static A039900Inst Instance=new A039900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039901
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,5L,8L,12L,18L,25L,37L,49L,68L,91L,123L,165L,215L,278L,362L,465L,603L,760L,962L,1209L,1524L,1911L,2374L,2934L,3629L,4471L,5514L,6728L,8208L,9982L,12139L,14720L,17772L,21390L,25732L,30889L,37049L,44231L,52749L,62782L,74671L,88640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039901Inst : IEnumerable<long>
{
public static readonly long[] Value=A039901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039901.Bytes);
public long this[int i]=>Value[i];

public static A039901Inst Instance=new A039901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039902
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,6L,9L,13L,19L,27L,39L,52L,71L,95L,127L,170L,220L,286L,371L,474L,614L,770L,979L,1229L,1541L,1934L,2392L,2968L,3668L,4504L,5556L,6764L,8271L,10055L,12199L,14798L,17836L,21504L,25860L,30996L,37185L,44348L,52943L,63003L,74856L,88874L,105165L,124376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039902Inst : IEnumerable<long>
{
public static readonly long[] Value=A039902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039902.Bytes);
public long this[int i]=>Value[i];

public static A039902Inst Instance=new A039902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039903
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,6L,9L,13L,19L,27L,40L,53L,72L,96L,130L,172L,225L,290L,376L,482L,619L,783L,990L,1242L,1561L,1945L,2421L,2992L,3697L,4545L,5583L,6819L,8321L,10113L,12279L,14851L,17940L,21597L,25971L,31140L,37289L,44531L,53115L,63199L,75108L,89063L,105481L,124672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039903Inst : IEnumerable<long>
{
public static readonly long[] Value=A039903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039903.Bytes);
public long this[int i]=>Value[i];

public static A039903Inst Instance=new A039903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039904
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,7L,9L,14L,20L,28L,41L,54L,74L,99L,131L,174L,226L,294L,380L,485L,623L,785L,996L,1249L,1565L,1952L,2425L,3001L,3707L,4553L,5592L,6828L,8334L,10128L,12291L,14866L,17954L,21617L,25991L,31159L,37311L,44554L,53141L,63229L,75137L,89096L,105515L,124711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039904Inst : IEnumerable<long>
{
public static readonly long[] Value=A039904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039904.Bytes);
public long this[int i]=>Value[i];

public static A039904Inst Instance=new A039904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039905
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,15L,22L,30L,41L,55L,75L,98L,130L,168L,219L,280L,360L,455L,577L,724L,908L,1129L,1405L,1733L,2138L,2621L,3210L,3910L,4759L,5763L,6973L,8402L,10110L,12123L,14519L,17330L,20660L,24560L,29157L,34525L,40830L,48170L,56760L,66739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039905Inst : IEnumerable<long>
{
public static readonly long[] Value=A039905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039905.Bytes);
public long this[int i]=>Value[i];

public static A039905Inst Instance=new A039905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039906
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,2L,4L,5L,6L,9L,11L,12L,19L,22L,30L,34L,44L,54L,69L,86L,103L,123L,157L,187L,232L,276L,331L,399L,490L,579L,698L,820L,983L,1179L,1398L,1646L,1944L,2288L,2730L,3190L,3758L,4374L,5136L,6043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039906Inst : IEnumerable<long>
{
public static readonly long[] Value=A039906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039906.Bytes);
public long this[int i]=>Value[i];

public static A039906Inst Instance=new A039906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039907
{
public static readonly BigInteger[] Value={ 1L,0L,0L,2L,6L,0L,0L,2196L,37004L,0L,0L,2317631400L,216893681800L,0L,0L,2326335506123418128L,BigInteger.Parse("1208982377794384163088"),0L,0L,BigInteger.Parse("2220650888749669503773432361504"),BigInteger.Parse("6408743336016148761893699822360672"),0L,0L,BigInteger.Parse("2015895925780490675949731718780144934779733312") };
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
public class A039907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A039907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A039907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A039907Inst Instance=new A039907Inst();

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