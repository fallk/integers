using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A155905
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,24L,25L,27L,30L,31L,33L,36L,38L,42L,43L,46L,49L,50L,51L,54L,55L,57L,58L,60L,64L,65L,73L,74L,84L,93L,106L,108L,123L,126L,129L,139L,150L,162L,183L,187L,196L,198L,220L,271L,273L,279L,301L,312L,379L,392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155905Inst : IEnumerable<long>
{
public static readonly long[] Value=A155905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155905.Bytes);
public long this[int i]=>Value[i];

public static A155905Inst Instance=new A155905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155906
{
public static readonly long[] Value={ 1L,0L,6L,4L,8L,8L,6L,8L,0L,4L,6L,2L,2L,0L,4L,5L,9L,4L,4L,3L,2L,1L,1L,0L,1L,9L,2L,0L,0L,4L,0L,5L,9L,1L,2L,0L,6L,3L,1L,6L,0L,6L,7L,1L,2L,0L,4L,6L,3L,0L,6L,4L,0L,3L,8L,5L,9L,2L,1L,4L,9L,6L,8L,7L,0L,5L,0L,8L,2L,4L,2L,1L,8L,5L,4L,7L,9L,9L,3L,3L,9L,8L,9L,9L,1L,0L,6L,5L,1L,9L,3L,5L,9L,0L,6L,1L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155906Inst : IEnumerable<long>
{
public static readonly long[] Value=A155906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155906.Bytes);
public long this[int i]=>Value[i];

public static A155906Inst Instance=new A155906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155907
{
public static readonly long[] Value={ 1L,0L,4L,6L,6L,5L,3L,6L,8L,2L,5L,0L,9L,9L,3L,6L,6L,8L,7L,3L,3L,9L,7L,6L,2L,7L,9L,3L,0L,6L,1L,5L,0L,6L,7L,5L,9L,0L,0L,6L,1L,7L,7L,4L,8L,0L,4L,8L,2L,2L,1L,7L,3L,4L,9L,6L,8L,1L,5L,9L,9L,9L,1L,7L,4L,7L,5L,8L,1L,3L,1L,4L,5L,4L,0L,7L,8L,2L,1L,1L,6L,5L,8L,0L,1L,7L,5L,7L,5L,0L,8L,0L,8L,1L,9L,7L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155907Inst : IEnumerable<long>
{
public static readonly long[] Value=A155907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155907.Bytes);
public long this[int i]=>Value[i];

public static A155907Inst Instance=new A155907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155908
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,27L,27L,1L,1L,156L,262L,156L,1L,1L,1375L,2560L,2560L,1375L,1L,1L,16998L,33303L,34052L,33303L,16998L,1L,1L,262591L,576261L,546875L,546875L,576261L,262591L,1L,1L,4783992L,12054460L,11922248L,9222918L,11922248L,12054460L,4783992L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155908Inst : IEnumerable<long>
{
public static readonly long[] Value=A155908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155908.Bytes);
public long this[int i]=>Value[i];

public static A155908Inst Instance=new A155908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155909
{
public static readonly long[] Value={ 1L,0L,2L,9L,8L,8L,0L,4L,7L,5L,5L,3L,1L,5L,7L,5L,2L,8L,9L,6L,0L,5L,9L,9L,9L,9L,8L,9L,2L,6L,3L,5L,6L,3L,1L,2L,6L,0L,6L,5L,8L,0L,6L,4L,9L,0L,7L,9L,8L,2L,7L,7L,5L,0L,3L,2L,3L,4L,7L,3L,4L,6L,9L,6L,8L,9L,6L,8L,2L,5L,9L,9L,4L,7L,8L,2L,4L,1L,8L,2L,0L,2L,6L,7L,4L,3L,3L,2L,2L,4L,4L,2L,3L,9L,8L,1L,4L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155909Inst : IEnumerable<long>
{
public static readonly long[] Value=A155909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155909.Bytes);
public long this[int i]=>Value[i];

public static A155909Inst Instance=new A155909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155910
{
public static readonly long[] Value={ 1L,0L,1L,4L,3L,8L,0L,8L,3L,2L,1L,1L,1L,3L,6L,0L,5L,0L,9L,0L,9L,3L,5L,4L,9L,5L,6L,5L,4L,5L,9L,5L,8L,2L,0L,1L,7L,8L,4L,5L,5L,0L,6L,0L,8L,5L,4L,6L,9L,3L,1L,3L,1L,9L,1L,8L,2L,6L,2L,8L,7L,9L,2L,0L,4L,7L,6L,3L,4L,6L,9L,6L,4L,8L,1L,5L,5L,0L,7L,0L,7L,9L,3L,2L,1L,4L,1L,5L,9L,1L,0L,9L,6L,3L,2L,3L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155910Inst : IEnumerable<long>
{
public static readonly long[] Value=A155910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155910.Bytes);
public long this[int i]=>Value[i];

public static A155910Inst Instance=new A155910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155911
{
public static readonly long[] Value={ 22L,24L,54L,62L,63L,82L,84L,96L,104L,122L,142L,153L,184L,202L,204L,216L,234L,262L,273L,294L,302L,333L,336L,343L,344L,362L,363L,364L,382L,405L,414L,416L,422L,423L,424L,444L,482L,483L,484L,486L,502L,542L,562L,564L,584L,603L,622L,644L,662L,663L,664L,675L,714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155911Inst : IEnumerable<long>
{
public static readonly long[] Value=A155911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155911.Bytes);
public long this[int i]=>Value[i];

public static A155911Inst Instance=new A155911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155912
{
public static readonly long[] Value={ 3L,1L,5L,1L,9L,3L,4L,2L,9L,1L,9L,5L,3L,6L,3L,1L,4L,1L,5L,5L,2L,4L,2L,5L,1L,1L,5L,1L,4L,6L,3L,9L,3L,4L,5L,5L,5L,1L,3L,6L,1L,2L,3L,1L,3L,3L,1L,6L,9L,1L,3L,9L,5L,4L,3L,3L,6L,5L,3L,5L,5L,9L,3L,4L,1L,3L,6L,5L,1L,2L,5L,3L,2L,4L,5L,2L,4L,3L,5L,3L,3L,5L,2L,4L,5L,3L,1L,5L,5L,4L,9L,1L,5L,4L,1L,1L,6L,3L,2L,6L,3L,5L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155912Inst : IEnumerable<long>
{
public static readonly long[] Value=A155912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155912.Bytes);
public long this[int i]=>Value[i];

public static A155912Inst Instance=new A155912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155913
{
public static readonly long[] Value={ 23L,29L,31L,37L,53L,59L,71L,73L,79L,113L,127L,149L,163L,167L,211L,233L,239L,251L,257L,293L,307L,347L,349L,383L,389L,419L,431L,433L,439L,479L,491L,499L,503L,509L,521L,523L,563L,569L,587L,613L,617L,619L,653L,659L,673L,677L,701L,709L,743L,761L,769L,839L,853L,857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155913Inst : IEnumerable<long>
{
public static readonly long[] Value=A155913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155913.Bytes);
public long this[int i]=>Value[i];

public static A155913Inst Instance=new A155913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155914
{
public static readonly long[] Value={ 0L,11L,7L,4L,2L,9L,3L,8L,10L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155914Inst : IEnumerable<long>
{
public static readonly long[] Value=A155914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155914.Bytes);
public long this[int i]=>Value[i];

public static A155914Inst Instance=new A155914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155915
{
public static readonly long[] Value={ 1L,2L,2L,13L,22L,13L,172L,308L,308L,172L,3281L,7276L,5766L,7276L,3281L,80526L,228822L,174492L,174492L,228822L,80526L,2413405L,8495474L,8083699L,4592764L,8083699L,8495474L,2413405L,85429688L,359918120L,440763192L,220914920L,220914920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155915Inst : IEnumerable<long>
{
public static readonly long[] Value=A155915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155915.Bytes);
public long this[int i]=>Value[i];

public static A155915Inst Instance=new A155915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155916
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,29L,37L,41L,43L,47L,59L,67L,71L,73L,89L,97L,101L,103L,113L,127L,131L,139L,149L,151L,157L,163L,179L,191L,193L,199L,223L,233L,239L,251L,263L,269L,277L,281L,283L,307L,311L,313L,331L,337L,347L,353L,359L,367L,373L,389L,397L,401L,419L,431L,433L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155916Inst : IEnumerable<long>
{
public static readonly long[] Value=A155916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155916.Bytes);
public long this[int i]=>Value[i];

public static A155916Inst Instance=new A155916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155917
{
public static readonly long[] Value={ -3L,-2L,-2L,0L,240L,0L,3360L,3360L,-5L,30380L,105570L,30380L,-5L,-18L,232710L,2032620L,2032620L,232710L,-18L,-42L,1637748L,31186890L,74043480L,31186890L,1637748L,-42L,-80L,10932880L,420179760L,1990483600L,1990483600L,420179760L,10932880L,-80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155917Inst : IEnumerable<long>
{
public static readonly long[] Value=A155917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155917.Bytes);
public long this[int i]=>Value[i];

public static A155917Inst Instance=new A155917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155918
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,7L,5L,7L,10L,11L,9L,13L,14L,15L,9L,17L,14L,19L,15L,21L,22L,23L,15L,25L,26L,21L,21L,29L,30L,31L,17L,33L,34L,35L,21L,37L,38L,39L,25L,41L,42L,43L,33L,35L,46L,47L,27L,43L,50L,51L,39L,53L,42L,55L,35L,57L,58L,59L,45L,61L,62L,49L,33L,65L,66L,67L,51L,69L,70L,71L,35L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155918Inst : IEnumerable<long>
{
public static readonly long[] Value=A155918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155918.Bytes);
public long this[int i]=>Value[i];

public static A155918Inst Instance=new A155918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155919
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,7L,9L,10L,11L,12L,13L,14L,15L,14L,17L,18L,19L,20L,21L,22L,23L,21L,25L,26L,27L,28L,29L,30L,31L,27L,33L,34L,35L,36L,37L,38L,39L,35L,41L,42L,43L,44L,45L,46L,47L,42L,49L,50L,51L,52L,53L,54L,55L,49L,57L,58L,59L,60L,61L,62L,63L,54L,65L,66L,67L,68L,69L,70L,71L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155919Inst : IEnumerable<long>
{
public static readonly long[] Value=A155919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155919.Bytes);
public long this[int i]=>Value[i];

public static A155919Inst Instance=new A155919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155920
{
public static readonly long[] Value={ 9L,8L,6L,6L,0L,8L,2L,7L,7L,6L,7L,8L,5L,0L,1L,0L,1L,5L,9L,1L,2L,9L,6L,9L,9L,1L,1L,4L,6L,9L,9L,9L,2L,1L,9L,2L,2L,4L,3L,1L,5L,7L,9L,2L,0L,8L,4L,6L,1L,5L,5L,4L,3L,3L,2L,3L,5L,4L,6L,6L,3L,1L,1L,8L,1L,3L,2L,8L,0L,7L,5L,2L,4L,2L,7L,6L,6L,0L,6L,3L,9L,5L,7L,4L,9L,2L,8L,9L,0L,2L,8L,7L,6L,5L,8L,7L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155920Inst : IEnumerable<long>
{
public static readonly long[] Value=A155920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155920.Bytes);
public long this[int i]=>Value[i];

public static A155920Inst Instance=new A155920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155921
{
public static readonly long[] Value={ 4L,5L,8L,4L,9L,6L,2L,5L,0L,0L,7L,2L,1L,1L,5L,6L,1L,8L,1L,4L,5L,3L,7L,3L,8L,9L,4L,3L,9L,4L,7L,8L,1L,6L,5L,0L,8L,7L,5L,9L,8L,1L,4L,4L,0L,7L,6L,9L,2L,4L,8L,1L,0L,6L,0L,4L,5L,5L,7L,5L,2L,6L,5L,4L,5L,4L,1L,0L,9L,8L,2L,2L,7L,7L,9L,4L,3L,5L,8L,5L,6L,2L,5L,2L,2L,2L,8L,0L,4L,7L,4L,9L,1L,8L,0L,8L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155921Inst : IEnumerable<long>
{
public static readonly long[] Value=A155921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155921.Bytes);
public long this[int i]=>Value[i];

public static A155921Inst Instance=new A155921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155922
{
public static readonly long[] Value={ 2L,8L,9L,2L,7L,8L,9L,2L,6L,0L,7L,1L,4L,3L,7L,2L,3L,1L,1L,2L,9L,8L,5L,8L,1L,3L,4L,3L,0L,2L,8L,2L,8L,2L,5L,6L,2L,8L,9L,8L,7L,5L,6L,9L,2L,0L,3L,9L,5L,6L,4L,1L,2L,8L,3L,6L,1L,1L,9L,6L,4L,8L,3L,1L,5L,1L,6L,0L,5L,5L,6L,0L,4L,1L,4L,2L,7L,4L,4L,4L,1L,5L,1L,8L,3L,5L,1L,8L,0L,6L,5L,6L,4L,8L,3L,5L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155922Inst : IEnumerable<long>
{
public static readonly long[] Value=A155922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155922.Bytes);
public long this[int i]=>Value[i];

public static A155922Inst Instance=new A155922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155923
{
public static readonly long[] Value={ 13L,17L,25L,53L,85L,137L,305L,493L,797L,1777L,2873L,4645L,10357L,16745L,27073L,60365L,97597L,157793L,351833L,568837L,919685L,2050633L,3315425L,5360317L,11951965L,19323713L,31242217L,69661157L,112626853L,182092985L,406014977L,656437405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155923Inst : IEnumerable<long>
{
public static readonly long[] Value=A155923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155923.Bytes);
public long this[int i]=>Value[i];

public static A155923Inst Instance=new A155923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155924
{
public static readonly BigInteger[] Value={ 131L,151L,313L,383L,797L,3288823L,7493947L,312989213L,79091719097L,1884468644881L,191259232952191L,13388297179288331L,3101199511159911013L,BigInteger.Parse("327274601898106472723"),BigInteger.Parse("1208438177787877718348021"),BigInteger.Parse("301692965738393837569296103") };
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
public class A155924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155924Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155924.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155924.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155924Inst Instance=new A155924Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155925
{
public static readonly long[] Value={ 1373L,1319L,1033L,1493L,853L,839L,593L,1093L,461L,487L,281L,821L,197L,263L,97L,677L,61L,167L,41L,661L,53L,199L,113L,773L,173L,359L,313L,1013L,421L,647L,641L,1381L,797L,1063L,1097L,1877L,1301L,1607L,2333L,1847L,1933L,2203L,2393L,3253L,2693L,3079L,3121L,4133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155925Inst : IEnumerable<long>
{
public static readonly long[] Value=A155925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155925.Bytes);
public long this[int i]=>Value[i];

public static A155925Inst Instance=new A155925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155926
{
public static readonly BigInteger[] Value={ 1L,1L,4L,37L,621L,16526L,640207L,34039027L,2379382609L,211619306134L,23337543447296L,3125553148981176L,499716551101393705L,BigInteger.Parse("94016487294245251308"),BigInteger.Parse("20561796731966531616954"),BigInteger.Parse("5172827581575899147920471") };
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
public class A155926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155926Inst Instance=new A155926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155927
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,19L,-379L,12726L,-641465L,45181627L,-4232016719L,508271819428L,-76108505872794L,13896010073569130L,-3038043685025188631L,BigInteger.Parse("783439451518414509612"),BigInteger.Parse("-235289860249420249309140") };
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
public class A155927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155927.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155927Inst Instance=new A155927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155928
{
public static readonly BigInteger[] Value={ 1L,2L,11L,122L,2302L,66482L,2735721L,152359874L,11048880926L,1012437290342L,114445632250776L,15649612498128050L,2546878326578431588L,BigInteger.Parse("486567378291992448726"),BigInteger.Parse("107845834421517755737817") };
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
public class A155928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155928.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155928Inst Instance=new A155928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155929
{
public static readonly long[] Value={ 2L,3L,9L,12L,30L,57L,66L,87L,111L,120L,195L,243L,246L,279L,378L,381L,432L,450L,471L,480L,597L,651L,759L,810L,933L,987L,1053L,1356L,1362L,1404L,1407L,1410L,1548L,1563L,1638L,1752L,1758L,1998L,2016L,2115L,2157L,2259L,2280L,2385L,2499L,2607L,2775L,2817L,2826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155929Inst : IEnumerable<long>
{
public static readonly long[] Value=A155929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155929.Bytes);
public long this[int i]=>Value[i];

public static A155929Inst Instance=new A155929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155930
{
public static readonly long[] Value={ 8L,27L,729L,1728L,27000L,185193L,287496L,658503L,1367631L,1728000L,7414875L,14348907L,14886936L,21717639L,54010152L,55306341L,80621568L,91125000L,104487111L,110592000L,212776173L,275894451L,437245479L,531441000L,812166237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155930Inst : IEnumerable<long>
{
public static readonly long[] Value=A155930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155930.Bytes);
public long this[int i]=>Value[i];

public static A155930Inst Instance=new A155930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155931
{
public static readonly long[] Value={ 4L,9L,81L,144L,900L,3249L,4356L,7569L,12321L,14400L,38025L,59049L,60516L,77841L,142884L,145161L,186624L,202500L,221841L,230400L,356409L,423801L,576081L,656100L,870489L,974169L,1108809L,1838736L,1855044L,1971216L,1979649L,1988100L,2396304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155931Inst : IEnumerable<long>
{
public static readonly long[] Value=A155931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155931.Bytes);
public long this[int i]=>Value[i];

public static A155931Inst Instance=new A155931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155932
{
public static readonly long[] Value={ 3L,6L,7L,8L,10L,13L,15L,18L,20L,21L,22L,28L,33L,35L,37L,39L,42L,43L,45L,48L,52L,57L,58L,60L,62L,63L,68L,72L,73L,75L,77L,78L,80L,82L,83L,85L,86L,87L,90L,91L,92L,93L,95L,97L,99L,102L,103L,105L,106L,107L,108L,111L,112L,113L,115L,117L,120L,123L,125L,128L,129L,132L,133L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155932Inst : IEnumerable<long>
{
public static readonly long[] Value=A155932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155932.Bytes);
public long this[int i]=>Value[i];

public static A155932Inst Instance=new A155932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155933
{
public static readonly long[] Value={ 31L,73L,241L,379L,2341L,3571L,6121L,9661L,20359L,47881L,51949L,60763L,65521L,119953L,135151L,291721L,305119L,378289L,394201L,427351L,537841L,689041L,736921L,761671L,921889L,1202041L,1271161L,1306693L,1494313L,1533871L,1742161L,1785961L,1875751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155933Inst : IEnumerable<long>
{
public static readonly long[] Value=A155933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155933.Bytes);
public long this[int i]=>Value[i];

public static A155933Inst Instance=new A155933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155934
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155934Inst : IEnumerable<long>
{
public static readonly long[] Value=A155934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155934.Bytes);
public long this[int i]=>Value[i];

public static A155934Inst Instance=new A155934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155935
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,63L,64L,65L,67L,68L,69L,70L,71L,73L,75L,76L,77L,79L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155935Inst : IEnumerable<long>
{
public static readonly long[] Value=A155935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155935.Bytes);
public long this[int i]=>Value[i];

public static A155935Inst Instance=new A155935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155936
{
public static readonly long[] Value={ 2L,2L,9L,2L,4L,8L,1L,2L,5L,0L,3L,6L,0L,5L,7L,8L,0L,9L,0L,7L,2L,6L,8L,6L,9L,4L,7L,1L,9L,7L,3L,9L,0L,8L,2L,5L,4L,3L,7L,9L,9L,0L,7L,2L,0L,3L,8L,4L,6L,2L,4L,0L,5L,3L,0L,2L,2L,7L,8L,7L,6L,3L,2L,7L,2L,7L,0L,5L,4L,9L,1L,1L,3L,8L,9L,7L,1L,7L,9L,2L,8L,1L,2L,6L,1L,1L,4L,0L,2L,3L,7L,4L,5L,9L,0L,4L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155936Inst : IEnumerable<long>
{
public static readonly long[] Value=A155936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155936.Bytes);
public long this[int i]=>Value[i];

public static A155936Inst Instance=new A155936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155937
{
public static readonly long[] Value={ 3L,5L,11L,17L,21L,23L,27L,35L,41L,45L,47L,63L,65L,75L,77L,81L,83L,93L,101L,105L,107L,111L,123L,137L,143L,153L,165L,167L,177L,195L,201L,203L,207L,213L,215L,231L,233L,237L,243L,251L,255L,273L,275L,287L,303L,311L,317L,327L,333L,335L,341L,345L,347L,353L,357L,371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155937Inst : IEnumerable<long>
{
public static readonly long[] Value=A155937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155937.Bytes);
public long this[int i]=>Value[i];

public static A155937Inst Instance=new A155937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155938
{
public static readonly long[] Value={ 3L,5L,11L,17L,23L,41L,47L,83L,101L,107L,137L,167L,233L,251L,311L,317L,347L,353L,383L,467L,503L,521L,587L,593L,647L,683L,761L,797L,857L,941L,1013L,1031L,1103L,1181L,1187L,1223L,1301L,1433L,1493L,1571L,1607L,1721L,1847L,1907L,1913L,1931L,1973L,1997L,2081L,2153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155938Inst : IEnumerable<long>
{
public static readonly long[] Value=A155938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155938.Bytes);
public long this[int i]=>Value[i];

public static A155938Inst Instance=new A155938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155939
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,19L,20L,22L,24L,25L,26L,28L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,42L,43L,44L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,64L,66L,67L,68L,69L,70L,71L,72L,73L,74L,76L,78L,79L,80L,82L,84L,85L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155939Inst : IEnumerable<long>
{
public static readonly long[] Value=A155939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155939.Bytes);
public long this[int i]=>Value[i];

public static A155939Inst Instance=new A155939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155940
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,3L,4L,4L,5L,3L,4L,5L,6L,6L,4L,5L,5L,6L,7L,7L,4L,5L,6L,7L,7L,8L,9L,5L,6L,6L,7L,8L,8L,9L,10L,5L,6L,7L,8L,8L,9L,10L,10L,11L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,6L,7L,8L,9L,9L,10L,11L,11L,12L,13L,13L,7L,8L,8L,9L,10L,10L,11L,12L,12L,13L,14L,14L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155940Inst : IEnumerable<long>
{
public static readonly long[] Value=A155940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155940.Bytes);
public long this[int i]=>Value[i];

public static A155940Inst Instance=new A155940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155941
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,8L,9L,10L,11L,13L,14L,17L,18L,19L,20L,23L,24L,26L,29L,30L,31L,32L,33L,34L,35L,38L,39L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,56L,57L,59L,60L,62L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,77L,79L,80L,82L,83L,84L,86L,87L,89L,90L,91L,92L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155941Inst : IEnumerable<long>
{
public static readonly long[] Value=A155941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155941.Bytes);
public long this[int i]=>Value[i];

public static A155941Inst Instance=new A155941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155942
{
public static readonly long[] Value={ 1L,6L,7L,12L,15L,16L,21L,22L,25L,27L,28L,36L,37L,40L,42L,48L,55L,58L,61L,63L,72L,75L,76L,78L,81L,85L,88L,93L,97L,100L,106L,111L,117L,118L,126L,130L,132L,133L,135L,142L,151L,162L,163L,166L,168L,172L,175L,177L,181L,190L,193L,195L,196L,198L,201L,207L,208L,210L,216L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155942Inst : IEnumerable<long>
{
public static readonly long[] Value=A155942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155942.Bytes);
public long this[int i]=>Value[i];

public static A155942Inst Instance=new A155942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155943
{
public static readonly long[] Value={ 7L,37L,61L,97L,151L,163L,181L,193L,271L,313L,331L,337L,397L,421L,487L,523L,547L,571L,643L,691L,727L,757L,853L,877L,967L,1033L,1087L,1093L,1231L,1237L,1297L,1303L,1423L,1471L,1567L,1657L,1747L,1777L,1801L,1831L,1867L,1987L,2083L,2113L,2221L,2251L,2281L,2437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155943Inst : IEnumerable<long>
{
public static readonly long[] Value=A155943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155943.Bytes);
public long this[int i]=>Value[i];

public static A155943Inst Instance=new A155943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155944
{
public static readonly long[] Value={ 0L,2L,1L,4L,5L,12L,21L,44L,85L,172L,341L,684L,1365L,2732L,5461L,10924L,21845L,43692L,87381L,174764L,349525L,699052L,1398101L,2796204L,5592405L,11184812L,22369621L,44739244L,89478485L,178956972L,357913941L,715827884L,1431655765L,2863311532L,5726623061L,11453246124L,22906492245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155944Inst : IEnumerable<long>
{
public static readonly long[] Value=A155944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155944.Bytes);
public long this[int i]=>Value[i];

public static A155944Inst Instance=new A155944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155945
{
public static readonly long[] Value={ 3L,5L,8L,10L,12L,13L,18L,19L,20L,21L,23L,24L,26L,28L,32L,33L,37L,38L,39L,40L,43L,47L,48L,49L,52L,53L,54L,55L,56L,58L,61L,62L,63L,65L,68L,71L,73L,75L,76L,78L,79L,81L,82L,83L,86L,87L,88L,89L,90L,91L,93L,96L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155945Inst : IEnumerable<long>
{
public static readonly long[] Value=A155945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155945.Bytes);
public long this[int i]=>Value[i];

public static A155945Inst Instance=new A155945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155946
{
public static readonly long[] Value={ 0L,1L,7L,8L,17L,24L,31L,48L,49L,71L,80L,97L,120L,127L,161L,168L,199L,224L,241L,287L,288L,337L,360L,391L,440L,449L,511L,528L,577L,624L,647L,721L,728L,799L,840L,881L,960L,967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155946Inst : IEnumerable<long>
{
public static readonly long[] Value=A155946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155946.Bytes);
public long this[int i]=>Value[i];

public static A155946Inst Instance=new A155946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155947
{
public static readonly long[] Value={ 1L,1L,2L,5L,-6L,5L,19L,-13L,-13L,19L,337L,-1044L,1462L,-1044L,337L,2101L,-5073L,3092L,3092L,-5073L,2101L,62281L,-314222L,718559L,-931796L,718559L,-314222L,62281L,543607L,-2329829L,3835365L,-2044103L,-2044103L,3835365L,-2329829L,543607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155947Inst : IEnumerable<long>
{
public static readonly long[] Value=A155947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155947.Bytes);
public long this[int i]=>Value[i];

public static A155947Inst Instance=new A155947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155948
{
public static readonly long[] Value={ 2L,6L,6L,34L,206L,206L,34L,370L,4840L,14950L,14950L,4840L,370L,6642L,142644L,792216L,1719618L,1719618L,792216L,142644L,6642L,161294L,5282074L,45682504L,158295424L,274902544L,274902544L,158295424L,45682504L,5282074L,161294L,4827538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155948Inst : IEnumerable<long>
{
public static readonly long[] Value=A155948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155948.Bytes);
public long this[int i]=>Value[i];

public static A155948Inst Instance=new A155948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155949
{
public static readonly long[] Value={ 16355881L,109909799L,156177433L,167667607L,169177649L,196805633L,320142863L,428366489L,610038257L,644062919L,1103804483L,1164167891L,1184418737L,1493813903L,1541169463L,1882406467L,1956211891L,2018075911L,2248153673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155949Inst : IEnumerable<long>
{
public static readonly long[] Value=A155949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155949.Bytes);
public long this[int i]=>Value[i];

public static A155949Inst Instance=new A155949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155950
{
public static readonly long[] Value={ 1L,1L,2L,2L,8L,8L,26L,22L,22L,26L,272L,-64L,352L,-64L,272L,2882L,-486L,1444L,1444L,-486L,2882L,50752L,-93056L,230336L,-283904L,230336L,-93056L,50752L,745418L,-1182562L,2112618L,-1030354L,-1030354L,2112618L,-1182562L,745418L,18456832L,-66045952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155950Inst : IEnumerable<long>
{
public static readonly long[] Value=A155950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155950.Bytes);
public long this[int i]=>Value[i];

public static A155950Inst Instance=new A155950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155951
{
public static readonly long[] Value={ 2L,4L,17L,-10L,17L,208L,-88L,-88L,208L,4177L,-4708L,4422L,-4708L,4177L,98976L,-123888L,55152L,55152L,-123888L,98976L,3001609L,-5204582L,5360567L,-4984628L,5360567L,-5204582L,3001609L,105133568L,-210753520L,208361232L,-85444000L,-85444000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155951Inst : IEnumerable<long>
{
public static readonly long[] Value=A155951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155951.Bytes);
public long this[int i]=>Value[i];

public static A155951Inst Instance=new A155951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155952
{
public static readonly long[] Value={ 2L,4L,4L,48L,48L,728L,232L,232L,728L,20752L,5312L,1632L,5312L,20752L,759132L,168684L,39864L,39864L,168684L,759132L,34016320L,5788288L,3904448L,-2262272L,3904448L,5788288L,34016320L,1801010416L,223429840L,253864944L,-64253360L,-64253360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155952Inst : IEnumerable<long>
{
public static readonly long[] Value=A155952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155952.Bytes);
public long this[int i]=>Value[i];

public static A155952Inst Instance=new A155952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155953
{
public static readonly long[] Value={ 71L,97L,113L,347L,743L,971L,1033L,1097L,1231L,1301L,1523L,1601L,1847L,1933L,3011L,3121L,3347L,3463L,7523L,9161L,9547L,9941L,10343L,12697L,13151L,15541L,15791L,17863L,30491L,31193L,32261L,32983L,39047L,70001L,72671L,74843L,75941L,77047L,79847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155953Inst : IEnumerable<long>
{
public static readonly long[] Value=A155953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155953.Bytes);
public long this[int i]=>Value[i];

public static A155953Inst Instance=new A155953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155954
{
public static readonly long[] Value={ 2L,3L,5L,11L,19L,37L,67L,127L,233L,431L,797L,1471L,2699L,4967L,9137L,16811L,30931L,56891L,104639L,192461L,354001L,651103L,1197571L,2202677L,4051361L,7451617L,13705667L,25208653L,46365959L,85280323L,156854959L,288501287L,530636569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155954Inst : IEnumerable<long>
{
public static readonly long[] Value=A155954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155954.Bytes);
public long this[int i]=>Value[i];

public static A155954Inst Instance=new A155954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155955
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,16L,1L,3L,36L,729L,1L,4L,64L,1728L,65536L,1L,5L,100L,3375L,160000L,9765625L,1L,6L,144L,5832L,331776L,24300000L,2176782336L,1L,7L,196L,9261L,614656L,52521875L,5489031744L,678223072849L,1L,8L,256L,13824L,1048576L,102400000L,12230590464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155955Inst : IEnumerable<long>
{
public static readonly long[] Value=A155955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155955.Bytes);
public long this[int i]=>Value[i];

public static A155955Inst Instance=new A155955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155956
{
public static readonly BigInteger[] Value={ 1L,2L,19L,769L,67333L,9929106L,2201420095L,683765250589L,283214405613321L,150820803395086078L,BigInteger.Parse("100389106493001087411"),BigInteger.Parse("81663040762574177095289"),BigInteger.Parse("79709457342800206602843277"),BigInteger.Parse("91941570967455757927336110570"),BigInteger.Parse("123717598784707453088183544702311") };
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
public class A155956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155956Inst Instance=new A155956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155957
{
public static readonly BigInteger[] Value={ 1L,2L,64L,5832L,1048576L,312500000L,139314069504L,86812553324672L,72057594037927936L,BigInteger.Parse("76848453272063549952"),BigInteger.Parse("102400000000000000000000"),BigInteger.Parse("166712830744247830760081408"),BigInteger.Parse("325619086145088897570576531456") };
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
public class A155957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155957Inst Instance=new A155957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155958
{
public static readonly long[] Value={ 1L,9L,7L,4L,6L,3L,5L,8L,6L,8L,7L,0L,6L,1L,6L,4L,4L,4L,7L,1L,4L,4L,8L,8L,6L,0L,6L,5L,5L,6L,2L,9L,4L,9L,1L,4L,9L,2L,3L,4L,0L,4L,5L,1L,9L,6L,1L,1L,2L,4L,4L,8L,5L,5L,7L,6L,2L,5L,9L,8L,4L,8L,0L,5L,3L,7L,5L,7L,3L,2L,4L,1L,0L,5L,4L,0L,5L,6L,9L,7L,9L,5L,5L,8L,8L,0L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155958Inst : IEnumerable<long>
{
public static readonly long[] Value=A155958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155958.Bytes);
public long this[int i]=>Value[i];

public static A155958Inst Instance=new A155958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155959
{
public static readonly long[] Value={ 1L,7L,7L,3L,7L,0L,5L,6L,1L,4L,4L,6L,9L,0L,8L,3L,1L,7L,3L,7L,4L,0L,4L,9L,2L,2L,7L,6L,9L,3L,5L,6L,4L,1L,7L,5L,2L,9L,3L,0L,2L,8L,3L,7L,1L,8L,9L,1L,4L,2L,0L,6L,8L,5L,6L,7L,7L,8L,9L,8L,9L,8L,5L,7L,6L,5L,3L,2L,8L,4L,0L,3L,7L,0L,8L,1L,4L,4L,5L,6L,0L,7L,6L,6L,3L,3L,0L,4L,6L,0L,0L,5L,8L,9L,6L,3L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155959Inst : IEnumerable<long>
{
public static readonly long[] Value=A155959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155959.Bytes);
public long this[int i]=>Value[i];

public static A155959Inst Instance=new A155959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155960
{
public static readonly BigInteger[] Value={ 11177126654841000000UL,BigInteger.Parse("715336105909824000000"),BigInteger.Parse("8148125331379089000000") };
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
public class A155960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155960Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155960.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155960.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155960Inst Instance=new A155960Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155961
{
public static readonly long[] Value={ 3343221000L,26745768000L,90266967000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155961Inst : IEnumerable<long>
{
public static readonly long[] Value=A155961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155961.Bytes);
public long this[int i]=>Value[i];

public static A155961Inst Instance=new A155961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155962
{
public static readonly long[] Value={ 1L,4L,11L,32L,56L,73L,80L,109L,122L,143L,158L,175L,182L,217L,256L,262L,280L,284L,290L,308L,343L,347L,403L,431L,434L,437L,535L,581L,598L,619L,655L,665L,928L,973L,980L,1018L,1036L,1046L,1096L,1120L,1159L,1207L,1222L,1235L,1267L,1382L,1393L,1439L,1460L,1463L,1501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155962Inst : IEnumerable<long>
{
public static readonly long[] Value=A155962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155962.Bytes);
public long this[int i]=>Value[i];

public static A155962Inst Instance=new A155962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155963
{
public static readonly long[] Value={ 2L,1L,3L,4L,5L,6L,7L,8L,11L,9L,10L,13L,12L,17L,14L,19L,15L,23L,16L,18L,21L,20L,29L,22L,31L,24L,37L,25L,26L,41L,27L,28L,43L,30L,47L,32L,34L,33L,35L,36L,53L,38L,59L,39L,40L,61L,42L,44L,67L,45L,46L,71L,48L,73L,49L,50L,52L,51L,54L,79L,55L,56L,83L,57L,58L,89L,60L,65L,62L,64L,63L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155963Inst : IEnumerable<long>
{
public static readonly long[] Value=A155963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155963.Bytes);
public long this[int i]=>Value[i];

public static A155963Inst Instance=new A155963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155964
{
public static readonly long[] Value={ 1L,6L,3L,3L,1L,9L,6L,5L,9L,5L,3L,7L,7L,6L,4L,6L,1L,4L,3L,3L,4L,7L,0L,8L,1L,4L,0L,1L,1L,7L,8L,7L,8L,0L,1L,2L,4L,0L,3L,6L,4L,9L,9L,3L,9L,9L,5L,0L,5L,2L,3L,3L,6L,9L,5L,1L,6L,4L,1L,3L,8L,6L,3L,5L,6L,8L,0L,3L,5L,5L,0L,5L,5L,2L,7L,8L,1L,8L,7L,5L,3L,3L,0L,0L,1L,9L,0L,3L,7L,4L,1L,2L,3L,3L,6L,7L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155964Inst : IEnumerable<long>
{
public static readonly long[] Value=A155964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155964.Bytes);
public long this[int i]=>Value[i];

public static A155964Inst Instance=new A155964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155965
{
public static readonly long[] Value={ 0L,5L,16L,39L,80L,145L,240L,371L,544L,765L,1040L,1375L,1776L,2249L,2800L,3435L,4160L,4981L,5904L,6935L,8080L,9345L,10736L,12259L,13920L,15725L,17680L,19791L,22064L,24505L,27120L,29915L,32896L,36069L,39440L,43015L,46800L,50801L,55024L,59475L,64160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155965Inst : IEnumerable<long>
{
public static readonly long[] Value=A155965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155965.Bytes);
public long this[int i]=>Value[i];

public static A155965Inst Instance=new A155965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155966
{
public static readonly long[] Value={ 8L,10L,16L,26L,40L,58L,80L,106L,136L,170L,208L,250L,296L,346L,400L,458L,520L,586L,656L,730L,808L,890L,976L,1066L,1160L,1258L,1360L,1466L,1576L,1690L,1808L,1930L,2056L,2186L,2320L,2458L,2600L,2746L,2896L,3050L,3208L,3370L,3536L,3706L,3880L,4058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155966Inst : IEnumerable<long>
{
public static readonly long[] Value=A155966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155966.Bytes);
public long this[int i]=>Value[i];

public static A155966Inst Instance=new A155966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155967
{
public static readonly long[] Value={ 11L,13L,257L,271L,277L,283L,293L,307L,317L,331L,337L,353L,359L,367L,383L,389L,409L,431L,433L,443L,449L,461L,463L,467L,479L,491L,503L,509L,32797L,32801L,32831L,32869L,32887L,32911L,32969L,32987L,32999L,33029L,33049L,33083L,33091L,33161L,33181L,33191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155967Inst : IEnumerable<long>
{
public static readonly long[] Value=A155967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155967.Bytes);
public long this[int i]=>Value[i];

public static A155967Inst Instance=new A155967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155968
{
public static readonly long[] Value={ 5L,7L,2L,3L,6L,4L,9L,4L,2L,9L,2L,4L,7L,0L,0L,0L,8L,7L,0L,7L,1L,7L,1L,3L,6L,7L,5L,6L,7L,6L,5L,2L,9L,3L,5L,5L,8L,2L,3L,6L,4L,7L,4L,0L,6L,4L,5L,7L,6L,5L,5L,7L,8L,5L,7L,5L,6L,8L,1L,1L,5L,3L,5L,7L,3L,6L,0L,6L,8L,8L,8L,4L,9L,4L,2L,4L,1L,3L,0L,3L,9L,8L,9L,1L,8L,1L,1L,6L,3L,5L,1L,3L,7L,7L,4L,4L,8L,5L,3L,8L,5L,1L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155968Inst : IEnumerable<long>
{
public static readonly long[] Value=A155968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155968.Bytes);
public long this[int i]=>Value[i];

public static A155968Inst Instance=new A155968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155969
{
public static readonly long[] Value={ 3L,3L,3L,1L,7L,7L,9L,2L,3L,8L,0L,7L,7L,1L,8L,6L,7L,4L,3L,1L,8L,3L,7L,6L,1L,3L,6L,3L,5L,5L,2L,4L,4L,2L,2L,6L,6L,5L,9L,4L,1L,7L,1L,4L,0L,2L,4L,9L,6L,2L,9L,7L,4L,3L,1L,5L,0L,8L,3L,3L,3L,3L,8L,0L,0L,2L,2L,6L,5L,7L,9L,3L,6L,9L,5L,7L,5L,6L,6L,6L,9L,6L,6L,1L,2L,6L,3L,2L,6L,8L,6L,3L,1L,7L,1L,5L,9L,7L,7L,3L,0L,3L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155969Inst : IEnumerable<long>
{
public static readonly long[] Value=A155969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155969.Bytes);
public long this[int i]=>Value[i];

public static A155969Inst Instance=new A155969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155970
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,4L,8L,4L,8L,1L,3L,6L,8L,1L,1L,0L,9L,5L,3L,5L,9L,9L,3L,5L,8L,9L,9L,1L,4L,1L,0L,2L,3L,5L,7L,9L,4L,7L,9L,7L,5L,9L,5L,6L,3L,5L,3L,3L,0L,2L,3L,7L,2L,7L,0L,1L,5L,1L,5L,5L,8L,2L,5L,5L,3L,1L,7L,7L,8L,2L,5L,2L,8L,0L,3L,0L,9L,6L,1L,2L,0L,6L,9L,2L,8L,9L,9L,1L,1L,7L,3L,3L,7L,6L,9L,3L,4L,2L,9L,1L,9L,3L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155970Inst : IEnumerable<long>
{
public static readonly long[] Value=A155970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155970.Bytes);
public long this[int i]=>Value[i];

public static A155970Inst Instance=new A155970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155971
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,8L,20L,8L,1L,1L,16L,160L,160L,16L,1L,1L,32L,2264L,17152L,2264L,32L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155971Inst : IEnumerable<long>
{
public static readonly long[] Value=A155971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155971.Bytes);
public long this[int i]=>Value[i];

public static A155971Inst Instance=new A155971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155972
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155972Inst : IEnumerable<long>
{
public static readonly long[] Value=A155972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155972.Bytes);
public long this[int i]=>Value[i];

public static A155972Inst Instance=new A155972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155973
{
public static readonly long[] Value={ 1L,1L,1L,11L,23L,1L,1L,75L,29L,27L,159L,27L,107L,179L,63L,93L,675L,593L,11L,1299L,153L,153L,197L,35L,31L,227L,297L,439L,33L,1L,133L,1L,3L,1071L,173L,153L,299L,5L,1443L,1275L,611L,1809L,941L,669L,537L,51L,151L,1L,131L,1L,1L,343L,199L,1L,279L,3L,1L,439L,597L,453L,1L,1L,1187L,391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155973Inst : IEnumerable<long>
{
public static readonly long[] Value=A155973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155973.Bytes);
public long this[int i]=>Value[i];

public static A155973Inst Instance=new A155973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155974
{
public static readonly long[] Value={ 37L,236L,513L,880L,1877L,2926L,4029L,5480L,7189L,8966L,11103L,13316L,16269L,19310L,22717L,26606L,30595L,34686L,39995L,47188L,55071L,66184L,79941L,95024L,111097L,128190L,156833L,185742L,216001L,248204L,283293L,319270L,360149L,402306L,445757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155974Inst : IEnumerable<long>
{
public static readonly long[] Value=A155974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155974.Bytes);
public long this[int i]=>Value[i];

public static A155974Inst Instance=new A155974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155975
{
public static readonly long[] Value={ 1L,5L,2L,8L,3L,2L,0L,8L,3L,3L,5L,7L,3L,7L,1L,8L,7L,2L,7L,1L,5L,1L,2L,4L,6L,3L,1L,4L,6L,4L,9L,2L,7L,2L,1L,6L,9L,5L,8L,6L,6L,0L,4L,8L,0L,2L,5L,6L,4L,1L,6L,0L,3L,5L,3L,4L,8L,5L,2L,5L,0L,8L,8L,4L,8L,4L,7L,0L,3L,2L,7L,4L,2L,5L,9L,8L,1L,1L,9L,5L,2L,0L,8L,4L,0L,7L,6L,0L,1L,5L,8L,3L,0L,6L,0L,2L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155975Inst : IEnumerable<long>
{
public static readonly long[] Value=A155975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155975.Bytes);
public long this[int i]=>Value[i];

public static A155975Inst Instance=new A155975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155976
{
public static readonly long[] Value={ 1L,4L,4L,6L,3L,9L,4L,6L,3L,0L,3L,5L,7L,1L,8L,6L,1L,5L,5L,6L,4L,9L,2L,9L,0L,6L,7L,1L,5L,1L,4L,1L,4L,1L,2L,8L,1L,4L,4L,9L,3L,7L,8L,4L,6L,0L,1L,9L,7L,8L,2L,0L,6L,4L,1L,8L,0L,5L,9L,8L,2L,4L,1L,5L,7L,5L,8L,0L,2L,7L,8L,0L,2L,0L,7L,1L,3L,7L,2L,2L,0L,7L,5L,9L,1L,7L,5L,9L,0L,3L,2L,8L,2L,4L,1L,7L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155976Inst : IEnumerable<long>
{
public static readonly long[] Value=A155976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155976.Bytes);
public long this[int i]=>Value[i];

public static A155976Inst Instance=new A155976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155977
{
public static readonly long[] Value={ 0L,2L,40L,270L,1088L,3250L,7992L,17150L,33280L,59778L,101000L,162382L,250560L,373490L,540568L,762750L,1052672L,1424770L,1895400L,2482958L,3208000L,4093362L,5164280L,6448510L,7976448L,9781250L,11898952L,14368590L,17232320L,20535538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155977Inst : IEnumerable<long>
{
public static readonly long[] Value=A155977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155977.Bytes);
public long this[int i]=>Value[i];

public static A155977Inst Instance=new A155977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155978
{
public static readonly long[] Value={ 2L,3L,5L,17L,23L,41L,53L,59L,101L,131L,137L,173L,179L,227L,233L,251L,311L,317L,353L,401L,419L,443L,461L,479L,509L,557L,563L,569L,587L,641L,647L,677L,683L,761L,773L,809L,821L,857L,863L,881L,941L,971L,977L,1013L,1031L,1049L,1181L,1193L,1223L,1229L,1259L,1277L,1283L,1367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155978Inst : IEnumerable<long>
{
public static readonly long[] Value=A155978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155978.Bytes);
public long this[int i]=>Value[i];

public static A155978Inst Instance=new A155978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155979
{
public static readonly long[] Value={ 1L,3L,8L,0L,2L,1L,1L,2L,4L,1L,7L,1L,1L,6L,0L,6L,0L,2L,2L,9L,3L,6L,2L,4L,4L,5L,8L,7L,4L,2L,8L,5L,9L,4L,3L,8L,9L,5L,0L,4L,6L,9L,8L,5L,0L,8L,5L,7L,7L,0L,2L,1L,4L,8L,8L,7L,6L,1L,1L,4L,8L,0L,2L,3L,6L,8L,6L,5L,5L,3L,7L,2L,0L,6L,0L,6L,9L,3L,4L,6L,5L,1L,5L,0L,3L,7L,5L,0L,1L,1L,2L,0L,0L,2L,1L,7L,4L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155979Inst : IEnumerable<long>
{
public static readonly long[] Value=A155979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155979.Bytes);
public long this[int i]=>Value[i];

public static A155979Inst Instance=new A155979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155980
{
public static readonly long[] Value={ 2L,-2L,3L,-1L,5L,3L,13L,19L,45L,83L,173L,339L,685L,1363L,2733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155980Inst : IEnumerable<long>
{
public static readonly long[] Value=A155980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155980.Bytes);
public long this[int i]=>Value[i];

public static A155980Inst Instance=new A155980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155981
{
public static readonly long[] Value={ 1L,3L,2L,5L,3L,5L,1L,3L,8L,8L,9L,4L,4L,9L,8L,9L,8L,0L,0L,2L,8L,0L,8L,5L,1L,2L,5L,6L,9L,9L,3L,5L,4L,3L,3L,1L,7L,4L,9L,8L,5L,0L,3L,2L,3L,3L,5L,8L,1L,9L,0L,5L,3L,3L,9L,5L,4L,1L,3L,4L,4L,1L,7L,5L,6L,2L,2L,8L,9L,3L,5L,5L,3L,2L,9L,5L,2L,5L,8L,5L,8L,0L,2L,4L,3L,3L,8L,7L,3L,2L,3L,1L,0L,2L,1L,7L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155981Inst : IEnumerable<long>
{
public static readonly long[] Value=A155981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155981.Bytes);
public long this[int i]=>Value[i];

public static A155981Inst Instance=new A155981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155982
{
public static readonly long[] Value={ 1L,2L,7L,8L,9L,4L,2L,9L,4L,5L,6L,5L,1L,1L,2L,9L,8L,4L,3L,1L,9L,1L,0L,4L,4L,0L,8L,1L,0L,3L,7L,8L,8L,5L,6L,0L,3L,1L,0L,4L,7L,9L,4L,3L,3L,7L,5L,9L,6L,4L,7L,3L,0L,6L,7L,9L,7L,2L,6L,9L,6L,0L,0L,3L,4L,0L,8L,2L,7L,6L,5L,0L,5L,2L,4L,0L,4L,6L,7L,5L,5L,9L,0L,8L,0L,6L,9L,7L,2L,1L,7L,3L,5L,0L,3L,6L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155982Inst : IEnumerable<long>
{
public static readonly long[] Value=A155982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155982.Bytes);
public long this[int i]=>Value[i];

public static A155982Inst Instance=new A155982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155983
{
public static readonly long[] Value={ 1L,2L,3L,9L,0L,3L,1L,8L,0L,4L,3L,1L,3L,3L,5L,3L,9L,0L,4L,8L,7L,3L,0L,9L,8L,3L,8L,8L,2L,7L,2L,8L,9L,1L,4L,6L,0L,1L,0L,2L,5L,6L,3L,5L,3L,5L,3L,2L,4L,7L,2L,8L,0L,6L,5L,2L,0L,8L,1L,6L,8L,0L,1L,1L,0L,1L,0L,3L,0L,9L,2L,0L,3L,7L,2L,6L,7L,6L,2L,8L,9L,8L,1L,0L,7L,9L,8L,5L,2L,1L,6L,9L,3L,9L,0L,5L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155983Inst : IEnumerable<long>
{
public static readonly long[] Value=A155983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155983.Bytes);
public long this[int i]=>Value[i];

public static A155983Inst Instance=new A155983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155984
{
public static readonly long[] Value={ 1L,2L,0L,4L,2L,3L,8L,2L,6L,8L,9L,7L,7L,3L,7L,9L,8L,5L,8L,4L,7L,3L,2L,6L,1L,2L,9L,8L,0L,3L,7L,7L,9L,3L,8L,9L,0L,7L,8L,8L,7L,8L,3L,7L,7L,7L,8L,4L,5L,1L,7L,5L,3L,4L,6L,4L,2L,2L,5L,3L,3L,9L,3L,5L,9L,8L,7L,1L,8L,7L,8L,9L,5L,1L,6L,9L,6L,6L,2L,5L,2L,2L,7L,6L,0L,7L,8L,6L,1L,6L,6L,0L,5L,6L,1L,7L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155984Inst : IEnumerable<long>
{
public static readonly long[] Value=A155984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155984.Bytes);
public long this[int i]=>Value[i];

public static A155984Inst Instance=new A155984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155985
{
public static readonly long[] Value={ 1L,16L,64L,4L,49L,9L,961L,121L,144L,441L,169L,9025L,529L,9216L,625L,576L,676L,6084L,484L,4096L,6241L,196L,6561L,1024L,4225L,5041L,1089L,9409L,9604L,4356L,6724L,4489L,9801L,1156L,6889L,90601L,1225L,5184L,4624L,4761L,1296L,60025L,5329L,91204L,40401L,1369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155985Inst : IEnumerable<long>
{
public static readonly long[] Value=A155985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155985.Bytes);
public long this[int i]=>Value[i];

public static A155985Inst Instance=new A155985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155986
{
public static readonly long[] Value={ 1L,125L,512L,27L,729L,9261L,1331L,1728L,8L,85184L,4096L,64L,4913L,343L,3375L,5832L,216L,6859L,91125L,50653L,32768L,804357L,74088L,830584L,42875L,54872L,2197L,79507L,704969L,97336L,68921L,10648L,857375L,59319L,912673L,35937L,753571L,12167L,778688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155986Inst : IEnumerable<long>
{
public static readonly long[] Value=A155986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155986.Bytes);
public long this[int i]=>Value[i];

public static A155986Inst Instance=new A155986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155987
{
public static readonly long[] Value={ 1L,1L,7L,3L,5L,5L,7L,9L,4L,5L,5L,1L,1L,6L,5L,9L,3L,6L,2L,5L,4L,5L,9L,3L,8L,0L,3L,3L,1L,9L,5L,7L,9L,9L,3L,4L,0L,7L,1L,4L,6L,9L,3L,4L,1L,7L,5L,4L,2L,9L,8L,3L,8L,5L,4L,2L,3L,1L,8L,9L,3L,3L,1L,8L,9L,7L,0L,0L,2L,8L,8L,3L,2L,6L,0L,5L,5L,9L,0L,2L,7L,9L,9L,2L,4L,7L,9L,7L,5L,4L,2L,6L,7L,2L,4L,1L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155987Inst : IEnumerable<long>
{
public static readonly long[] Value=A155987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155987.Bytes);
public long this[int i]=>Value[i];

public static A155987Inst Instance=new A155987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155988
{
public static readonly long[] Value={ 1L,27L,405L,5103L,59049L,649539L,6908733L,71744535L,731794257L,7360989291L,73222472421L,721764371007L,7060738412025L,68630377364883L,663426981193869L,6382625094934119L,61149666232110753L,583701359488329915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155988Inst : IEnumerable<long>
{
public static readonly long[] Value=A155988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155988.Bytes);
public long this[int i]=>Value[i];

public static A155988Inst Instance=new A155988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155989
{
public static readonly long[] Value={ 3L,5L,11L,17L,37L,41L,47L,59L,71L,73L,89L,101L,107L,109L,113L,127L,139L,151L,163L,167L,181L,191L,197L,211L,229L,233L,251L,263L,271L,277L,293L,307L,313L,331L,349L,353L,373L,383L,397L,401L,421L,431L,439L,449L,479L,487L,499L,509L,557L,563L,571L,587L,613L,617L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155989Inst : IEnumerable<long>
{
public static readonly long[] Value=A155989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155989.Bytes);
public long this[int i]=>Value[i];

public static A155989Inst Instance=new A155989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155990
{
public static readonly long[] Value={ 3L,5L,11L,17L,79L,83L,97L,103L,131L,137L,149L,157L,239L,241L,257L,269L,359L,367L,379L,389L,1399L,1409L,1427L,1433L,1459L,1471L,1483L,1489L,1601L,1607L,1613L,1621L,1747L,1753L,1777L,1787L,2137L,2141L,2153L,2179L,2237L,2239L,2251L,2269L,2377L,2381L,2389L,2399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155990Inst : IEnumerable<long>
{
public static readonly long[] Value=A155990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155990.Bytes);
public long this[int i]=>Value[i];

public static A155990Inst Instance=new A155990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155991
{
public static readonly long[] Value={ 1L,1L,4L,6L,2L,4L,0L,6L,2L,5L,1L,8L,0L,2L,8L,9L,0L,4L,5L,3L,6L,3L,4L,3L,4L,7L,3L,5L,9L,8L,6L,9L,5L,4L,1L,2L,7L,1L,8L,9L,9L,5L,3L,6L,0L,1L,9L,2L,3L,1L,2L,0L,2L,6L,5L,1L,1L,3L,9L,3L,8L,1L,6L,3L,6L,3L,5L,2L,7L,4L,5L,5L,6L,9L,4L,8L,5L,8L,9L,6L,4L,0L,6L,3L,0L,5L,7L,0L,1L,1L,8L,7L,2L,9L,5L,2L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155991Inst : IEnumerable<long>
{
public static readonly long[] Value=A155991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155991.Bytes);
public long this[int i]=>Value[i];

public static A155991Inst Instance=new A155991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155992
{
public static readonly long[] Value={ 1L,1L,2L,1L,7L,1L,3L,5L,6L,1L,3L,9L,3L,1L,6L,8L,1L,6L,6L,6L,0L,5L,4L,8L,3L,8L,3L,4L,4L,3L,0L,3L,5L,2L,0L,6L,9L,0L,1L,3L,4L,5L,6L,5L,2L,6L,2L,6L,8L,9L,6L,7L,3L,3L,5L,7L,0L,5L,8L,0L,9L,3L,9L,2L,8L,7L,2L,4L,0L,1L,2L,4L,6L,2L,6L,4L,5L,1L,1L,1L,1L,4L,9L,0L,2L,2L,2L,0L,3L,8L,3L,6L,1L,2L,2L,8L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155992Inst : IEnumerable<long>
{
public static readonly long[] Value=A155992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155992.Bytes);
public long this[int i]=>Value[i];

public static A155992Inst Instance=new A155992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155993
{
public static readonly long[] Value={ 2L,1L,1L,3L,0L,3L,-2L,9L,9L,-2L,-5L,0L,40L,0L,-5L,-14L,5L,40L,40L,5L,-14L,-27L,0L,90L,0L,90L,0L,-27L,-62L,21L,154L,14L,14L,154L,21L,-62L,-125L,0L,400L,0L,-40L,0L,400L,0L,-125L,-254L,9L,648L,288L,-180L,-180L,288L,648L,9L,-254L,-507L,0L,1410L,0L,120L,0L,120L,0L,1410L,0L,-507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155993Inst : IEnumerable<long>
{
public static readonly long[] Value=A155993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155993.Bytes);
public long this[int i]=>Value[i];

public static A155993Inst Instance=new A155993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155994
{
public static readonly long[] Value={ -2L,-3L,8L,-3L,-6L,10L,10L,-6L,-17L,16L,24L,16L,-17L,-30L,4L,52L,52L,4L,-30L,-63L,24L,56L,80L,56L,24L,-63L,-126L,22L,234L,-10L,-10L,234L,22L,-126L,-257L,32L,488L,224L,-480L,224L,488L,32L,-257L,-510L,8L,1096L,328L,-420L,-420L,328L,1096L,8L,-510L,-1023L,40L,2244L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155994Inst : IEnumerable<long>
{
public static readonly long[] Value=A155994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155994.Bytes);
public long this[int i]=>Value[i];

public static A155994Inst Instance=new A155994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155995
{
public static readonly long[] Value={ 1L,0L,9L,9L,5L,3L,1L,1L,6L,6L,4L,2L,0L,3L,2L,8L,6L,1L,1L,8L,3L,9L,2L,1L,0L,4L,1L,2L,2L,7L,6L,3L,0L,7L,6L,5L,4L,4L,2L,0L,4L,4L,4L,8L,2L,5L,0L,4L,7L,6L,7L,6L,4L,1L,4L,9L,4L,6L,6L,1L,2L,2L,5L,1L,7L,8L,7L,2L,8L,2L,2L,6L,4L,3L,5L,7L,9L,7L,3L,8L,6L,2L,1L,2L,6L,6L,3L,9L,1L,0L,3L,7L,0L,0L,3L,5L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155995Inst : IEnumerable<long>
{
public static readonly long[] Value=A155995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155995.Bytes);
public long this[int i]=>Value[i];

public static A155995Inst Instance=new A155995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155996
{
public static readonly long[] Value={ 1L,2L,3L,6L,13L,25L,50L,101L,201L,402L,804L,1608L,3217L,6434L,12868L,25736L,51472L,102944L,205887L,411775L,823550L,1647099L,3294199L,6588397L,13176795L,26353589L,52707179L,105414357L,210828714L,421657428L,843314857L,1686629713L,3373259426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155996Inst : IEnumerable<long>
{
public static readonly long[] Value=A155996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155996.Bytes);
public long this[int i]=>Value[i];

public static A155996Inst Instance=new A155996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155997
{
public static readonly long[] Value={ 2L,1L,1L,2L,0L,2L,1L,3L,3L,1L,2L,0L,12L,0L,2L,1L,5L,10L,10L,5L,1L,2L,0L,30L,0L,30L,0L,2L,1L,7L,21L,35L,35L,21L,7L,1L,2L,0L,56L,0L,140L,0L,56L,0L,2L,1L,9L,36L,84L,126L,126L,84L,36L,9L,1L,2L,0L,90L,0L,420L,0L,420L,0L,90L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155997Inst : IEnumerable<long>
{
public static readonly long[] Value=A155997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155997.Bytes);
public long this[int i]=>Value[i];

public static A155997Inst Instance=new A155997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155998
{
public static readonly long[] Value={ 0L,1L,1L,0L,4L,0L,1L,3L,3L,1L,0L,8L,0L,8L,0L,1L,5L,10L,10L,5L,1L,0L,12L,0L,40L,0L,12L,0L,1L,7L,21L,35L,35L,21L,7L,1L,0L,16L,0L,112L,0L,112L,0L,16L,0L,1L,9L,36L,84L,126L,126L,84L,36L,9L,1L,0L,20L,0L,240L,0L,504L,0L,240L,0L,20L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155998Inst : IEnumerable<long>
{
public static readonly long[] Value=A155998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155998.Bytes);
public long this[int i]=>Value[i];

public static A155998Inst Instance=new A155998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155999
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,-3L,-3L,0L,0L,6L,49L,6L,0L,0L,-10L,-375L,-375L,-10L,0L,0L,15L,2015L,8100L,2015L,15L,0L,0L,-21L,-8820L,-105350L,-105350L,-8820L,-21L,0L,0L,28L,33782L,1014300L,2893401L,1014300L,33782L,28L,0L,0L,-36L,-117810L,-8004150L,-54009270L,-54009270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155999Inst : IEnumerable<long>
{
public static readonly long[] Value=A155999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155999.Bytes);
public long this[int i]=>Value[i];

public static A155999Inst Instance=new A155999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156000
{
public static readonly long[] Value={ 1L,0L,7L,9L,3L,4L,1L,0L,4L,0L,1L,2L,1L,5L,5L,1L,6L,5L,8L,2L,1L,9L,1L,2L,8L,7L,4L,8L,2L,1L,5L,7L,1L,8L,5L,9L,7L,7L,3L,1L,8L,3L,7L,0L,7L,8L,1L,3L,5L,5L,8L,4L,4L,9L,9L,8L,5L,3L,2L,6L,3L,3L,4L,7L,4L,5L,5L,4L,5L,2L,0L,9L,8L,1L,1L,9L,2L,1L,0L,7L,6L,2L,2L,8L,1L,3L,5L,0L,1L,8L,7L,5L,4L,1L,0L,4L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156000Inst : IEnumerable<long>
{
public static readonly long[] Value=A156000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156000.Bytes);
public long this[int i]=>Value[i];

public static A156000Inst Instance=new A156000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156001
{
public static readonly long[] Value={ 0L,0L,3L,122L,776L,2704L,6987L,15206L,29224L,51680L,85339L,134114L,201792L,293776L,414995L,572558L,772656L,1024320L,1335123L,1716234L,2176728L,2730128L,3387131L,4163830L,5072664L,6132512L,7357675L,8770034L,10385872L,12230288L,14321667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156001Inst : IEnumerable<long>
{
public static readonly long[] Value=A156001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156001.Bytes);
public long this[int i]=>Value[i];

public static A156001Inst Instance=new A156001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156002
{
public static readonly long[] Value={ 0L,1L,6L,44L,311L,2178L,15250L,106755L,747288L,5231022L,36617161L,256320132L,1794240932L,12559686533L,87917805738L,615424640176L,4307972481243L,30155807368710L,211090651580982L,1477634561066887L,10343441927468220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156002Inst : IEnumerable<long>
{
public static readonly long[] Value=A156002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156002.Bytes);
public long this[int i]=>Value[i];

public static A156002Inst Instance=new A156002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156003
{
public static readonly long[] Value={ 2L,7L,7L,37L,18L,37L,221L,78L,78L,221L,1366L,470L,210L,470L,1366L,8569L,3078L,969L,969L,3078L,8569L,54265L,20370L,6195L,2660L,6195L,20370L,54265L,346105L,134620L,42780L,12650L,12650L,42780L,134620L,346105L,2220076L,888057L,296361L,83655L,35100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156003Inst : IEnumerable<long>
{
public static readonly long[] Value=A156003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156003.Bytes);
public long this[int i]=>Value[i];

public static A156003Inst Instance=new A156003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156004
{
public static readonly long[] Value={ 2L,5L,11L,17L,19L,31L,37L,41L,47L,61L,67L,79L,89L,97L,101L,107L,131L,137L,149L,151L,157L,179L,191L,197L,199L,211L,239L,241L,251L,277L,281L,307L,317L,347L,367L,401L,419L,421L,431L,439L,449L,457L,461L,479L,487L,499L,509L,541L,547L,577L,599L,607L,617L,619L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156004Inst : IEnumerable<long>
{
public static readonly long[] Value=A156004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156004.Bytes);
public long this[int i]=>Value[i];

public static A156004Inst Instance=new A156004Inst();

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