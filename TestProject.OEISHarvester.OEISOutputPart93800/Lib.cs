using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A113441
{
public static readonly long[] Value={ 1L,3L,12L,50L,212L,905L,3872L,16576L,70968L,303832L,1300737L,5568473L,23838453L,102051167L,436874885L,1870233780L,8006350999L,34274673894L,146727674181L,628131735844L,2688991567300L,11511399994065L,49279563214531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113441Inst : IEnumerable<long>
{
public static readonly long[] Value=A113441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113441.Bytes);
public long this[int i]=>Value[i];

public static A113441Inst Instance=new A113441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113442
{
public static readonly long[] Value={ 1L,4L,17L,72L,306L,1305L,5577L,23858L,102108L,437080L,1871065L,8009866L,34289712L,146792138L,628407994L,2690174883L,11516466985L,49301256865L,211055514017L,903515089697L,3867890010850L,16558188448465L,70884540117396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113442Inst : IEnumerable<long>
{
public static readonly long[] Value=A113442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113442.Bytes);
public long this[int i]=>Value[i];

public static A113442Inst Instance=new A113442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113443
{
public static readonly long[] Value={ 1L,5L,23L,101L,436L,1871L,8014L,34309L,146868L,628708L,2691401L,11521603L,49323052L,211148530L,903912916L,3869592721L,16565477544L,70915744968L,303585747088L,1299631069856L,5563637060865L,23817572559345L,101961496787621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113443Inst : IEnumerable<long>
{
public static readonly long[] Value=A113443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113443.Bytes);
public long this[int i]=>Value[i];

public static A113443Inst Instance=new A113443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113444
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,9L,13L,18L,24L,31L,43L,60L,83L,113L,151L,206L,283L,389L,532L,721L,982L,1342L,1837L,2512L,3422L,4665L,6367L,8699L,11886L,16218L,22126L,30195L,41226L,56299L,76849L,104883L,143147L,195404L,266776L,364175L,497092L,678503L,926164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113444Inst : IEnumerable<long>
{
public static readonly long[] Value=A113444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113444.Bytes);
public long this[int i]=>Value[i];

public static A113444Inst Instance=new A113444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113445
{
public static readonly long[] Value={ 1L,3L,-1L,5L,-6L,1L,7L,-15L,11L,-1L,9L,-28L,38L,-20L,1L,11L,-45L,90L,-90L,37L,-1L,13L,-66L,175L,-260L,207L,-70L,1L,15L,-91L,301L,-595L,707L,-469L,135L,-1L,17L,-120L,476L,-1176L,1862L,-1848L,1052L,-264L,1L,19L,-153L,708L,-2100L,4158L,-5502L,4692L,-2340L,521L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113445Inst : IEnumerable<long>
{
public static readonly long[] Value=A113445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113445.Bytes);
public long this[int i]=>Value[i];

public static A113445Inst Instance=new A113445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113446
{
public static readonly long[] Value={ 1L,1L,-1L,1L,2L,-1L,0L,1L,1L,2L,0L,-1L,2L,0L,-2L,1L,2L,1L,0L,2L,0L,0L,0L,-1L,3L,2L,-1L,0L,2L,-2L,0L,1L,0L,2L,0L,1L,2L,0L,-2L,2L,2L,0L,0L,0L,2L,0L,0L,-1L,1L,3L,-2L,2L,2L,-1L,0L,0L,0L,2L,0L,-2L,2L,0L,0L,1L,4L,0L,0L,2L,0L,0L,0L,1L,2L,2L,-3L,0L,0L,-2L,0L,2L,1L,2L,0L,0L,4L,0L,-2L,0L,2L,2L,0L,0L,0L,0L,0L,-1L,2L,1L,0L,3L,2L,-2L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113446Inst : IEnumerable<long>
{
public static readonly long[] Value=A113446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113446.Bytes);
public long this[int i]=>Value[i];

public static A113446Inst Instance=new A113446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113447
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,1L,2L,1L,1L,0L,0L,-1L,2L,2L,0L,-1L,0L,1L,2L,0L,2L,0L,0L,1L,1L,2L,1L,-2L,0L,0L,2L,1L,0L,0L,0L,-1L,2L,2L,2L,0L,0L,2L,2L,0L,0L,0L,0L,-1L,3L,1L,0L,-2L,0L,1L,0L,2L,2L,0L,0L,0L,2L,2L,2L,-1L,0L,0L,2L,0L,0L,0L,0L,1L,2L,2L,1L,-2L,0L,2L,2L,0L,1L,0L,0L,-2L,0L,2L,0L,0L,0L,0L,4L,0L,2L,0L,0L,1L,2L,3L,0L,-1L,0L,0L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113447Inst : IEnumerable<long>
{
public static readonly long[] Value=A113447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113447.Bytes);
public long this[int i]=>Value[i];

public static A113447Inst Instance=new A113447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113448
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,2L,1L,0L,0L,0L,0L,2L,2L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,1L,2L,0L,2L,0L,0L,2L,1L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,3L,1L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,2L,2L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,2L,2L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,2L,3L,0L,1L,0L,0L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113448Inst : IEnumerable<long>
{
public static readonly long[] Value=A113448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113448.Bytes);
public long this[int i]=>Value[i];

public static A113448Inst Instance=new A113448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113449
{
public static readonly long[] Value={ 2L,8L,40L,216L,1218L,7000L,40560L,235824L,1373090L,7999592L,46616920L,271683720L,1583441442L,9228858808L,53789455200L,313507253856L,1827252574658L,10650004589000L,62072766255880L,361786571934264L,2108646614622210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113449Inst : IEnumerable<long>
{
public static readonly long[] Value=A113449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113449.Bytes);
public long this[int i]=>Value[i];

public static A113449Inst Instance=new A113449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113450
{
public static readonly long[] Value={ 0L,4L,30L,192L,1160L,6860L,40222L,235008L,1371120L,7994836L,46605438L,271656000L,1583374520L,9228697244L,53789065150L,313506312192L,1827250301280L,10649999100580L,62072753005662L,361786539945408L,2108646537394280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113450Inst : IEnumerable<long>
{
public static readonly long[] Value=A113450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113450.Bytes);
public long this[int i]=>Value[i];

public static A113450Inst Instance=new A113450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113451
{
public static readonly long[] Value={ 1L,4L,6L,8L,12L,14L,19L,22L,24L,25L,27L,29L,31L,38L,44L,48L,50L,59L,63L,65L,70L,72L,75L,77L,78L,79L,85L,87L,88L,90L,92L,93L,94L,95L,112L,117L,122L,124L,126L,128L,131L,132L,134L,135L,136L,143L,147L,149L,151L,153L,155L,156L,158L,159L,163L,166L,169L,181L,183L,186L,192L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113451Inst : IEnumerable<long>
{
public static readonly long[] Value=A113451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113451.Bytes);
public long this[int i]=>Value[i];

public static A113451Inst Instance=new A113451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113452
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,4L,4L,4L,8L,8L,8L,8L,8L,8L,16L,16L,16L,16L,16L,16L,16L,32L,32L,32L,32L,32L,32L,32L,32L,64L,64L,64L,64L,64L,64L,64L,64L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113452Inst : IEnumerable<long>
{
public static readonly long[] Value=A113452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113452.Bytes);
public long this[int i]=>Value[i];

public static A113452Inst Instance=new A113452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113453
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,4L,4L,1L,1L,2L,2L,4L,4L,8L,1L,1L,2L,2L,4L,4L,8L,8L,1L,1L,2L,2L,4L,4L,8L,8L,16L,1L,1L,2L,2L,4L,4L,8L,8L,16L,16L,1L,1L,2L,2L,4L,4L,8L,8L,16L,16L,32L,1L,1L,2L,2L,4L,4L,8L,8L,16L,16L,32L,32L,1L,1L,2L,2L,4L,4L,8L,8L,16L,16L,32L,32L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113453Inst : IEnumerable<long>
{
public static readonly long[] Value=A113453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113453.Bytes);
public long this[int i]=>Value[i];

public static A113453Inst Instance=new A113453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113454
{
public static readonly long[] Value={ 3L,4L,4L,5L,6L,8L,8L,8L,10L,12L,16L,12L,16L,16L,20L,16L,20L,24L,32L,32L,24L,32L,32L,40L,48L,64L,32L,40L,48L,64L,64L,80L,48L,64L,64L,80L,96L,128L,128L,64L,80L,96L,128L,128L,160L,192L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113454Inst : IEnumerable<long>
{
public static readonly long[] Value=A113454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113454.Bytes);
public long this[int i]=>Value[i];

public static A113454Inst Instance=new A113454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113455
{
public static readonly long[] Value={ 3L,4L,4L,5L,6L,7L,8L,12L,13L,14L,15L,16L,20L,22L,24L,26L,28L,29L,30L,31L,32L,52L,54L,56L,58L,60L,61L,62L,63L,64L,96L,100L,104L,108L,112L,116L,118L,120L,122L,124L,125L,126L,127L,128L,224L,228L,232L,236L,240L,244L,246L,248L,250L,252L,253L,254L,255L,256L,432L,440L,448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113455Inst : IEnumerable<long>
{
public static readonly long[] Value=A113455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113455.Bytes);
public long this[int i]=>Value[i];

public static A113455Inst Instance=new A113455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113456
{
public static readonly long[] Value={ 1L,2L,1L,33L,3L,1L,19940L,3L,2L,1L,204323L,213L,155L,3L,1L,380480345L,213L,7572L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113456Inst : IEnumerable<long>
{
public static readonly long[] Value=A113456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113456.Bytes);
public long this[int i]=>Value[i];

public static A113456Inst Instance=new A113456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113457
{
public static readonly long[] Value={ 1L,3L,3L,213L,213L,1383L,3091L,8129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113457Inst : IEnumerable<long>
{
public static readonly long[] Value=A113457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113457.Bytes);
public long this[int i]=>Value[i];

public static A113457Inst Instance=new A113457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113458
{
public static readonly long[] Value={ 33L,3L,155L,3L,77L,5L,51L,3L,77L,3L,35L,5L,50L,3L,187L,6L,21L,5L,39L,3L,145L,33L,39L,5L,69L,39L,91L,3L,33L,7L,15L,12L,221L,3L,28L,7L,21L,3L,55L,3L,33L,5L,91L,66L,209L,69L,35L,5L,50L,3L,115L,39L,141L,5L,51L,6L,145L,85L,15L,7L,21L,93L,95L,3L,57L,5L,51L,3L,65L,15L,35L,7L,69L,55L,287L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113458Inst : IEnumerable<long>
{
public static readonly long[] Value=A113458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113458.Bytes);
public long this[int i]=>Value[i];

public static A113458Inst Instance=new A113458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113459
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,7L,7L,11L,11L,11L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113459Inst : IEnumerable<long>
{
public static readonly long[] Value=A113459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113459.Bytes);
public long this[int i]=>Value[i];

public static A113459Inst Instance=new A113459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113460
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,7L,5L,11L,17L,23L,5L,11L,17L,23L,29L,7L,37L,67L,97L,127L,157L,7L,157L,307L,457L,607L,757L,907L,11L,1210241L,2420471L,3630701L,4840931L,6051161L,7261391L,8471621L,11L,32671181L,65342351L,98013521L,130684691L,163355861L,196027031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113460Inst : IEnumerable<long>
{
public static readonly long[] Value=A113460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113460.Bytes);
public long this[int i]=>Value[i];

public static A113460Inst Instance=new A113460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113461
{
public static readonly long[] Value={ 0L,1L,2L,6L,6L,30L,150L,1210230L,32671170L,224494620L,1536160080L,1482708889200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113461Inst : IEnumerable<long>
{
public static readonly long[] Value=A113461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113461.Bytes);
public long this[int i]=>Value[i];

public static A113461Inst Instance=new A113461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113462
{
public static readonly long[] Value={ 1L,2L,6L,8L,12L,28L,30L,180L,512L,720L,1648L,2300L,2416L,6084L,6160L,77688L,105408L,353736L,852912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113462Inst : IEnumerable<long>
{
public static readonly long[] Value=A113462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113462.Bytes);
public long this[int i]=>Value[i];

public static A113462Inst Instance=new A113462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113463
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,6L,2L,4L,6L,8L,8L,9L,10L,11L,12L,23L,24L,25L,26L,27L,28L,24L,25L,26L,27L,28L,29L,30L,103L,114L,125L,136L,147L,158L,169L,180L,304L,330L,356L,382L,408L,434L,460L,486L,512L,324L,368L,412L,456L,500L,544L,588L,632L,676L,720L,8L,172L,336L,500L,664L,828L,992L,1156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113463Inst : IEnumerable<long>
{
public static readonly long[] Value=A113463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113463.Bytes);
public long this[int i]=>Value[i];

public static A113463Inst Instance=new A113463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113464
{
public static readonly long[] Value={ 1L,1L,2L,2L,8L,23L,24L,103L,304L,324L,8L,1024L,1024L,5096L,5096L,37548L,83520L,171360L,530424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113464Inst : IEnumerable<long>
{
public static readonly long[] Value=A113464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113464.Bytes);
public long this[int i]=>Value[i];

public static A113464Inst Instance=new A113464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113465
{
public static readonly long[] Value={ 1L,2L,1L,33L,3L,1L,242L,3L,2L,1L,11605L,213L,119L,3L,1L,28374L,213L,3445L,3L,2L,1L,171893L,1383L,15026L,111L,77L,5L,1L,1043710445721L,3091L,74783L,201L,8718L,5L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113465Inst : IEnumerable<long>
{
public static readonly long[] Value=A113465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113465.Bytes);
public long this[int i]=>Value[i];

public static A113465Inst Instance=new A113465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113466
{
public static readonly long[] Value={ 1L,3L,3L,213L,213L,1383L,3091L,8129L,943607L,943607L,19235031L,21470685L,21470685L,21470685L,21470685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113466Inst : IEnumerable<long>
{
public static readonly long[] Value=A113466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113466.Bytes);
public long this[int i]=>Value[i];

public static A113466Inst Instance=new A113466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113467
{
public static readonly long[] Value={ 33L,3L,119L,3L,77L,5L,8L,3L,77L,3L,35L,5L,8L,3L,187L,6L,21L,5L,8L,3L,145L,33L,39L,5L,8L,39L,8L,3L,33L,7L,15L,12L,189L,3L,28L,7L,21L,3L,55L,3L,33L,5L,8L,66L,209L,69L,35L,5L,8L,3L,115L,39L,141L,5L,51L,6L,8L,27L,15L,7L,21L,66L,95L,3L,40L,5L,27L,3L,8L,15L,35L,7L,69L,55L,287L,6L,65L,11L,8L,3L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113467Inst : IEnumerable<long>
{
public static readonly long[] Value=A113467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113467.Bytes);
public long this[int i]=>Value[i];

public static A113467Inst Instance=new A113467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113468
{
public static readonly long[] Value={ 242L,213L,3445L,111L,8718L,5L,2001L,69L,3526L,299L,1074L,5L,2222L,537L,9177L,129L,4114L,5L,8L,598L,7843L,111L,1235L,10L,2984L,303L,3538L,417L,987L,7L,1771L,91L,7659L,57L,9269L,10L,2264L,145L,1197L,219L,1606L,5L,1826L,115L,8897L,203L,618L,5L,8L,159L,2673L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113468Inst : IEnumerable<long>
{
public static readonly long[] Value=A113468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113468.Bytes);
public long this[int i]=>Value[i];

public static A113468Inst Instance=new A113468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113469
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,5L,1L,0L,8L,4L,5L,2L,6L,8L,7L,2L,8L,8L,9L,6L,13L,1L,0L,23L,1L,0L,26L,14L,16L,14L,17L,1L,0L,33L,13L,2L,18L,24L,25L,7L,5L,8L,21L,18L,29L,1L,0L,47L,1L,0L,50L,30L,38L,27L,18L,36L,37L,1L,0L,59L,1L,0L,62L,32L,32L,32L,33L,26L,37L,1L,0L,71L,1L,0L,74L,38L,40L,46L,41L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113469Inst : IEnumerable<long>
{
public static readonly long[] Value=A113469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113469.Bytes);
public long this[int i]=>Value[i];

public static A113469Inst Instance=new A113469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113470
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,7L,5L,11L,17L,23L,5L,11L,17L,23L,29L,7L,37L,67L,97L,127L,157L,35L,65L,95L,125L,155L,185L,215L,635L,707L,779L,851L,923L,995L,1067L,1139L,635L,707L,779L,851L,923L,995L,1067L,1139L,1211L,199L,409L,619L,829L,1039L,1249L,1459L,1669L,1879L,2089L,3841L,3973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113470Inst : IEnumerable<long>
{
public static readonly long[] Value=A113470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113470.Bytes);
public long this[int i]=>Value[i];

public static A113470Inst Instance=new A113470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113471
{
public static readonly BigInteger[] Value={ 1L,107L,1190741689L,BigInteger.Parse("14769352340699478579719327005523"),BigInteger.Parse("253650450218391594062880777243777017638488805917392303113120204411172926964476779033181303378188721") };
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
public class A113471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113471Inst Instance=new A113471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113472
{
public static readonly long[] Value={ 1L,4L,4L,4L,4L,4L,4L,4L,8L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,8L,4L,8L,4L,8L,4L,8L,4L,4L,8L,4L,8L,4L,4L,4L,4L,8L,8L,8L,4L,8L,4L,8L,4L,4L,4L,4L,4L,4L,4L,8L,8L,4L,4L,8L,4L,4L,4L,8L,8L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,8L,4L,8L,4L,8L,4L,4L,4L,4L,4L,8L,4L,8L,16L,4L,4L,16L,8L,4L,4L,8L,4L,16L,4L,8L,4L,8L,16L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113472Inst : IEnumerable<long>
{
public static readonly long[] Value=A113472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113472.Bytes);
public long this[int i]=>Value[i];

public static A113472Inst Instance=new A113472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113473
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113473Inst : IEnumerable<long>
{
public static readonly long[] Value=A113473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113473.Bytes);
public long this[int i]=>Value[i];

public static A113473Inst Instance=new A113473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113474
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,5L,5L,8L,8L,9L,9L,11L,11L,12L,12L,16L,16L,17L,17L,19L,19L,20L,20L,23L,23L,24L,24L,26L,26L,27L,27L,32L,32L,33L,33L,35L,35L,36L,36L,39L,39L,40L,40L,42L,42L,43L,43L,47L,47L,48L,48L,50L,50L,51L,51L,54L,54L,55L,55L,57L,57L,58L,58L,64L,64L,65L,65L,67L,67L,68L,68L,71L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113474Inst : IEnumerable<long>
{
public static readonly long[] Value=A113474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113474.Bytes);
public long this[int i]=>Value[i];

public static A113474Inst Instance=new A113474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113475
{
public static readonly long[] Value={ 1L,3L,5L,2L,4L,2L,2L,4L,2L,4L,3L,2L,3L,4L,2L,2L,1L,1L,2L,1L,5L,1L,7L,1L,5L,4L,2L,2L,3L,3L,2L,11L,5L,10L,4L,2L,2L,6L,14L,4L,6L,2L,3L,9L,14L,10L,3L,3L,4L,2L,1L,5L,4L,16L,8L,9L,5L,8L,14L,6L,2L,2L,26L,8L,30L,4L,5L,1L,4L,2L,22L,36L,20L,2L,10L,2L,15L,3L,18L,6L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113475Inst : IEnumerable<long>
{
public static readonly long[] Value=A113475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113475.Bytes);
public long this[int i]=>Value[i];

public static A113475Inst Instance=new A113475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113476
{
public static readonly long[] Value={ 8L,3L,5L,6L,4L,8L,8L,4L,8L,2L,6L,4L,7L,2L,1L,0L,5L,3L,3L,3L,7L,1L,0L,3L,4L,5L,9L,7L,0L,0L,1L,1L,0L,7L,6L,6L,7L,8L,6L,5L,2L,2L,1L,2L,7L,4L,8L,4L,3L,3L,1L,9L,4L,3L,2L,3L,0L,1L,8L,8L,3L,1L,4L,9L,6L,0L,5L,0L,5L,6L,0L,1L,0L,3L,2L,0L,1L,6L,1L,9L,9L,7L,6L,3L,3L,2L,9L,4L,3L,8L,4L,0L,2L,8L,2L,6L,2L,8L,5L,4L,6L,6L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113476Inst : IEnumerable<long>
{
public static readonly long[] Value=A113476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113476.Bytes);
public long this[int i]=>Value[i];

public static A113476Inst Instance=new A113476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113477
{
public static readonly long[] Value={ 2L,4L,2L,8L,6L,5L,0L,6L,4L,7L,8L,8L,7L,5L,8L,1L,6L,1L,1L,8L,1L,9L,9L,4L,1L,6L,8L,9L,7L,8L,0L,9L,3L,1L,2L,4L,8L,5L,5L,5L,0L,3L,4L,8L,4L,4L,8L,7L,4L,9L,0L,9L,2L,7L,4L,4L,1L,6L,6L,2L,9L,4L,1L,8L,8L,0L,5L,4L,0L,5L,6L,8L,7L,3L,6L,1L,7L,6L,9L,1L,7L,4L,4L,5L,4L,6L,7L,2L,7L,2L,7L,0L,8L,8L,8L,3L,5L,4L,4L,3L,8L,3L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113477Inst : IEnumerable<long>
{
public static readonly long[] Value=A113477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113477.Bytes);
public long this[int i]=>Value[i];

public static A113477Inst Instance=new A113477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113478
{
public static readonly long[] Value={ 0L,1L,4L,11L,28L,64L,173L,438L,1200L,3325L,9289L,26494L,76483L,221530L,645685L,1895983L,5593440L,16578830L,49347768L,147402214L,441641536L,1326941536L,3996900895L,12066234206L,36501753353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113478Inst : IEnumerable<long>
{
public static readonly long[] Value=A113478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113478.Bytes);
public long this[int i]=>Value[i];

public static A113478Inst Instance=new A113478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113479
{
public static readonly long[] Value={ 4L,8L,32L,128L,256L,512L,4096L,32768L,65536L,131072L,524288L,2097152L,4194304L,8388608L,134217728L,2147483648L,4294967296L,8589934592L,34359738368L,137438953472L,274877906944L,549755813888L,4398046511104L,35184372088832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113479Inst : IEnumerable<long>
{
public static readonly long[] Value=A113479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113479.Bytes);
public long this[int i]=>Value[i];

public static A113479Inst Instance=new A113479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113480
{
public static readonly long[] Value={ 0L,1L,105L,369L,25521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113480Inst : IEnumerable<long>
{
public static readonly long[] Value=A113480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113480.Bytes);
public long this[int i]=>Value[i];

public static A113480Inst Instance=new A113480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113481
{
public static readonly long[] Value={ 0L,1L,27L,45L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113481Inst : IEnumerable<long>
{
public static readonly long[] Value=A113481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113481.Bytes);
public long this[int i]=>Value[i];

public static A113481Inst Instance=new A113481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113482
{
public static readonly long[] Value={ 5L,13L,17L,29L,25L,37L,41L,53L,73L,65L,61L,65L,97L,85L,89L,85L,109L,101L,137L,113L,125L,169L,157L,149L,145L,145L,185L,205L,173L,193L,221L,185L,181L,205L,197L,233L,241L,221L,229L,305L,281L,289L,265L,277L,325L,257L,269L,265L,353L,305L,373L,293L,337L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113482Inst : IEnumerable<long>
{
public static readonly long[] Value=A113482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113482.Bytes);
public long this[int i]=>Value[i];

public static A113482Inst Instance=new A113482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113483
{
public static readonly long[] Value={ 2L,3L,7L,17L,43L,127L,373L,1229L,4177L,15439L,59141L,242393L,1028051L,4607803L,21355507L,103637683L,519232333L,2706119771L,14531789681L,80784565951L,461802480011L,2722713380077L,16475872190489L,102523358575031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113483Inst : IEnumerable<long>
{
public static readonly long[] Value=A113483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113483.Bytes);
public long this[int i]=>Value[i];

public static A113483Inst Instance=new A113483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113484
{
public static readonly long[] Value={ 4L,9L,4L,9L,6L,25L,8L,9L,10L,21L,12L,25L,14L,15L,16L,21L,18L,25L,20L,21L,22L,25L,24L,25L,26L,27L,28L,33L,30L,49L,32L,33L,34L,35L,36L,49L,38L,39L,40L,49L,42L,55L,44L,45L,46L,49L,48L,49L,50L,51L,52L,55L,54L,55L,56L,57L,58L,63L,60L,77L,62L,63L,64L,65L,66L,85L,68L,69L,70L,81L,72L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113484Inst : IEnumerable<long>
{
public static readonly long[] Value=A113484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113484.Bytes);
public long this[int i]=>Value[i];

public static A113484Inst Instance=new A113484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113485
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,122L,367L,1114L,3423L,10670L,33841L,109398L,361045L,1217346L,4195267L,14775986L,53172411L,195396310L,732806677L,2802898190L,10926431393L,43381582538L,175311002903L,720640632074L,3011495745175L,12786738800254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113485Inst : IEnumerable<long>
{
public static readonly long[] Value=A113485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113485.Bytes);
public long this[int i]=>Value[i];

public static A113485Inst Instance=new A113485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113486
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,3L,0L,4L,2L,7L,0L,13L,0L,14L,10L,21L,0L,39L,0L,52L,22L,65L,0L,137L,12L,156L,48L,267L,0L,483L,0L,652L,120L,1003L,50L,1849L,0L,2602L,300L,4329L,0L,7295L,0L,11086L,864L,17733L,0L,30125L,48L,46536L,1990L,75349L,0L,124683L,250L,197018L,5186L,317839L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113486Inst : IEnumerable<long>
{
public static readonly long[] Value=A113486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113486.Bytes);
public long this[int i]=>Value[i];

public static A113486Inst Instance=new A113486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113487
{
public static readonly long[] Value={ 0L,1L,3L,13L,15L,21L,27L,33L,37L,43L,55L,57L,61L,75L,85L,87L,91L,93L,103L,105L,111L,127L,135L,141L,145L,157L,171L,177L,181L,187L,213L,217L,223L,231L,241L,243L,247L,255L,265L,273L,283L,297L,301L,303L,313L,325L,345L,355L,363L,373L,385L,387L,415L,421L,423L,441L,451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113487Inst : IEnumerable<long>
{
public static readonly long[] Value=A113487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113487.Bytes);
public long this[int i]=>Value[i];

public static A113487Inst Instance=new A113487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113488
{
public static readonly long[] Value={ 0L,3L,5L,9L,11L,21L,23L,39L,45L,51L,53L,59L,65L,75L,83L,89L,105L,111L,123L,125L,143L,149L,153L,159L,161L,165L,171L,185L,189L,191L,201L,213L,221L,231L,245L,249L,263L,269L,273L,275L,279L,285L,291L,293L,299L,315L,321L,333L,335L,341L,353L,359L,363L,369L,375L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113488Inst : IEnumerable<long>
{
public static readonly long[] Value=A113488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113488.Bytes);
public long this[int i]=>Value[i];

public static A113488Inst Instance=new A113488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113489
{
public static readonly BigInteger[] Value={ 129L,3682913L,496165411L,62260698721L,7472966967499L,99262851056183695L,BigInteger.Parse("1234379338586942892505"),BigInteger.Parse("135436174616790289414111"),BigInteger.Parse("14738971133550183905879827"),BigInteger.Parse("1593061976858155930556059673"),BigInteger.Parse("171191473337951767580578821529"),BigInteger.Parse("18305009217958957209544913346089") };
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
public class A113489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113489.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113489Inst Instance=new A113489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113490
{
public static readonly long[] Value={ 206L,519L,703L,869L,1418L,1923L,1945L,2066L,2095L,2127L,2446L,2759L,2867L,2881L,2901L,2913L,2974L,3099L,3155L,3207L,3383L,3398L,3545L,3649L,3777L,3814L,3898L,4435L,4766L,4778L,4873L,4963L,5091L,5105L,5165L,5534L,5582L,5638L,5771L,5834L,5855L,6033L,6098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113490Inst : IEnumerable<long>
{
public static readonly long[] Value=A113490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113490.Bytes);
public long this[int i]=>Value[i];

public static A113490Inst Instance=new A113490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113491
{
public static readonly long[] Value={ 2L,12L,1L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113491Inst : IEnumerable<long>
{
public static readonly long[] Value=A113491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113491.Bytes);
public long this[int i]=>Value[i];

public static A113491Inst Instance=new A113491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113492
{
public static readonly long[] Value={ 1L,7L,11L,3L,3L,4L,3L,5L,11L,4L,1L,2L,1L,1L,4L,8L,8L,2L,2L,6L,6L,7L,7L,3L,1L,3L,4L,2L,7L,2L,2L,3L,2L,2L,4L,1L,3L,12L,5L,2L,2L,1L,3L,5L,3L,4L,4L,4L,14L,2L,1L,2L,11L,4L,6L,2L,1L,2L,7L,8L,4L,6L,1L,3L,1L,8L,1L,2L,4L,3L,12L,8L,1L,2L,11L,1L,2L,10L,2L,3L,3L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113492Inst : IEnumerable<long>
{
public static readonly long[] Value=A113492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113492.Bytes);
public long this[int i]=>Value[i];

public static A113492Inst Instance=new A113492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113493
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,1L,1L,0L,1L,1L,3L,1L,1L,5L,1L,1L,8L,1L,1L,9L,1L,3L,1L,3L,3L,5L,3L,3L,7L,3L,3L,8L,3L,7L,2L,7L,7L,5L,7L,7L,8L,7L,7L,9L,7L,9L,1L,9L,9L,2L,9L,1L,0L,3L,0L,1L,1L,0L,5L,0L,1L,1L,0L,6L,0L,1L,1L,1L,3L,1L,1L,1L,1L,4L,1L,1L,1L,2L,4L,2L,1L,1L,2L,7L,2L,1L,1L,2L,8L,2L,1L,1L,3L,3L,3L,1L,1L,3L,8L,3L,1L,1L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113493Inst : IEnumerable<long>
{
public static readonly long[] Value=A113493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113493.Bytes);
public long this[int i]=>Value[i];

public static A113493Inst Instance=new A113493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113494
{
public static readonly BigInteger[] Value={ 2L,3L,13L,178L,31853L,1014645293L,1029505071621669458L,BigInteger.Parse("1059880692494738761409621021617069613"),BigInteger.Parse("1123347082323126985848870489739619316533660939418089557571160604297983533") };
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
public class A113494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113494Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113494.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113494Inst Instance=new A113494Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113495
{
public static readonly BigInteger[] Value={ 1L,4L,9L,16L,27L,64L,125L,256L,2187L,16384L,161051L,BigInteger.Parse("23945242826029513411849172299223580994042798784118784"),BigInteger.Parse("23945249190331908165492143678605499565319109933299901") };
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
public class A113495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113495Inst Instance=new A113495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113496
{
public static readonly long[] Value={ 9L,25L,9L,10L,21L,25L,15L,16L,21L,25L,21L,22L,25L,25L,26L,27L,28L,33L,49L,33L,34L,35L,36L,49L,39L,40L,49L,55L,45L,46L,49L,49L,50L,51L,52L,55L,55L,56L,57L,58L,63L,77L,63L,64L,65L,66L,85L,69L,70L,81L,77L,75L,76L,77L,78L,85L,81L,82L,85L,85L,86L,87L,88L,91L,91L,92L,93L,94L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113496Inst : IEnumerable<long>
{
public static readonly long[] Value=A113496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113496.Bytes);
public long this[int i]=>Value[i];

public static A113496Inst Instance=new A113496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113497
{
public static readonly long[] Value={ 1L,3L,6L,6L,11L,9L,16L,12L,21L,15L,26L,18L,31L,21L,36L,24L,41L,27L,46L,30L,51L,33L,56L,36L,61L,39L,66L,42L,71L,45L,76L,48L,81L,51L,86L,54L,91L,57L,96L,60L,101L,63L,106L,66L,111L,69L,116L,72L,121L,75L,126L,78L,131L,81L,136L,84L,141L,87L,146L,90L,151L,93L,156L,96L,161L,99L,166L,102L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113497Inst : IEnumerable<long>
{
public static readonly long[] Value=A113497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113497.Bytes);
public long this[int i]=>Value[i];

public static A113497Inst Instance=new A113497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113498
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,13L,12L,14L,15L,21L,19L,24L,21L,29L,28L,30L,28L,40L,35L,41L,42L,46L,41L,53L,44L,59L,52L,61L,55L,79L,55L,69L,66L,86L,70L,90L,73L,94L,93L,91L,81L,121L,88L,114L,103L,123L,95L,137L,102L,138L,122L,132L,114L,168L,121L,144L,145L,159L,137L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113498Inst : IEnumerable<long>
{
public static readonly long[] Value=A113498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113498.Bytes);
public long this[int i]=>Value[i];

public static A113498Inst Instance=new A113498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113499
{
public static readonly long[] Value={ 7L,12L,40L,75L,163L,228L,261L,288L,322L,331L,618L,678L,768L,926L,2990L,3821L,4852L,5726L,10802L,11710L,12006L,12635L,14470L,18097L,22156L,25776L,29142L,32692L,36965L,48830L,51821L,56433L,58008L,63757L,64433L,67545L,68391L,69850L,73723L,77498L,77770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113499Inst : IEnumerable<long>
{
public static readonly long[] Value=A113499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113499.Bytes);
public long this[int i]=>Value[i];

public static A113499Inst Instance=new A113499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113500
{
public static readonly BigInteger[] Value={ 32L,3042L,375131L,46137317L,5674515856L,697919312217L,85838400887831L,10557425389890242L,1298477484555612931L,BigInteger.Parse("159702173174950499517"),BigInteger.Parse("19642068823034355828656"),BigInteger.Parse("2415814763060050816424417") };
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
public class A113500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113500.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113500Inst Instance=new A113500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113501
{
public static readonly long[] Value={ 1L,2L,3L,9L,14L,23L,29L,81L,128L,210L,468L,473L,746L,950L,3344L,4043L,4839L,14376L,39521L,64563L,72984L,82899L,84338L,85206L,86121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113501Inst : IEnumerable<long>
{
public static readonly long[] Value=A113501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113501.Bytes);
public long this[int i]=>Value[i];

public static A113501Inst Instance=new A113501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113502
{
public static readonly long[] Value={ 3L,6L,9L,10L,12L,15L,18L,20L,21L,24L,27L,28L,30L,33L,36L,39L,40L,42L,45L,48L,50L,51L,54L,55L,56L,57L,60L,63L,66L,69L,70L,72L,75L,78L,80L,81L,84L,87L,90L,91L,93L,96L,99L,100L,102L,105L,108L,110L,111L,112L,114L,117L,120L,123L,126L,129L,130L,132L,135L,136L,138L,140L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113502Inst : IEnumerable<long>
{
public static readonly long[] Value=A113502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113502.Bytes);
public long this[int i]=>Value[i];

public static A113502Inst Instance=new A113502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113503
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,0L,3L,1L,1L,0L,1L,0L,0L,0L,6L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,10L,3L,4L,0L,4L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,14L,4L,4L,1L,4L,1L,1L,0L,4L,1L,1L,0L,1L,0L,0L,0L,4L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,4L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113503Inst : IEnumerable<long>
{
public static readonly long[] Value=A113503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113503.Bytes);
public long this[int i]=>Value[i];

public static A113503Inst Instance=new A113503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113504
{
public static readonly long[] Value={ 1L,1L,2L,0L,3L,1L,1L,0L,5L,2L,2L,0L,2L,0L,0L,0L,8L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,13L,2L,2L,1L,2L,1L,1L,0L,2L,1L,1L,0L,1L,0L,0L,0L,2L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,28L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,0L,0L,0L,2L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,2L,2L,0L,2L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113504Inst : IEnumerable<long>
{
public static readonly long[] Value=A113504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113504.Bytes);
public long this[int i]=>Value[i];

public static A113504Inst Instance=new A113504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113505
{
public static readonly long[] Value={ 7L,15L,23L,87L,111L,119L,167L,335L,1391L,1455L,1607L,1679L,1991L,25887L,26375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113505Inst : IEnumerable<long>
{
public static readonly long[] Value=A113505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113505.Bytes);
public long this[int i]=>Value[i];

public static A113505Inst Instance=new A113505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113506
{
public static readonly long[] Value={ 1L,32L,7L,12L,17L,46L,3042L,319L,835L,2188L,5730L,375131L,39282L,102845L,269253L,704915L,46137317L,4831563L,12649196L,33116027L,86698886L,5674515856L,594243013L,1555748409L,4073002214L,10663258234L,697919312217L,73087059232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113506Inst : IEnumerable<long>
{
public static readonly long[] Value=A113506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113506.Bytes);
public long this[int i]=>Value[i];

public static A113506Inst Instance=new A113506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113507
{
public static readonly long[] Value={ 1362L,1843L,2540L,4280L,5507L,6896L,14601L,15143L,17547L,18393L,20337L,22710L,23560L,25887L,27487L,30728L,32286L,32615L,33144L,34499L,37194L,43422L,46075L,46167L,47293L,47497L,56125L,58465L,58495L,60552L,60911L,62069L,62091L,65743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113507Inst : IEnumerable<long>
{
public static readonly long[] Value=A113507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113507.Bytes);
public long this[int i]=>Value[i];

public static A113507Inst Instance=new A113507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113508
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,8L,9L,11L,13L,14L,16L,17L,18L,19L,21L,23L,26L,27L,28L,29L,31L,32L,33L,34L,37L,38L,39L,41L,42L,43L,46L,47L,49L,52L,53L,54L,56L,57L,58L,59L,61L,62L,63L,64L,67L,68L,69L,71L,73L,74L,76L,77L,78L,79L,81L,82L,83L,86L,87L,89L,91L,93L,94L,97L,98L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113508Inst : IEnumerable<long>
{
public static readonly long[] Value=A113508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113508.Bytes);
public long this[int i]=>Value[i];

public static A113508Inst Instance=new A113508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113509
{
public static readonly long[] Value={ 587L,9630L,9971L,11056L,11211L,15109L,18724L,18883L,19290L,28780L,31182L,33713L,35788L,38919L,39527L,41879L,44171L,45645L,46335L,46746L,48721L,51520L,58890L,172189L,173487L,173509L,174370L,174442L,175513L,177317L,179239L,179415L,179429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113509Inst : IEnumerable<long>
{
public static readonly long[] Value=A113509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113509.Bytes);
public long this[int i]=>Value[i];

public static A113509Inst Instance=new A113509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113510
{
public static readonly long[] Value={ 0L,1L,3L,9L,13L,25L,43L,45L,49L,51L,55L,69L,79L,81L,85L,93L,109L,111L,121L,135L,141L,163L,165L,169L,175L,183L,189L,195L,211L,219L,223L,231L,241L,265L,273L,279L,283L,301L,309L,315L,321L,331L,339L,343L,345L,351L,363L,379L,393L,403L,409L,415L,421L,423L,441L,445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113510Inst : IEnumerable<long>
{
public static readonly long[] Value=A113510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113510.Bytes);
public long this[int i]=>Value[i];

public static A113510Inst Instance=new A113510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113511
{
public static readonly BigInteger[] Value={ 1L,2L,30L,30030L,6469693230L,614889782588491410L,BigInteger.Parse("40729680599249024150621323470"),BigInteger.Parse("2566376117594999414479597815340071648394470"),BigInteger.Parse("225319534991831177328890236228992001350685163362356544091910") };
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
public class A113511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113511Inst Instance=new A113511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113512
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,4L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,10L,11L,11L,11L,11L,12L,12L,13L,13L,14L,14L,15L,16L,17L,17L,17L,17L,18L,18L,19L,19L,20L,20L,21L,22L,23L,23L,23L,23L,24L,24L,25L,26L,27L,28L,29L,29L,29L,29L,29L,29L,30L,30L,31L,31L,32L,32L,33L,34L,35L,36L,37L,37L,37L,37L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113512Inst : IEnumerable<long>
{
public static readonly long[] Value=A113512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113512.Bytes);
public long this[int i]=>Value[i];

public static A113512Inst Instance=new A113512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113513
{
public static readonly long[] Value={ 1L,10L,1L,6L,9L,3L,9L,4L,1L,30L,1L,93L,9L,39L,33L,1L,25L,22L,16L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113513Inst : IEnumerable<long>
{
public static readonly long[] Value=A113513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113513.Bytes);
public long this[int i]=>Value[i];

public static A113513Inst Instance=new A113513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113514
{
public static readonly long[] Value={ 1L,2L,5L,7L,17L,12L,9L,8L,9L,24L,11L,113L,55L,19L,22L,60L,40L,38L,42L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113514Inst : IEnumerable<long>
{
public static readonly long[] Value=A113514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113514.Bytes);
public long this[int i]=>Value[i];

public static A113514Inst Instance=new A113514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113515
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,2L,1L,1L,1L,4L,2L,2L,1L,1L,1L,1L,3L,1L,2L,1L,1L,3L,4L,1L,5L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,2L,2L,5L,1L,1L,6L,7L,1L,1L,2L,3L,1L,2L,3L,1L,4L,1L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113515Inst : IEnumerable<long>
{
public static readonly long[] Value=A113515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113515.Bytes);
public long this[int i]=>Value[i];

public static A113515Inst Instance=new A113515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113516
{
public static readonly long[] Value={ 2L,2L,2L,5L,2L,2L,13L,2L,3L,3L,5L,2L,3L,2L,2L,11L,2L,3L,17L,2L,2L,17L,4L,2L,3L,9L,2L,33L,7L,3L,7L,4L,2L,3L,5L,67L,5L,2L,9L,3L,2L,4L,25L,3L,4L,5L,5L,24L,3L,2L,3L,21L,3L,2L,9L,3L,2L,11L,2L,5L,3L,2L,4L,19L,31L,2L,29L,4L,2L,3019L,2L,21L,51L,3L,2L,3L,2L,2L,9L,2L,169L,965L,3L,3L,29L,3L,2848L,9L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113516Inst : IEnumerable<long>
{
public static readonly long[] Value=A113516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113516.Bytes);
public long this[int i]=>Value[i];

public static A113516Inst Instance=new A113516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113517
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,2L,0L,3L,4L,4L,4L,2L,0L,5L,18L,2L,12L,2L,0L,7L,3L,11L,13L,7L,0L,167L,15L,6L,63L,2L,0L,7L,6L,21L,49L,3L,0L,27L,30L,3L,22L,106L,0L,10L,30L,4L,294L,7L,0L,32L,19L,6L,7L,41L,0L,21L,4L,14L,34L,2L,0L,12L,13L,6L,147L,37L,0L,14L,139L,22L,46L,179L,0L,4L,75L,69L,15L,11L,0L,5L,211L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113517Inst : IEnumerable<long>
{
public static readonly long[] Value=A113517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113517.Bytes);
public long this[int i]=>Value[i];

public static A113517Inst Instance=new A113517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113518
{
public static readonly long[] Value={ 1L,42L,122L,224L,1665L,1861L,2504L,2530L,4750L,4765L,7831L,9589L,9932L,12141L,15574L,15749L,22629L,23492L,24350L,25819L,29837L,29940L,31106L,43589L,44496L,47526L,47751L,48020L,49216L,49304L,49637L,58051L,62381L,64112L,66710L,67047L,69244L,73954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113518Inst : IEnumerable<long>
{
public static readonly long[] Value=A113518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113518.Bytes);
public long this[int i]=>Value[i];

public static A113518Inst Instance=new A113518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113519
{
public static readonly long[] Value={ 9L,22L,134L,177L,226L,482L,737L,1046L,1282L,1681L,1977L,2641L,3202L,3401L,3817L,4034L,4486L,5462L,5721L,6817L,7401L,7702L,8966L,9634L,9977L,10681L,11042L,11409L,12937L,15409L,16726L,17177L,18566L,21506L,28617L,29801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113519Inst : IEnumerable<long>
{
public static readonly long[] Value=A113519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113519.Bytes);
public long this[int i]=>Value[i];

public static A113519Inst Instance=new A113519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113520
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,1L,6L,1L,8L,9L,10L,1L,12L,9L,14L,15L,16L,1L,18L,9L,20L,21L,22L,1L,24L,25L,26L,27L,28L,1L,30L,27L,32L,33L,34L,35L,36L,35L,38L,39L,40L,25L,42L,39L,44L,45L,46L,35L,48L,49L,50L,51L,52L,49L,54L,55L,56L,57L,58L,49L,60L,57L,62L,63L,64L,65L,66L,65L,68L,69L,70L,65L,72L,69L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113520Inst : IEnumerable<long>
{
public static readonly long[] Value=A113520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113520.Bytes);
public long this[int i]=>Value[i];

public static A113520Inst Instance=new A113520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113521
{
public static readonly long[] Value={ 1L,1L,1L,8L,9L,1L,9L,14L,15L,1L,9L,20L,21L,1L,24L,25L,26L,27L,1L,27L,32L,33L,34L,35L,35L,38L,39L,25L,39L,44L,45L,35L,48L,49L,50L,51L,49L,54L,55L,56L,57L,49L,57L,62L,63L,64L,65L,65L,68L,69L,65L,69L,74L,75L,76L,77L,77L,80L,81L,65L,84L,85L,86L,87L,77L,90L,91L,92L,93L,94L,95L,95L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113521Inst : IEnumerable<long>
{
public static readonly long[] Value=A113521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113521.Bytes);
public long this[int i]=>Value[i];

public static A113521Inst Instance=new A113521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113522
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,13L,19L,21L,27L,33L,37L,39L,57L,63L,77L,81L,91L,99L,111L,117L,133L,143L,171L,189L,209L,231L,247L,259L,273L,297L,333L,351L,399L,407L,429L,481L,513L,567L,627L,693L,703L,741L,777L,819L,891L,999L,1001L,1053L,1197L,1221L,1287L,1443L,1463L,1539L,1729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113522Inst : IEnumerable<long>
{
public static readonly long[] Value=A113522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113522.Bytes);
public long this[int i]=>Value[i];

public static A113522Inst Instance=new A113522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113523
{
public static readonly long[] Value={ 0L,0L,0L,4L,4L,6L,6L,8L,9L,10L,10L,12L,12L,14L,15L,16L,16L,18L,18L,20L,21L,22L,22L,24L,25L,26L,27L,28L,28L,30L,30L,32L,33L,34L,35L,36L,36L,38L,39L,40L,40L,42L,42L,44L,45L,46L,46L,48L,49L,50L,51L,52L,52L,54L,55L,56L,57L,58L,58L,60L,60L,62L,63L,64L,65L,66L,66L,68L,69L,70L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113523Inst : IEnumerable<long>
{
public static readonly long[] Value=A113523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113523.Bytes);
public long this[int i]=>Value[i];

public static A113523Inst Instance=new A113523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113524
{
public static readonly long[] Value={ 25L,141L,185L,235L,291L,753L,851L,955L,1565L,1851L,2495L,3235L,3641L,4295L,5251L,5765L,6031L,6865L,8061L,9353L,9691L,10741L,11103L,14215L,14631L,15481L,16355L,16801L,17711L,21085L,25855L,27553L,28131L,28715L,29305L,29901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113524Inst : IEnumerable<long>
{
public static readonly long[] Value=A113524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113524.Bytes);
public long this[int i]=>Value[i];

public static A113524Inst Instance=new A113524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113525
{
public static readonly long[] Value={ 4L,49L,301L,589L,973L,2353L,2701L,3073L,4333L,5293L,5809L,6349L,6913L,7501L,8749L,9409L,10801L,11533L,13069L,14701L,15553L,16429L,23233L,24301L,25393L,27649L,30001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113525Inst : IEnumerable<long>
{
public static readonly long[] Value=A113525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113525.Bytes);
public long this[int i]=>Value[i];

public static A113525Inst Instance=new A113525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113526
{
public static readonly BigInteger[] Value={ 1L,3L,13L,313L,13313L,31313313L,1331331313313L,BigInteger.Parse("313133131331331313313"),BigInteger.Parse("1331331313313313133131331331313313"),BigInteger.Parse("3131331313313313133131331331313313313133131331331313313") };
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
public class A113526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113526Inst Instance=new A113526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113527
{
public static readonly long[] Value={ 15L,115L,155L,201L,253L,445L,785L,1345L,2215L,3503L,3711L,4145L,4841L,5853L,6395L,7855L,9131L,12353L,13535L,14353L,16503L,18331L,19281L,20255L,20751L,21253L,21761L,23853L,24935L,26603L,29503L,30101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113527Inst : IEnumerable<long>
{
public static readonly long[] Value=A113527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113527.Bytes);
public long this[int i]=>Value[i];

public static A113527Inst Instance=new A113527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113528
{
public static readonly long[] Value={ 6L,34L,57L,86L,121L,209L,262L,321L,386L,706L,1241L,1366L,1497L,2582L,2761L,3334L,3746L,3961L,4881L,5377L,6166L,6722L,7009L,7601L,8857L,9862L,10562L,10921L,12417L,13201L,14422L,15697L,17026L,17481L,17942L,18409L,19361L,19846L,20337L,21337L,22361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113528Inst : IEnumerable<long>
{
public static readonly long[] Value=A113528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113528.Bytes);
public long this[int i]=>Value[i];

public static A113528Inst Instance=new A113528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113529
{
public static readonly long[] Value={ 15L,20L,22L,23L,25L,26L,28L,30L,31L,36L,37L,38L,46L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113529Inst : IEnumerable<long>
{
public static readonly long[] Value=A113529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113529.Bytes);
public long this[int i]=>Value[i];

public static A113529Inst Instance=new A113529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113530
{
public static readonly long[] Value={ 91L,169L,217L,469L,721L,817L,1027L,1141L,1261L,1387L,2611L,2977L,3781L,3997L,4681L,5677L,5941L,6487L,6769L,7651L,7957L,8587L,9577L,10981L,11347L,12481L,12871L,14077L,14491L,15769L,16207L,17557L,18019L,18961L,20419L,20917L,21421L,22969L,24031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113530Inst : IEnumerable<long>
{
public static readonly long[] Value=A113530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113530.Bytes);
public long this[int i]=>Value[i];

public static A113530Inst Instance=new A113530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113531
{
public static readonly long[] Value={ 1L,21L,321L,2005L,7737L,22461L,54121L,114381L,219345L,390277L,654321L,1045221L,1604041L,2379885L,3430617L,4823581L,6636321L,8957301L,11886625L,15536757L,20033241L,25515421L,32137161L,40067565L,49491697L,60611301L,73645521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113531Inst : IEnumerable<long>
{
public static readonly long[] Value=A113531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113531.Bytes);
public long this[int i]=>Value[i];

public static A113531Inst Instance=new A113531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113532
{
public static readonly long[] Value={ 1L,28L,769L,7108L,36409L,131836L,380713L,937924L,2054353L,4110364L,7654321L,13446148L,22505929L,36167548L,56137369L,84557956L,124076833L,177920284L,249972193L,344857924L,468033241L,625878268L,825796489L,1076318788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113532Inst : IEnumerable<long>
{
public static readonly long[] Value=A113532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113532.Bytes);
public long this[int i]=>Value[i];

public static A113532Inst Instance=new A113532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113533
{
public static readonly long[] Value={ 1L,3L,6L,5L,7L,12L,10L,15L,14L,14L,23L,16L,20L,27L,21L,30L,27L,25L,40L,28L,37L,38L,32L,49L,36L,40L,53L,39L,54L,49L,43L,68L,45L,55L,66L,50L,71L,60L,56L,83L,57L,74L,75L,61L,92L,67L,73L,94L,68L,93L,84L,72L,113L,75L,94L,101L,79L,116L,89L,91L,122L,86L,115L,108L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113533Inst : IEnumerable<long>
{
public static readonly long[] Value=A113533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113533.Bytes);
public long this[int i]=>Value[i];

public static A113533Inst Instance=new A113533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113534
{
public static readonly long[] Value={ 1L,3L,6L,7L,20L,10L,39L,12L,26L,19L,20L,43L,21L,78L,24L,53L,30L,57L,43L,88L,61L,59L,56L,43L,90L,42L,155L,46L,109L,53L,122L,75L,105L,114L,73L,122L,62L,197L,63L,172L,71L,136L,96L,183L,140L,122L,139L,86L,179L,81L,304L,83L,185L,98L,153L,162L,160L,261L,121L,192L,107L,236L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113534Inst : IEnumerable<long>
{
public static readonly long[] Value=A113534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113534.Bytes);
public long this[int i]=>Value[i];

public static A113534Inst Instance=new A113534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113535
{
public static readonly long[] Value={ 1L,3L,8L,19L,32L,9L,11L,16L,26L,19L,29L,24L,47L,70L,28L,31L,58L,89L,35L,50L,65L,108L,65L,51L,52L,90L,101L,82L,101L,88L,122L,63L,81L,92L,153L,110L,89L,125L,110L,92L,101L,155L,90L,127L,196L,142L,87L,138L,207L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113535Inst : IEnumerable<long>
{
public static readonly long[] Value=A113535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113535.Bytes);
public long this[int i]=>Value[i];

public static A113535Inst Instance=new A113535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113536
{
public static readonly long[] Value={ 0L,2L,4L,10L,12L,16L,18L,28L,40L,42L,44L,46L,60L,68L,72L,82L,84L,88L,94L,108L,110L,114L,116L,122L,126L,142L,144L,152L,158L,180L,192L,194L,198L,200L,220L,222L,264L,266L,268L,282L,284L,296L,298L,332L,336L,340L,354L,378L,380L,418L,420L,430L,434L,446L,464L,466L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113536Inst : IEnumerable<long>
{
public static readonly long[] Value=A113536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113536.Bytes);
public long this[int i]=>Value[i];

public static A113536Inst Instance=new A113536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113537
{
public static readonly long[] Value={ 114L,126L,144L,180L,486L,684L,864L,1080L,1176L,1866L,1956L,2166L,2226L,2454L,2634L,2880L,3090L,3474L,4176L,4314L,5124L,5586L,5730L,5820L,6030L,6276L,6324L,6456L,6624L,6846L,6954L,7110L,7830L,7914L,8166L,8556L,8724L,9054L,9180L,9576L,9786L,9816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113537Inst : IEnumerable<long>
{
public static readonly long[] Value=A113537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113537.Bytes);
public long this[int i]=>Value[i];

public static A113537Inst Instance=new A113537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113538
{
public static readonly BigInteger[] Value={ BigInteger.Parse("3608528850368400786036725"),BigInteger.Parse("45654723072420840000"),3654081096960006804L,45088208494568L,54648000L,6327096165L,7290842L,81072L,902468L,30849008L,55258568L,247808L,658563L,705672L,304380098L,6462L,342006L,7220L,38016725L,6094L };
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
public class A113538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113538Inst Instance=new A113538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113539
{
public static readonly long[] Value={ 2L,4L,2L,14L,10L,26L,8L,80L,20L,20L,110L,64L,8L,16L,110L,106L,10L,280L,8L,166L,92L,364L,68L,310L,130L,836L,70L,364L,238L,434L,892L,1844L,58L,140L,10L,740L,482L,1274L,308L,494L,1220L,2644L,790L,646L,2248L,2456L,422L,314L,1072L,1124L,782L,200L,98L,1826L,1502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113539Inst : IEnumerable<long>
{
public static readonly long[] Value=A113539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113539.Bytes);
public long this[int i]=>Value[i];

public static A113539Inst Instance=new A113539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113540
{
public static readonly long[] Value={ 2L,6L,12L,6L,42L,18L,66L,126L,144L,762L,78L,318L,1026L,84L,264L,354L,288L,102L,1242L,162L,168L,318L,2058L,234L,2352L,252L,2532L,42L,342L,102L,2034L,2946L,222L,606L,882L,348L,3366L,2472L,264L,2988L,2466L,336L,666L,762L,222L,438L,3432L,6834L,3816L,588L,1818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113540Inst : IEnumerable<long>
{
public static readonly long[] Value=A113540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113540.Bytes);
public long this[int i]=>Value[i];

public static A113540Inst Instance=new A113540Inst();

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