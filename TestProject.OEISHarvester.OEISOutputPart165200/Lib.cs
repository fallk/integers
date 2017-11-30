using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195657
{
public static readonly long[] Value={ 512L,17536L,218052L,1599820L,8500668L,36383284L,133538996L,437500380L,1314748124L,3694894500L,9849731140L,25173962492L,62193359676L,149475988116L,351246183572L,810197361564L,1840289301660L,4126688132548L,9154339355684L,20122502355004L,43888598831484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195657Inst : IEnumerable<long>
{
public static readonly long[] Value=A195657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195657.Bytes);
public long this[int i]=>Value[i];

public static A195657Inst Instance=new A195657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195658
{
public static readonly long[] Value={ 1024L,50922L,815816L,7238864L,44693472L,216134044L,877751236L,3130270224L,10105541204L,30179587994L,84719304384L,226268016376L,580363147336L,1440139184616L,3477556916828L,8210011147304L,19021962952188L,43385173057846L,97653259485592L,217359166880016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195658Inst : IEnumerable<long>
{
public static readonly long[] Value=A195658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195658.Bytes);
public long this[int i]=>Value[i];

public static A195658Inst Instance=new A195658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195659
{
public static readonly long[] Value={ 2048L,148352L,3076180L,33175486L,239238888L,1314160492L,5937279840L,23174548666L,80812754568L,257860425672L,766319864440L,2149806985106L,5753007728148L,14807729805472L,36902750545260L,89523360235366L,212335537312668L,494171055510052L,1131839140825580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195659Inst : IEnumerable<long>
{
public static readonly long[] Value=A195659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195659.Bytes);
public long this[int i]=>Value[i];

public static A195659Inst Instance=new A195659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195660
{
public static readonly long[] Value={ 4096L,433500L,11682296L,153802520L,1301236304L,8155899320L,41180193352L,176740657340L,668845118276L,2290966142762L,7241521734020L,21437333168798L,60123048359816L,161217291701134L,416373921218580L,1041997475699102L,2539265644237492L,6050425313244116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195660Inst : IEnumerable<long>
{
public static readonly long[] Value=A195660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195660.Bytes);
public long this[int i]=>Value[i];

public static A195660Inst Instance=new A195660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195661
{
public static readonly long[] Value={ 8192L,1270246L,44653028L,720390254L,7177627944L,51526819510L,291859775552L,1382652697282L,5700499630916L,21042965606234L,71028444904044L,222770819826574L,657397551407816L,1843639061043694L,4953451546255928L,12835026767559890L,32249277650536068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195661Inst : IEnumerable<long>
{
public static readonly long[] Value=A195661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195661.Bytes);
public long this[int i]=>Value[i];

public static A195661Inst Instance=new A195661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195662
{
public static readonly long[] Value={ -3L,2L,0L,2L,0L,3L,2L,0L,1L,0L,2L,0L,-1L,0L,-3L,2L,0L,-3L,0L,-4L,0L,2L,0L,-5L,0L,-3L,0L,3L,2L,0L,-7L,0L,0L,0L,7L,0L,2L,0L,-9L,0L,5L,0L,10L,0L,-3L,2L,0L,-11L,0L,12L,0L,10L,0L,-10L,0L,2L,0L,-13L,0L,21L,0L,5L,0L,-20L,0L,3L,2L,0L,-15L,0L,32L,0L,-7L,0L,-30L,0L,13L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195662Inst : IEnumerable<long>
{
public static readonly long[] Value=A195662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195662.Bytes);
public long this[int i]=>Value[i];

public static A195662Inst Instance=new A195662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195663
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,1L,4L,3L,3L,3L,5L,4L,2L,1L,2L,6L,5L,4L,2L,3L,3L,7L,6L,5L,4L,1L,2L,1L,8L,7L,6L,5L,4L,1L,2L,2L,9L,8L,7L,6L,5L,4L,4L,1L,1L,10L,9L,8L,7L,6L,5L,3L,4L,4L,4L,11L,10L,9L,8L,7L,6L,5L,3L,2L,1L,2L,12L,11L,10L,9L,8L,7L,6L,5L,3L,2L,4L,4L,13L,12L,11L,10L,9L,8L,7L,6L,5L,3L,1L,2L,1L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,3L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195663Inst : IEnumerable<long>
{
public static readonly long[] Value=A195663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195663.Bytes);
public long this[int i]=>Value[i];

public static A195663Inst Instance=new A195663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195664
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,0L,3L,2L,2L,2L,4L,3L,1L,0L,1L,5L,4L,3L,1L,2L,2L,6L,5L,4L,3L,0L,1L,0L,7L,6L,5L,4L,3L,0L,1L,1L,8L,7L,6L,5L,4L,3L,3L,0L,0L,9L,8L,7L,6L,5L,4L,2L,3L,3L,3L,10L,9L,8L,7L,6L,5L,4L,2L,1L,0L,1L,11L,10L,9L,8L,7L,6L,5L,4L,2L,1L,3L,3L,12L,11L,10L,9L,8L,7L,6L,5L,4L,2L,0L,1L,0L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,2L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195664Inst : IEnumerable<long>
{
public static readonly long[] Value=A195664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195664.Bytes);
public long this[int i]=>Value[i];

public static A195664Inst Instance=new A195664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195665
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,1L,4L,5L,2L,3L,6L,7L,0L,2L,4L,6L,1L,3L,5L,7L,0L,4L,1L,5L,2L,6L,3L,7L,0L,4L,2L,6L,1L,5L,3L,7L,0L,1L,2L,3L,8L,9L,10L,11L,4L,5L,6L,7L,12L,13L,14L,15L,0L,2L,1L,3L,8L,10L,9L,11L,4L,6L,5L,7L,12L,14L,13L,15L,0L,1L,4L,5L,8L,9L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195665Inst : IEnumerable<long>
{
public static readonly long[] Value=A195665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195665.Bytes);
public long this[int i]=>Value[i];

public static A195665Inst Instance=new A195665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195666
{
public static readonly long[] Value={ 17L,52L,88L,99L,147L,175L,210L,224L,250L,252L,300L,320L,360L,384L,405L,432L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195666Inst : IEnumerable<long>
{
public static readonly long[] Value=A195666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195666.Bytes);
public long this[int i]=>Value[i];

public static A195666Inst Instance=new A195666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195667
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,14L,17L,22L,26L,35L,40L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195667Inst : IEnumerable<long>
{
public static readonly long[] Value=A195667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195667.Bytes);
public long this[int i]=>Value[i];

public static A195667Inst Instance=new A195667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195668
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,11L,15L,18L,21L,25L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195668Inst : IEnumerable<long>
{
public static readonly long[] Value=A195668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195668.Bytes);
public long this[int i]=>Value[i];

public static A195668Inst Instance=new A195668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195669
{
public static readonly long[] Value={ 1L,2L,4L,7L,9L,13L,15L,18L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195669Inst : IEnumerable<long>
{
public static readonly long[] Value=A195669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195669.Bytes);
public long this[int i]=>Value[i];

public static A195669Inst Instance=new A195669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195670
{
public static readonly long[] Value={ 144L,145L,733L,5160L,5161L,5162L,5163L,5164L,5165L,5166L,5167L,5168L,5169L,40440L,40441L,40442L,40443L,40444L,40445L,40446L,40447L,40448L,40449L,40584L,40585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195670Inst : IEnumerable<long>
{
public static readonly long[] Value=A195670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195670.Bytes);
public long this[int i]=>Value[i];

public static A195670Inst Instance=new A195670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195671
{
public static readonly long[] Value={ 135L,1715L,23328L,2239488L,2233772L,9289728L,21233664L,27869184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195671Inst : IEnumerable<long>
{
public static readonly long[] Value=A195671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195671.Bytes);
public long this[int i]=>Value[i];

public static A195671Inst Instance=new A195671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195672
{
public static readonly long[] Value={ 264L,1386L,1634L,2401L,2403L,2407L,3786L,6572L,6579L,8208L,8970L,8971L,8972L,8973L,8974L,8975L,8976L,8977L,8978L,8979L,9474L,15283L,28570L,28571L,28572L,28573L,28574L,28575L,28576L,28577L,28578L,28579L,36499L,38564L,65540L,65541L,65542L,65543L,65544L,65545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195672Inst : IEnumerable<long>
{
public static readonly long[] Value=A195672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195672.Bytes);
public long this[int i]=>Value[i];

public static A195672Inst Instance=new A195672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195673
{
public static readonly long[] Value={ -2L,3L,0L,3L,0L,2L,3L,0L,-1L,0L,3L,0L,-4L,0L,-2L,3L,0L,-7L,0L,-1L,0L,3L,0L,-10L,0L,3L,0L,2L,3L,0L,-13L,0L,10L,0L,3L,0L,3L,0L,-16L,0L,20L,0L,0L,0L,-2L,3L,0L,-19L,0L,33L,0L,-10L,0L,-5L,0L,3L,0L,-22L,0L,49L,0L,-30L,0L,-5L,0L,2L,3L,0L,-25L,0L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195673Inst : IEnumerable<long>
{
public static readonly long[] Value=A195673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195673.Bytes);
public long this[int i]=>Value[i];

public static A195673Inst Instance=new A195673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195674
{
public static readonly long[] Value={ 132L,262L,16524L,78140L,78141L,78142L,78143L,78144L,78145L,78146L,78147L,78148L,78149L,78275L,94520L,94521L,94522L,94533L,94534L,94535L,94536L,94537L,94538L,94539L,94652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195674Inst : IEnumerable<long>
{
public static readonly long[] Value=A195674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195674.Bytes);
public long this[int i]=>Value[i];

public static A195674Inst Instance=new A195674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195675
{
public static readonly long[] Value={ 0L,1L,3L,9L,28L,88L,278L,873L,2742L,8616L,27067L,85032L,267137L,839237L,2636540L,8282934L,26021606L,81749286L,256822958L,806833117L,2534740992L,7963123679L,25016890851L,78592880513L,246906816043L,775680639401L,2436872598275L,7655661052475L,24050968520829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195675Inst : IEnumerable<long>
{
public static readonly long[] Value=A195675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195675.Bytes);
public long this[int i]=>Value[i];

public static A195675Inst Instance=new A195675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195676
{
public static readonly long[] Value={ 1L,3L,8L,20L,29L,36L,72L,112L,188L,322L,576L,1024L,1836L,3206L,5086L,7440L,9601L,12890L,16555L,20328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195676Inst : IEnumerable<long>
{
public static readonly long[] Value=A195676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195676.Bytes);
public long this[int i]=>Value[i];

public static A195676Inst Instance=new A195676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195677
{
public static readonly long[] Value={ 1L,4L,8L,40L,44L,48L,49L,100L,101L,150L,154L,190L,192L,196L,200L,254L,290L,292L,296L,298L,350L,352L,374L,376L,384L,386L,442L,443L,444L,446L,447L,448L,482L,483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195677Inst : IEnumerable<long>
{
public static readonly long[] Value=A195677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195677.Bytes);
public long this[int i]=>Value[i];

public static A195677Inst Instance=new A195677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195678
{
public static readonly long[] Value={ 64L,115L,1217L,1477206L,96672L,136644591L,3640452L,6347782194286L,72339267L,4159327027119583L,5595833084L,58866692131428799L,216432682702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195678Inst : IEnumerable<long>
{
public static readonly long[] Value=A195678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195678.Bytes);
public long this[int i]=>Value[i];

public static A195678Inst Instance=new A195678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195679
{
public static readonly long[] Value={ 2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L,2L,2L,0L,-1L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195679Inst : IEnumerable<long>
{
public static readonly long[] Value=A195679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195679.Bytes);
public long this[int i]=>Value[i];

public static A195679Inst Instance=new A195679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195680
{
public static readonly BigInteger[] Value={ 7L,2772L,5945L,26144L,285621L,257076560L,2386970016L,103850955649L,254621037540L,3060691213613L,29733959304728L,62837775720000L,89511043811115L,453985767379732L,1567652657852541L,35830073055128140L,BigInteger.Parse("22926879590846577132") };
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
public class A195680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195680.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195680Inst Instance=new A195680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195681
{
public static readonly BigInteger[] Value={ 24L,9605L,20592L,90567L,989420L,890539329L,8268706687L,359750263200L,882033147389L,10602545376516L,103001456451945L,217676440363319L,310075351438748L,1572652830029685L,5430508104041980L,124119013940773131L,BigInteger.Parse("79421040620720449885") };
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
public class A195681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195681Inst Instance=new A195681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195682
{
public static readonly BigInteger[] Value={ 25L,9997L,21433L,94265L,1029821L,926902721L,8606342785L,374439945601L,918049206661L,11035479109045L,107207314895753L,226564822394569L,322736658181277L,1636868962618493L,5652252040004741L,129187165603885181L,BigInteger.Parse("82664039951186181157") };
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
public class A195682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195682Inst Instance=new A195682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195683
{
public static readonly long[] Value={ 0L,16L,20L,21L,22L,24L,32L,64L,107L,193L,364L,664L,1264L,2421L,4649L,8934L,17504L,34344L,67424L,132427L,260205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195683Inst : IEnumerable<long>
{
public static readonly long[] Value=A195683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195683.Bytes);
public long this[int i]=>Value[i];

public static A195683Inst Instance=new A195683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195684
{
public static readonly long[] Value={ 0L,5L,9L,10L,11L,18L,31L,57L,104L,192L,366L,701L,1353L,2649L,5194L,10196L,20026L,39686L,79006L,157316L,313279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195684Inst : IEnumerable<long>
{
public static readonly long[] Value=A195684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195684.Bytes);
public long this[int i]=>Value[i];

public static A195684Inst Instance=new A195684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195685
{
public static readonly long[] Value={ 17L,43L,47L,71L,101L,107L,109L,151L,197L,223L,317L,349L,461L,521L,569L,631L,673L,701L,821L,881L,919L,947L,971L,991L,1051L,1091L,1109L,1153L,1181L,1217L,1231L,1259L,1321L,1361L,1367L,1549L,1693L,1801L,1847L,1933L,1951L,1979L,2143L,2207L,2267L,2297L,2441L,2801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195685Inst : IEnumerable<long>
{
public static readonly long[] Value=A195685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195685.Bytes);
public long this[int i]=>Value[i];

public static A195685Inst Instance=new A195685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195686
{
public static readonly long[] Value={ 1L,2L,3L,20L,35L,252L,154L,3432L,6435L,48620L,92378L,705432L,676039L,10400600L,20058300L,10341168L,300540195L,2333606220L,1512522550L,35345263800L,6892326441L,179419291480L,1052049481860L,8233430727600L,2687300306925L,126410606437752L,247959266474052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195686Inst : IEnumerable<long>
{
public static readonly long[] Value=A195686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195686.Bytes);
public long this[int i]=>Value[i];

public static A195686Inst Instance=new A195686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195687
{
public static readonly BigInteger[] Value={ 3L,8L,28L,1863L,4400L,433008L,262353L,352207108L,379920428L,18418959496L,91011249895L,978117768540L,11516765628956L,1219780690817560L,708294344602810604L,BigInteger.Parse("25852535312829023356"),BigInteger.Parse("229222230912132985022679") };
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
public class A195687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195687Inst Instance=new A195687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195688
{
public static readonly BigInteger[] Value={ 4L,15L,45L,3016L,7119L,700625L,424496L,569883075L,614724165L,29802502503L,147259295688L,1582627794499L,18634518228117L,1973646616563639L,1146044323606678197L,BigInteger.Parse("41830280831514255267"),BigInteger.Parse("370889360592907981397560"),BigInteger.Parse("26770920007080137664392439") };
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
public class A195688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195688.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195688Inst Instance=new A195688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195689
{
public static readonly BigInteger[] Value={ 5L,17L,53L,3545L,8369L,823633L,499025L,669937733L,722651597L,35034942905L,173113684537L,1860490554949L,21906189996125L,2320160748906089L,1347255903779016125L,BigInteger.Parse("49174444344033218405"),BigInteger.Parse("436006592777392918253129"),BigInteger.Parse("31471103940926430492910889") };
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
public class A195689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195689Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195689.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195689.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195689Inst Instance=new A195689Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195690
{
public static readonly long[] Value={ 2L,6L,72L,76L,162L,228L,230L,238L,316L,434L,530L,580L,686L,690L,714L,716L,756L,770L,948L,994L,1034L,1054L,1216L,1302L,1358L,1490L,1590L,1740L,1778L,1836L,1870L,1996L,2058L,2148L,2310L,2354L,2414L,2438L,2492L,2596L,2668L,2786L,2876L,2930L,2982L,3002L,3102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195690Inst : IEnumerable<long>
{
public static readonly long[] Value=A195690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195690.Bytes);
public long this[int i]=>Value[i];

public static A195690Inst Instance=new A195690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195691
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,2L,1L,4L,4L,8L,7L,18L,23L,42L,50L,105L,153L,271L,385L,721L,1135L,1992L,3112L,5535L,9105L,15916L,26219L,45815L,77334L,135029L,229189L,399498L,685710L,1198828L,2070207L,3619677L,6286268L,11024475L,19241836L,33795365L,59197968L,104234931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195691Inst : IEnumerable<long>
{
public static readonly long[] Value=A195691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195691.Bytes);
public long this[int i]=>Value[i];

public static A195691Inst Instance=new A195691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195692
{
public static readonly long[] Value={ 9L,0L,4L,5L,5L,6L,8L,9L,4L,3L,0L,2L,3L,8L,1L,3L,6L,4L,1L,2L,7L,3L,1L,6L,7L,9L,5L,6L,6L,1L,9L,5L,8L,7L,2L,1L,4L,3L,1L,0L,9L,4L,5L,6L,0L,9L,6L,1L,6L,0L,5L,0L,6L,7L,6L,5L,5L,9L,9L,8L,4L,5L,3L,3L,4L,9L,9L,2L,9L,2L,1L,3L,7L,6L,4L,0L,4L,5L,2L,1L,7L,6L,0L,6L,1L,1L,0L,5L,8L,1L,5L,0L,1L,4L,7L,7L,3L,9L,8L,7L,3L,1L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195692Inst : IEnumerable<long>
{
public static readonly long[] Value=A195692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195692.Bytes);
public long this[int i]=>Value[i];

public static A195692Inst Instance=new A195692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195693
{
public static readonly long[] Value={ 5L,5L,3L,5L,7L,4L,3L,5L,8L,8L,9L,7L,0L,4L,5L,2L,5L,1L,5L,0L,8L,5L,3L,2L,7L,3L,0L,0L,8L,9L,2L,6L,8L,5L,2L,0L,0L,3L,5L,0L,2L,3L,8L,2L,2L,7L,0L,0L,7L,1L,6L,3L,2L,3L,3L,3L,8L,2L,6L,9L,6L,0L,3L,7L,1L,6L,8L,5L,5L,1L,6L,9L,4L,8L,8L,6L,8L,1L,3L,9L,7L,0L,0L,6L,7L,0L,8L,5L,6L,4L,3L,4L,3L,0L,8L,5L,3L,2L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195693Inst : IEnumerable<long>
{
public static readonly long[] Value=A195693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195693.Bytes);
public long this[int i]=>Value[i];

public static A195693Inst Instance=new A195693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195694
{
public static readonly long[] Value={ 2L,2L,3L,7L,0L,3L,5L,7L,5L,9L,2L,8L,7L,4L,1L,1L,8L,7L,4L,3L,3L,5L,3L,2L,6L,5L,8L,7L,6L,1L,7L,5L,4L,4L,1L,6L,2L,7L,6L,6L,0L,7L,4L,8L,3L,8L,4L,1L,3L,5L,0L,0L,7L,5L,3L,3L,1L,8L,9L,4L,6L,1L,3L,8L,9L,5L,7L,8L,8L,7L,1L,9L,2L,5L,2L,2L,1L,6L,3L,7L,8L,1L,0L,2L,1L,9L,2L,4L,2L,4L,3L,8L,4L,0L,6L,3L,9L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195694Inst : IEnumerable<long>
{
public static readonly long[] Value=A195694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195694.Bytes);
public long this[int i]=>Value[i];

public static A195694Inst Instance=new A195694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195695
{
public static readonly long[] Value={ 6L,1L,5L,4L,7L,9L,7L,0L,8L,6L,7L,0L,3L,8L,7L,3L,4L,1L,0L,6L,7L,4L,6L,4L,5L,8L,9L,1L,2L,3L,9L,9L,3L,6L,8L,7L,8L,5L,5L,1L,7L,0L,0L,0L,4L,6L,7L,7L,5L,4L,7L,4L,1L,9L,5L,2L,7L,7L,7L,4L,1L,6L,6L,8L,3L,1L,9L,9L,6L,1L,5L,7L,2L,3L,9L,1L,2L,8L,0L,4L,3L,9L,2L,6L,6L,2L,5L,8L,1L,0L,0L,8L,5L,4L,3L,0L,4L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195695Inst : IEnumerable<long>
{
public static readonly long[] Value=A195695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195695.Bytes);
public long this[int i]=>Value[i];

public static A195695Inst Instance=new A195695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195696
{
public static readonly long[] Value={ 9L,5L,5L,3L,1L,6L,6L,1L,8L,1L,2L,4L,5L,0L,9L,2L,7L,8L,1L,6L,3L,8L,5L,7L,1L,0L,2L,5L,1L,5L,7L,5L,7L,7L,5L,4L,2L,4L,3L,4L,1L,4L,6L,9L,5L,0L,1L,0L,0L,0L,5L,4L,9L,0L,9L,5L,9L,6L,9L,8L,1L,2L,9L,3L,2L,1L,9L,1L,2L,0L,4L,5L,9L,0L,3L,9L,7L,6L,4L,5L,5L,3L,8L,7L,3L,9L,1L,6L,0L,2L,5L,8L,5L,6L,2L,8L,0L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195696Inst : IEnumerable<long>
{
public static readonly long[] Value=A195696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195696.Bytes);
public long this[int i]=>Value[i];

public static A195696Inst Instance=new A195696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195697
{
public static readonly long[] Value={ 2L,1L,3L,-1L,12L,1L,30L,1L,35L,-1L,56L,1L,90L,1L,99L,-1L,132L,1L,182L,1L,195L,-1L,240L,1L,306L,1L,323L,-1L,380L,1L,462L,1L,483L,-1L,552L,1L,650L,1L,675L,-1L,756L,1L,870L,1L,899L,-1L,992L,1L,1122L,1L,1155L,-1L,1260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195697Inst : IEnumerable<long>
{
public static readonly long[] Value=A195697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195697.Bytes);
public long this[int i]=>Value[i];

public static A195697Inst Instance=new A195697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195698
{
public static readonly long[] Value={ 2L,1L,8L,6L,2L,7L,6L,0L,3L,5L,4L,6L,5L,2L,8L,3L,9L,6L,0L,2L,9L,8L,7L,8L,6L,2L,8L,0L,7L,6L,3L,7L,4L,5L,1L,2L,9L,9L,5L,3L,7L,5L,4L,7L,0L,4L,3L,6L,5L,1L,0L,0L,3L,3L,0L,0L,1L,5L,2L,4L,6L,4L,6L,2L,9L,8L,5L,9L,0L,4L,3L,6L,0L,3L,8L,2L,2L,3L,2L,5L,4L,3L,2L,4L,0L,6L,4L,3L,2L,2L,2L,7L,5L,6L,4L,8L,8L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195698Inst : IEnumerable<long>
{
public static readonly long[] Value=A195698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195698.Bytes);
public long this[int i]=>Value[i];

public static A195698Inst Instance=new A195698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195699
{
public static readonly long[] Value={ 3L,6L,1L,3L,6L,7L,1L,2L,3L,9L,0L,6L,7L,0L,7L,8L,0L,5L,5L,8L,9L,1L,8L,8L,6L,7L,6L,3L,2L,0L,6L,6L,6L,6L,8L,1L,0L,1L,2L,6L,0L,9L,2L,4L,3L,2L,1L,2L,2L,2L,0L,1L,3L,3L,8L,1L,3L,3L,7L,7L,0L,6L,6L,2L,9L,1L,8L,5L,3L,6L,9L,0L,9L,5L,7L,3L,1L,5L,1L,3L,2L,4L,8L,2L,4L,1L,3L,8L,0L,5L,4L,6L,9L,5L,5L,0L,6L,5L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195699Inst : IEnumerable<long>
{
public static readonly long[] Value=A195699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195699.Bytes);
public long this[int i]=>Value[i];

public static A195699Inst Instance=new A195699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195700
{
public static readonly long[] Value={ 6L,5L,9L,0L,5L,8L,0L,3L,5L,8L,2L,6L,4L,0L,8L,9L,8L,2L,8L,7L,2L,8L,3L,2L,1L,2L,7L,3L,2L,3L,0L,2L,0L,2L,3L,4L,9L,2L,3L,1L,9L,5L,4L,8L,3L,2L,9L,5L,3L,5L,7L,3L,5L,8L,4L,2L,6L,7L,7L,4L,2L,5L,8L,7L,0L,6L,6L,6L,6L,5L,7L,1L,3L,3L,1L,0L,4L,1L,6L,3L,8L,4L,5L,1L,1L,3L,4L,3L,3L,5L,2L,2L,1L,5L,2L,1L,9L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195700Inst : IEnumerable<long>
{
public static readonly long[] Value=A195700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195700.Bytes);
public long this[int i]=>Value[i];

public static A195700Inst Instance=new A195700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195701
{
public static readonly long[] Value={ 6L,8L,4L,7L,1L,9L,2L,0L,3L,0L,0L,2L,2L,8L,2L,9L,1L,3L,8L,8L,8L,0L,9L,8L,0L,6L,9L,7L,1L,1L,0L,6L,4L,0L,1L,5L,9L,2L,9L,2L,7L,3L,3L,0L,9L,1L,4L,2L,6L,6L,2L,2L,6L,2L,1L,1L,5L,1L,1L,0L,5L,2L,6L,3L,4L,9L,1L,4L,9L,4L,1L,4L,2L,5L,7L,1L,2L,6L,3L,2L,4L,4L,6L,9L,0L,8L,6L,2L,4L,1L,2L,9L,0L,3L,2L,9L,2L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195701Inst : IEnumerable<long>
{
public static readonly long[] Value=A195701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195701.Bytes);
public long this[int i]=>Value[i];

public static A195701Inst Instance=new A195701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195702
{
public static readonly long[] Value={ 2L,5L,2L,6L,1L,1L,2L,9L,4L,4L,9L,1L,9L,4L,0L,5L,8L,9L,7L,3L,9L,5L,1L,7L,8L,7L,9L,4L,1L,5L,5L,5L,0L,9L,1L,9L,6L,3L,4L,1L,9L,9L,9L,3L,9L,4L,6L,9L,7L,5L,5L,8L,4L,0L,1L,4L,4L,7L,1L,7L,0L,4L,2L,5L,4L,7L,5L,8L,2L,0L,2L,4L,9L,0L,4L,7L,0L,8L,0L,9L,5L,4L,7L,0L,1L,4L,0L,9L,0L,1L,5L,2L,5L,6L,6L,8L,6L,6L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195702Inst : IEnumerable<long>
{
public static readonly long[] Value=A195702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195702.Bytes);
public long this[int i]=>Value[i];

public static A195702Inst Instance=new A195702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195703
{
public static readonly long[] Value={ 9L,1L,1L,7L,3L,8L,2L,9L,0L,9L,6L,8L,4L,8L,7L,6L,3L,6L,3L,5L,8L,4L,8L,9L,5L,6L,4L,3L,1L,6L,7L,3L,1L,2L,0L,7L,1L,7L,5L,3L,8L,9L,2L,1L,6L,3L,9L,2L,1L,9L,5L,5L,5L,2L,0L,6L,0L,6L,9L,8L,0L,3L,7L,4L,4L,7L,2L,4L,1L,6L,3L,1L,8L,1L,2L,0L,6L,2L,8L,6L,0L,8L,6L,2L,8L,8L,3L,0L,7L,7L,4L,4L,9L,5L,3L,6L,5L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195703Inst : IEnumerable<long>
{
public static readonly long[] Value=A195703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195703.Bytes);
public long this[int i]=>Value[i];

public static A195703Inst Instance=new A195703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195704
{
public static readonly long[] Value={ 1L,9L,3L,2L,1L,6L,3L,4L,5L,0L,7L,0L,1L,6L,0L,4L,4L,2L,4L,8L,2L,0L,5L,1L,0L,3L,6L,7L,9L,6L,0L,4L,1L,8L,1L,2L,3L,1L,1L,1L,1L,9L,3L,9L,4L,2L,8L,9L,9L,7L,7L,3L,0L,4L,4L,3L,0L,0L,8L,4L,9L,3L,6L,2L,4L,4L,5L,7L,6L,1L,8L,9L,4L,1L,0L,0L,4L,1L,9L,6L,3L,1L,7L,9L,6L,4L,3L,1L,2L,1L,8L,1L,4L,0L,6L,0L,9L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195704Inst : IEnumerable<long>
{
public static readonly long[] Value=A195704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195704.Bytes);
public long this[int i]=>Value[i];

public static A195704Inst Instance=new A195704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195705
{
public static readonly long[] Value={ 5L,4L,9L,4L,6L,7L,2L,4L,4L,7L,5L,7L,6L,2L,7L,3L,7L,1L,0L,8L,5L,4L,0L,0L,2L,5L,0L,3L,2L,6L,7L,3L,1L,9L,7L,6L,9L,9L,3L,0L,6L,1L,4L,2L,4L,2L,5L,6L,8L,9L,1L,9L,0L,6L,8L,2L,3L,2L,2L,4L,8L,1L,3L,3L,3L,3L,9L,9L,8L,2L,8L,1L,3L,9L,4L,6L,6L,3L,7L,0L,7L,8L,4L,3L,0L,0L,0L,9L,9L,9L,7L,3L,0L,0L,6L,2L,1L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195705Inst : IEnumerable<long>
{
public static readonly long[] Value=A195705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195705.Bytes);
public long this[int i]=>Value[i];

public static A195705Inst Instance=new A195705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195706
{
public static readonly long[] Value={ 2L,2L,2L,9L,8L,5L,4L,3L,6L,2L,6L,2L,1L,3L,0L,5L,6L,0L,2L,1L,0L,4L,1L,5L,3L,8L,1L,8L,9L,6L,2L,7L,7L,1L,6L,7L,7L,0L,2L,1L,7L,8L,0L,1L,8L,2L,9L,8L,2L,9L,1L,0L,2L,6L,8L,9L,1L,4L,2L,4L,6L,5L,5L,4L,8L,6L,0L,5L,7L,4L,7L,7L,4L,4L,7L,4L,1L,4L,6L,1L,3L,7L,7L,6L,5L,1L,5L,1L,7L,4L,7L,8L,9L,2L,5L,8L,0L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195706Inst : IEnumerable<long>
{
public static readonly long[] Value=A195706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195706.Bytes);
public long this[int i]=>Value[i];

public static A195706Inst Instance=new A195706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195707
{
public static readonly long[] Value={ 6L,6L,8L,9L,6L,4L,0L,7L,4L,2L,6L,8L,4L,0L,7L,1L,3L,0L,1L,4L,1L,3L,2L,7L,1L,1L,2L,6L,1L,2L,1L,7L,6L,4L,7L,8L,0L,1L,6L,9L,3L,0L,7L,1L,8L,1L,1L,9L,6L,3L,4L,7L,0L,8L,1L,6L,2L,9L,2L,9L,7L,6L,0L,3L,5L,2L,0L,5L,0L,4L,1L,5L,4L,9L,0L,1L,8L,2L,2L,3L,8L,8L,0L,5L,9L,8L,6L,4L,2L,4L,0L,2L,1L,7L,7L,4L,0L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195707Inst : IEnumerable<long>
{
public static readonly long[] Value=A195707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195707.Bytes);
public long this[int i]=>Value[i];

public static A195707Inst Instance=new A195707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195708
{
public static readonly long[] Value={ 8L,8L,6L,0L,7L,7L,1L,2L,3L,7L,9L,2L,6L,1L,3L,7L,0L,5L,3L,4L,3L,2L,2L,3L,6L,2L,1L,9L,2L,8L,6L,8L,7L,4L,2L,6L,1L,6L,9L,3L,1L,1L,3L,9L,0L,5L,4L,4L,8L,9L,0L,6L,4L,8L,3L,7L,2L,3L,6L,1L,7L,6L,9L,8L,0L,4L,7L,5L,8L,7L,8L,8L,8L,8L,5L,9L,7L,8L,1L,7L,4L,8L,4L,4L,9L,3L,1L,1L,7L,1L,3L,8L,0L,7L,2L,9L,2L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195708Inst : IEnumerable<long>
{
public static readonly long[] Value=A195708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195708.Bytes);
public long this[int i]=>Value[i];

public static A195708Inst Instance=new A195708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195709
{
public static readonly long[] Value={ 5L,6L,3L,9L,4L,2L,6L,4L,1L,3L,6L,0L,6L,2L,8L,8L,4L,2L,6L,9L,3L,8L,3L,1L,1L,7L,2L,1L,8L,3L,7L,4L,6L,8L,4L,7L,8L,5L,1L,8L,5L,9L,5L,3L,9L,3L,0L,4L,2L,5L,6L,7L,8L,3L,7L,5L,7L,2L,4L,2L,6L,6L,4L,2L,6L,6L,9L,2L,6L,2L,7L,9L,6L,5L,7L,8L,7L,4L,1L,2L,3L,6L,4L,0L,9L,2L,9L,4L,5L,7L,1L,8L,8L,3L,8L,4L,5L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195709Inst : IEnumerable<long>
{
public static readonly long[] Value=A195709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195709.Bytes);
public long this[int i]=>Value[i];

public static A195709Inst Instance=new A195709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195710
{
public static readonly long[] Value={ 2L,2L,5L,5L,5L,1L,5L,5L,2L,9L,7L,9L,7L,1L,7L,9L,5L,3L,3L,1L,1L,9L,4L,1L,9L,7L,6L,1L,3L,5L,0L,8L,1L,5L,4L,5L,8L,0L,2L,7L,8L,5L,8L,0L,0L,8L,8L,3L,0L,2L,1L,5L,1L,7L,2L,6L,0L,2L,5L,8L,2L,8L,2L,2L,5L,0L,3L,0L,5L,7L,6L,1L,7L,4L,0L,0L,2L,3L,0L,8L,2L,3L,7L,8L,3L,1L,0L,3L,6L,5L,3L,9L,6L,1L,3L,8L,7L,8L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195710Inst : IEnumerable<long>
{
public static readonly long[] Value=A195710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195710.Bytes);
public long this[int i]=>Value[i];

public static A195710Inst Instance=new A195710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195711
{
public static readonly long[] Value={ 2L,4L,8L,2L,5L,3L,4L,6L,1L,7L,7L,6L,3L,3L,8L,4L,2L,5L,5L,5L,8L,9L,8L,1L,1L,2L,5L,5L,9L,5L,6L,4L,8L,2L,6L,4L,9L,2L,7L,3L,9L,7L,3L,9L,1L,6L,0L,7L,9L,7L,4L,8L,4L,6L,2L,5L,4L,8L,1L,7L,0L,3L,3L,3L,6L,0L,1L,1L,4L,9L,8L,3L,4L,9L,5L,5L,1L,6L,7L,3L,6L,0L,1L,7L,6L,9L,0L,0L,4L,9L,0L,1L,2L,0L,5L,9L,5L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195711Inst : IEnumerable<long>
{
public static readonly long[] Value=A195711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195711.Bytes);
public long this[int i]=>Value[i];

public static A195711Inst Instance=new A195711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195712
{
public static readonly long[] Value={ 9L,1L,6L,8L,6L,8L,3L,8L,4L,2L,9L,4L,6L,7L,3L,2L,5L,2L,9L,1L,7L,1L,8L,2L,3L,9L,9L,1L,8L,8L,5L,0L,8L,8L,0L,6L,3L,0L,7L,1L,6L,4L,2L,9L,0L,0L,4L,9L,6L,3L,1L,3L,3L,0L,9L,0L,2L,4L,4L,0L,9L,0L,8L,2L,5L,4L,5L,9L,6L,8L,3L,1L,5L,9L,9L,3L,7L,8L,1L,9L,7L,1L,0L,6L,9L,9L,7L,5L,7L,8L,8L,4L,0L,2L,1L,0L,1L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195712Inst : IEnumerable<long>
{
public static readonly long[] Value=A195712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195712.Bytes);
public long this[int i]=>Value[i];

public static A195712Inst Instance=new A195712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195713
{
public static readonly long[] Value={ 6L,5L,3L,9L,2L,7L,9L,4L,2L,5L,0L,0L,2L,2L,3L,3L,6L,6L,3L,1L,4L,1L,3L,9L,2L,9L,2L,4L,5L,1L,2L,4L,2L,6L,3L,5L,7L,9L,1L,4L,2L,0L,4L,0L,9L,6L,3L,7L,9L,2L,1L,5L,7L,9L,5L,8L,5L,0L,3L,1L,3L,8L,7L,8L,9L,9L,3L,1L,1L,3L,7L,1L,5L,4L,3L,7L,2L,6L,3L,0L,2L,2L,0L,7L,0L,1L,9L,8L,3L,3L,8L,3L,0L,8L,4L,8L,3L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195713Inst : IEnumerable<long>
{
public static readonly long[] Value=A195713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195713.Bytes);
public long this[int i]=>Value[i];

public static A195713Inst Instance=new A195713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195714
{
public static readonly long[] Value={ 6L,7L,0L,8L,8L,7L,9L,7L,8L,7L,1L,2L,5L,1L,5L,2L,2L,9L,6L,5L,7L,6L,0L,4L,2L,3L,8L,1L,8L,7L,2L,2L,2L,3L,4L,8L,1L,2L,5L,9L,1L,7L,5L,4L,5L,7L,6L,9L,6L,0L,8L,5L,9L,6L,1L,0L,6L,6L,2L,7L,9L,1L,6L,4L,6L,2L,5L,0L,8L,9L,4L,1L,9L,9L,7L,2L,4L,7L,5L,2L,8L,6L,4L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195714Inst : IEnumerable<long>
{
public static readonly long[] Value=A195714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195714.Bytes);
public long this[int i]=>Value[i];

public static A195714Inst Instance=new A195714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195715
{
public static readonly long[] Value={ 2L,4L,8L,7L,6L,6L,4L,7L,1L,1L,0L,8L,9L,5L,6L,9L,8L,7L,2L,1L,4L,8L,5L,0L,4L,0L,9L,0L,8L,2L,8L,2L,6L,0L,2L,4L,8L,4L,0L,5L,7L,4L,8L,9L,8L,9L,7L,3L,7L,1L,8L,4L,2L,4L,1L,3L,8L,9L,9L,1L,3L,2L,0L,4L,4L,0L,8L,5L,0L,5L,0L,3L,4L,7L,4L,2L,4L,8L,2L,6L,9L,6L,4L,2L,1L,0L,1L,4L,9L,9L,1L,5L,1L,1L,2L,6L,8L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195715Inst : IEnumerable<long>
{
public static readonly long[] Value=A195715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195715.Bytes);
public long this[int i]=>Value[i];

public static A195715Inst Instance=new A195715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195716
{
public static readonly long[] Value={ 6L,8L,1L,5L,0L,2L,3L,8L,1L,6L,8L,1L,4L,1L,3L,5L,4L,0L,9L,5L,5L,8L,6L,3L,4L,3L,2L,1L,5L,8L,8L,9L,5L,0L,6L,0L,5L,5L,9L,3L,7L,4L,2L,4L,7L,2L,1L,8L,3L,3L,7L,6L,3L,7L,0L,2L,2L,7L,2L,2L,2L,5L,4L,1L,3L,2L,0L,7L,7L,2L,8L,3L,0L,1L,9L,7L,1L,4L,1L,3L,5L,6L,9L,4L,3L,5L,9L,7L,9L,7L,4L,9L,5L,0L,9L,0L,6L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195716Inst : IEnumerable<long>
{
public static readonly long[] Value=A195716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195716.Bytes);
public long this[int i]=>Value[i];

public static A195716Inst Instance=new A195716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195717
{
public static readonly long[] Value={ 8L,8L,9L,2L,9L,3L,9L,4L,5L,1L,1L,3L,4L,8L,3L,0L,7L,8L,2L,7L,5L,4L,5L,8L,2L,5L,9L,4L,8L,0L,8L,5L,6L,3L,8L,1L,5L,3L,9L,2L,1L,0L,4L,5L,2L,4L,6L,9L,2L,1L,5L,2L,7L,3L,4L,6L,4L,7L,5L,0L,0L,4L,2L,0L,2L,1L,8L,3L,0L,9L,2L,0L,1L,2L,3L,3L,9L,0L,3L,6L,3L,6L,1L,9L,6L,5L,7L,6L,1L,5L,1L,7L,5L,9L,6L,7L,8L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195717Inst : IEnumerable<long>
{
public static readonly long[] Value=A195717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195717.Bytes);
public long this[int i]=>Value[i];

public static A195717Inst Instance=new A195717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195718
{
public static readonly long[] Value={ 5L,6L,2L,1L,5L,8L,4L,8L,4L,3L,5L,7L,2L,2L,1L,9L,0L,1L,5L,2L,2L,5L,2L,0L,2L,3L,4L,4L,3L,5L,0L,8L,2L,0L,6L,6L,5L,3L,4L,6L,6L,7L,0L,5L,8L,3L,9L,7L,5L,8L,6L,6L,5L,0L,6L,7L,0L,4L,3L,0L,8L,6L,8L,6L,9L,2L,1L,2L,0L,4L,6L,8L,3L,7L,2L,4L,9L,8L,3L,8L,2L,0L,0L,4L,5L,3L,2L,1L,2L,5L,5L,6L,1L,5L,7L,8L,4L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195718Inst : IEnumerable<long>
{
public static readonly long[] Value=A195718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195718.Bytes);
public long this[int i]=>Value[i];

public static A195718Inst Instance=new A195718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195719
{
public static readonly long[] Value={ 2L,2L,5L,2L,2L,9L,8L,7L,0L,8L,4L,7L,6L,3L,1L,0L,1L,6L,0L,1L,8L,7L,1L,8L,5L,1L,2L,3L,7L,9L,8L,6L,4L,6L,5L,0L,2L,6L,5L,7L,9L,5L,8L,9L,4L,6L,9L,0L,5L,8L,9L,0L,5L,4L,7L,5L,1L,0L,1L,9L,4L,5L,5L,0L,2L,8L,5L,9L,8L,5L,4L,8L,6L,1L,6L,2L,8L,1L,8L,6L,3L,5L,0L,0L,8L,3L,7L,7L,2L,1L,0L,1L,6L,6L,1L,4L,9L,1L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195719Inst : IEnumerable<long>
{
public static readonly long[] Value=A195719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195719.Bytes);
public long this[int i]=>Value[i];

public static A195719Inst Instance=new A195719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195720
{
public static readonly long[] Value={ 1L,1L,5L,0L,2L,6L,1L,9L,9L,1L,5L,1L,0L,9L,3L,1L,4L,9L,1L,3L,4L,3L,0L,5L,9L,1L,7L,5L,7L,2L,6L,5L,3L,6L,0L,6L,8L,7L,4L,7L,5L,4L,5L,3L,0L,6L,8L,6L,7L,6L,3L,3L,3L,0L,0L,5L,9L,8L,2L,1L,0L,8L,9L,3L,8L,0L,7L,8L,6L,3L,5L,5L,1L,4L,0L,4L,9L,3L,5L,8L,1L,9L,0L,5L,4L,7L,5L,0L,4L,1L,0L,2L,4L,5L,2L,6L,6L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195720Inst : IEnumerable<long>
{
public static readonly long[] Value=A195720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195720.Bytes);
public long this[int i]=>Value[i];

public static A195720Inst Instance=new A195720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195721
{
public static readonly long[] Value={ 3L,8L,7L,5L,9L,6L,6L,8L,6L,6L,5L,5L,1L,8L,0L,6L,5L,3L,6L,0L,2L,0L,4L,6L,8L,5L,5L,5L,9L,1L,2L,3L,6L,7L,1L,2L,8L,9L,9L,9L,0L,8L,7L,1L,7L,0L,1L,1L,5L,0L,1L,2L,5L,7L,9L,6L,4L,0L,8L,2L,2L,3L,0L,7L,8L,8L,0L,5L,8L,8L,3L,8L,7L,5L,1L,0L,3L,9L,3L,9L,9L,6L,4L,9L,9L,0L,3L,2L,7L,9L,8L,9L,2L,7L,6L,4L,6L,0L,4L,4L,9L,8L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195721Inst : IEnumerable<long>
{
public static readonly long[] Value=A195721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195721.Bytes);
public long this[int i]=>Value[i];

public static A195721Inst Instance=new A195721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195722
{
public static readonly long[] Value={ 1L,9L,9L,1L,3L,3L,0L,6L,6L,2L,0L,7L,8L,8L,6L,1L,7L,4L,7L,1L,1L,9L,5L,8L,4L,2L,0L,7L,5L,5L,2L,9L,6L,6L,8L,1L,5L,4L,4L,9L,6L,2L,4L,0L,9L,2L,5L,0L,7L,4L,7L,2L,5L,2L,0L,3L,7L,6L,7L,3L,3L,6L,9L,8L,4L,9L,9L,9L,5L,2L,8L,5L,4L,8L,8L,1L,2L,7L,3L,1L,7L,9L,5L,7L,3L,2L,8L,4L,4L,1L,5L,0L,9L,6L,8L,5L,1L,0L,5L,0L,8L,8L,2L,5L,6L,3L,3L,8L,5L,8L,7L,4L,6L,5L,6L,4L,1L,1L,3L,4L,8L,7L,5L,8L,7L,0L,0L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195722Inst : IEnumerable<long>
{
public static readonly long[] Value=A195722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195722.Bytes);
public long this[int i]=>Value[i];

public static A195722Inst Instance=new A195722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195723
{
public static readonly long[] Value={ 1L,0L,1L,7L,2L,2L,1L,9L,6L,7L,8L,9L,7L,8L,5L,1L,3L,6L,7L,7L,2L,2L,7L,8L,8L,9L,6L,1L,5L,5L,0L,4L,8L,2L,9L,2L,2L,0L,6L,3L,5L,6L,0L,8L,7L,6L,9L,8L,6L,8L,3L,6L,5L,8L,7L,1L,4L,9L,2L,0L,2L,6L,9L,2L,4L,3L,7L,0L,5L,3L,0L,3L,3L,6L,5L,4L,4L,2L,3L,1L,0L,2L,3L,0L,7L,3L,0L,8L,8L,4L,8L,3L,2L,7L,9L,7L,3L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195723Inst : IEnumerable<long>
{
public static readonly long[] Value=A195723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195723.Bytes);
public long this[int i]=>Value[i];

public static A195723Inst Instance=new A195723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195724
{
public static readonly long[] Value={ 1L,2L,8L,9L,7L,6L,1L,4L,2L,5L,2L,9L,2L,0L,8L,3L,0L,2L,1L,5L,1L,1L,3L,0L,6L,7L,4L,1L,2L,7L,7L,4L,8L,2L,8L,9L,8L,5L,7L,5L,4L,6L,7L,1L,9L,7L,0L,8L,8L,3L,9L,9L,6L,9L,3L,0L,1L,1L,9L,8L,0L,2L,2L,1L,5L,1L,1L,4L,6L,1L,1L,3L,4L,1L,8L,3L,7L,3L,2L,7L,2L,5L,2L,1L,4L,0L,1L,8L,0L,1L,8L,6L,0L,5L,3L,5L,3L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195724Inst : IEnumerable<long>
{
public static readonly long[] Value=A195724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195724.Bytes);
public long this[int i]=>Value[i];

public static A195724Inst Instance=new A195724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195725
{
public static readonly long[] Value={ 7L,3L,9L,8L,8L,0L,7L,7L,4L,3L,7L,8L,7L,4L,0L,7L,6L,6L,8L,7L,3L,1L,8L,1L,0L,8L,3L,4L,3L,4L,8L,2L,0L,3L,7L,4L,1L,0L,2L,4L,0L,2L,5L,9L,5L,6L,5L,9L,6L,4L,5L,2L,1L,4L,0L,9L,0L,9L,6L,6L,7L,3L,1L,1L,6L,7L,2L,0L,9L,1L,3L,4L,4L,1L,4L,5L,7L,5L,7L,2L,8L,6L,3L,8L,2L,7L,4L,2L,9L,0L,4L,0L,8L,9L,0L,4L,6L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195725Inst : IEnumerable<long>
{
public static readonly long[] Value=A195725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195725.Bytes);
public long this[int i]=>Value[i];

public static A195725Inst Instance=new A195725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195726
{
public static readonly long[] Value={ 2L,7L,2L,1L,0L,5L,8L,3L,1L,8L,3L,0L,5L,8L,2L,8L,1L,1L,0L,5L,7L,4L,3L,8L,0L,8L,6L,7L,3L,6L,6L,2L,8L,7L,5L,1L,0L,8L,4L,6L,1L,3L,0L,0L,0L,6L,5L,5L,5L,1L,8L,6L,2L,1L,1L,0L,8L,5L,6L,8L,3L,1L,8L,9L,9L,6L,1L,7L,7L,1L,7L,5L,4L,5L,4L,8L,0L,4L,0L,3L,1L,8L,3L,6L,8L,7L,6L,7L,8L,2L,2L,9L,1L,6L,3L,2L,4L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195726Inst : IEnumerable<long>
{
public static readonly long[] Value=A195726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195726.Bytes);
public long this[int i]=>Value[i];

public static A195726Inst Instance=new A195726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195727
{
public static readonly long[] Value={ 2L,4L,4L,9L,7L,8L,6L,6L,3L,1L,2L,6L,8L,6L,4L,1L,5L,4L,1L,7L,2L,0L,8L,2L,4L,8L,1L,2L,1L,1L,2L,7L,5L,8L,1L,0L,9L,1L,4L,1L,4L,4L,0L,9L,8L,3L,8L,1L,1L,8L,4L,0L,6L,7L,1L,2L,7L,3L,7L,5L,9L,1L,4L,6L,6L,7L,3L,5L,5L,1L,1L,9L,5L,8L,7L,6L,4L,2L,0L,9L,6L,5L,7L,4L,5L,3L,4L,1L,5L,7L,6L,6L,8L,7L,0L,1L,9L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195727Inst : IEnumerable<long>
{
public static readonly long[] Value=A195727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195727.Bytes);
public long this[int i]=>Value[i];

public static A195727Inst Instance=new A195727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195728
{
public static readonly long[] Value={ 1L,1L,8L,3L,1L,9L,9L,6L,4L,0L,1L,3L,9L,7L,1L,5L,9L,6L,5L,6L,2L,9L,2L,7L,4L,8L,3L,6L,0L,4L,8L,5L,1L,4L,7L,2L,9L,1L,9L,8L,6L,7L,5L,9L,8L,2L,6L,7L,6L,0L,5L,1L,6L,5L,2L,5L,2L,3L,3L,9L,0L,0L,6L,5L,3L,6L,5L,8L,4L,9L,3L,6L,4L,3L,9L,2L,0L,6L,5L,0L,9L,9L,6L,6L,4L,1L,1L,4L,1L,3L,2L,7L,7L,8L,2L,9L,3L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195728Inst : IEnumerable<long>
{
public static readonly long[] Value=A195728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195728.Bytes);
public long this[int i]=>Value[i];

public static A195728Inst Instance=new A195728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195729
{
public static readonly long[] Value={ 1L,2L,4L,9L,0L,4L,5L,7L,7L,2L,3L,9L,8L,2L,5L,4L,4L,2L,5L,8L,2L,9L,9L,1L,7L,0L,7L,7L,2L,8L,1L,0L,9L,0L,1L,2L,3L,0L,7L,7L,8L,2L,9L,4L,0L,4L,1L,2L,9L,8L,9L,6L,7L,1L,9L,0L,5L,4L,6L,6L,9L,2L,3L,6L,7L,9L,7L,1L,5L,1L,9L,6L,5L,7L,3L,7L,2L,9L,3L,9L,5L,4L,9L,5L,7L,6L,0L,8L,9L,9L,0L,3L,2L,0L,4L,1L,7L,1L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195729Inst : IEnumerable<long>
{
public static readonly long[] Value=A195729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195729.Bytes);
public long this[int i]=>Value[i];

public static A195729Inst Instance=new A195729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195730
{
public static readonly long[] Value={ 1L,2L,6L,4L,5L,1L,8L,9L,5L,7L,6L,2L,5L,2L,2L,7L,1L,6L,3L,1L,4L,9L,0L,8L,3L,4L,7L,2L,0L,0L,7L,0L,1L,2L,2L,0L,3L,5L,8L,6L,0L,4L,8L,7L,1L,2L,0L,1L,1L,0L,0L,9L,3L,6L,4L,4L,5L,4L,2L,1L,1L,8L,4L,2L,4L,5L,7L,9L,1L,8L,6L,0L,1L,7L,8L,6L,4L,0L,2L,7L,2L,8L,0L,5L,1L,6L,7L,2L,8L,1L,9L,0L,5L,1L,2L,1L,7L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195730Inst : IEnumerable<long>
{
public static readonly long[] Value=A195730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195730.Bytes);
public long this[int i]=>Value[i];

public static A195730Inst Instance=new A195730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195731
{
public static readonly long[] Value={ 1L,3L,1L,8L,1L,1L,6L,0L,7L,1L,6L,5L,2L,8L,1L,7L,9L,6L,5L,7L,4L,5L,6L,6L,4L,2L,5L,4L,6L,4L,6L,0L,4L,0L,4L,6L,9L,8L,4L,6L,3L,9L,0L,9L,6L,6L,5L,9L,0L,7L,1L,4L,7L,1L,6L,8L,5L,3L,5L,4L,8L,5L,1L,7L,4L,1L,3L,3L,3L,3L,1L,4L,2L,6L,6L,2L,0L,8L,3L,2L,7L,6L,9L,0L,2L,2L,6L,8L,6L,7L,0L,4L,4L,3L,0L,4L,3L,9L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195731Inst : IEnumerable<long>
{
public static readonly long[] Value=A195731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195731.Bytes);
public long this[int i]=>Value[i];

public static A195731Inst Instance=new A195731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195732
{
public static readonly long[] Value={ 1L,2L,3L,11L,30L,62L,534L,620L,803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195732Inst : IEnumerable<long>
{
public static readonly long[] Value=A195732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195732.Bytes);
public long this[int i]=>Value[i];

public static A195732Inst Instance=new A195732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195733
{
public static readonly long[] Value={ 1L,2L,4L,12L,36L,144L,288L,1440L,3840L,9216L,120384L,700416L,5455872L,65015808L,188018688L,439805952L,1098528768L,31016134656L,324642484224L,12673570111488L,75959807901696L,1301903865544704L,2870722110554112L,32326598156353536L,193916357676367872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195733Inst : IEnumerable<long>
{
public static readonly long[] Value=A195733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195733.Bytes);
public long this[int i]=>Value[i];

public static A195733Inst Instance=new A195733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195734
{
public static readonly long[] Value={ 1L,1L,3L,6L,11L,22L,40L,72L,123L,215L,363L,605L,991L,1618L,2598L,4139L,6537L,10229L,15871L,24476L,37487L,56995L,86177L,129531L,193662L,287992L,426254L,627841L,920708L,1344331L,1954987L,2831688L,4086168L,5875087L,8417724L,12020250L,17108958L,24275947L,34340966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195734Inst : IEnumerable<long>
{
public static readonly long[] Value=A195734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195734.Bytes);
public long this[int i]=>Value[i];

public static A195734Inst Instance=new A195734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195735
{
public static readonly long[] Value={ 1L,5L,10L,13L,26L,38L,50L,29L,73L,110L,122L,22L,170L,222L,230L,61L,290L,173L,362L,158L,458L,566L,530L,-298L,601L,798L,586L,398L,842L,458L,962L,125L,1154L,1382L,1230L,-779L,1370L,1734L,1622L,-226L,1682L,1158L,1850L,1190L,1418L,2558L,2210L,-2090L,2353L,2285L,2798L,1742L,2810L,902L,3062L,78L,3506L,4094L,3482L,-3238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195735Inst : IEnumerable<long>
{
public static readonly long[] Value=A195735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195735.Bytes);
public long this[int i]=>Value[i];

public static A195735Inst Instance=new A195735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195736
{
public static readonly BigInteger[] Value={ 1L,2L,21L,568L,29705L,2573136L,335201293L,61480323584L,15135660248913L,4823681315219200L,1934425407465004421L,BigInteger.Parse("954153609788873382912"),BigInteger.Parse("568125617688093236137561"),BigInteger.Parse("402006917909739659429470208"),BigInteger.Parse("333597313002114320208678928125") };
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
public class A195736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195736.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195736Inst Instance=new A195736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195737
{
public static readonly BigInteger[] Value={ 1L,2L,15L,256L,7935L,392526L,28498246L,2863702080L,381411964485L,65129544696250L,13888321460879976L,3620285828450155008L,BigInteger.Parse("1133432920326577483795"),BigInteger.Parse("419923892646668363653350"),BigInteger.Parse("181795302703808044653240000"),BigInteger.Parse("90971411268941227901619966976") };
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
public class A195737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195737Inst Instance=new A195737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195738
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,6L,3L,0L,1L,17L,17L,4L,0L,1L,59L,131L,52L,7L,0L,1L,195L,915L,709L,153L,13L,0L,1L,703L,6553L,8946L,3350L,454L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195738Inst : IEnumerable<long>
{
public static readonly long[] Value=A195738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195738.Bytes);
public long this[int i]=>Value[i];

public static A195738Inst Instance=new A195738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195739
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,4L,0L,1L,17L,32L,0L,1L,61L,348L,400L,0L,1L,214L,2836L,8640L,6912L,0L,1L,758L,21225L,129288L,254800L,153664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195739Inst : IEnumerable<long>
{
public static readonly long[] Value=A195739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195739.Bytes);
public long this[int i]=>Value[i];

public static A195739Inst Instance=new A195739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195740
{
public static readonly long[] Value={ 29L,1247L,261L,89972L,5511L,608992L,58631L,418808411L,312221L,278668008656L,6651971L,1886445877264L,70864611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195740Inst : IEnumerable<long>
{
public static readonly long[] Value=A195740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195740.Bytes);
public long this[int i]=>Value[i];

public static A195740Inst Instance=new A195740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195741
{
public static readonly long[] Value={ 0L,0L,1L,6L,17L,59L,195L,703L,2499L,9188L,33890L,126758L,476269L,1802311L,6849776L,26152417L,100203193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195741Inst : IEnumerable<long>
{
public static readonly long[] Value=A195741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195741.Bytes);
public long this[int i]=>Value[i];

public static A195741Inst Instance=new A195741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195742
{
public static readonly long[] Value={ 2L,200L,1L,300L,10L,400L,2L,200L,1L,1L,30L,5L,10L,600L,1L,400L,5L,300L,40L,10L,600L,6L,1L,400L,5L,1L,200L,900L,6L,5L,1L,200L,900L,5L,10L,400L,5L,400L,5L,6L,6L,2L,5L,6L,6L,8L,300L,500L,70L,30L,80L,50L,10L,400L,5L,6L,600L,6L,200L,6L,8L,1L,30L,5L,10L,600L,40L,200L,8L,80L,400L,70L,30L,80L,50L,10L,5L,40L,10L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195742Inst : IEnumerable<long>
{
public static readonly long[] Value=A195742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195742.Bytes);
public long this[int i]=>Value[i];

public static A195742Inst Instance=new A195742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195743
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,2L,3L,3L,5L,3L,6L,5L,6L,2L,7L,3L,8L,3L,5L,6L,9L,3L,5L,7L,3L,5L,10L,5L,11L,2L,11L,8L,11L,3L,12L,11L,8L,3L,13L,4L,14L,7L,10L,11L,15L,3L,7L,4L,15L,5L,16L,3L,9L,5L,11L,13L,17L,4L,18L,16L,6L,2L,18L,8L,19L,6L,19L,9L,20L,3L,21L,17L,10L,11L,21L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195743Inst : IEnumerable<long>
{
public static readonly long[] Value=A195743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195743.Bytes);
public long this[int i]=>Value[i];

public static A195743Inst Instance=new A195743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195744
{
public static readonly long[] Value={ 31L,61L,121L,241L,481L,961L,1921L,3841L,7681L,15361L,30721L,61441L,122881L,245761L,491521L,983041L,1966081L,3932161L,7864321L,15728641L,31457281L,62914561L,125829121L,251658241L,503316481L,1006632961L,2013265921L,4026531841L,8053063681L,16106127361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195744Inst : IEnumerable<long>
{
public static readonly long[] Value=A195744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195744.Bytes);
public long this[int i]=>Value[i];

public static A195744Inst Instance=new A195744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195745
{
public static readonly BigInteger[] Value={ 31L,61L,241L,7681L,15361L,61441L,2013265921L,2061584302081L,4123168604161L,263882790666241L,4222124650659841L,BigInteger.Parse("4533471823554859405148161"),BigInteger.Parse("77884452878022414427957444938301441"),BigInteger.Parse("5612166287350667205902149757630526795478780965027841") };
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
public class A195745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195745Inst Instance=new A195745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195746
{
public static readonly long[] Value={ 3L,4L,8L,12L,19L,42L,98L,154L,107L,572L,932L,2132L,539L,3825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195746Inst : IEnumerable<long>
{
public static readonly long[] Value=A195746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195746.Bytes);
public long this[int i]=>Value[i];

public static A195746Inst Instance=new A195746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195747
{
public static readonly long[] Value={ 4L,5L,14L,11L,63L,27L,298L,69L,1221L,179L,6819L,467L,21893L,1221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195747Inst : IEnumerable<long>
{
public static readonly long[] Value=A195747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195747.Bytes);
public long this[int i]=>Value[i];

public static A195747Inst Instance=new A195747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195748
{
public static readonly long[] Value={ 12L,11L,50L,37L,1245L,1159L,39608L,7275L,52541L,75291L,1212200L,607435L,181087528L,1225261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195748Inst : IEnumerable<long>
{
public static readonly long[] Value=A195748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195748.Bytes);
public long this[int i]=>Value[i];

public static A195748Inst Instance=new A195748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195749
{
public static readonly long[] Value={ 19L,63L,2816L,1245L,143L,70668L,74283746L,622677L,34716123L,4522574L,82212839L,1010388604L,34860663827L,2227981245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195749Inst : IEnumerable<long>
{
public static readonly long[] Value=A195749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195749.Bytes);
public long this[int i]=>Value[i];

public static A195749Inst Instance=new A195749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195750
{
public static readonly long[] Value={ 42L,27L,1632L,1159L,70668L,3853L,4667448L,216143L,14658527L,40619575L,14072629988L,115245795L,21481359503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195750Inst : IEnumerable<long>
{
public static readonly long[] Value=A195750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195750.Bytes);
public long this[int i]=>Value[i];

public static A195750Inst Instance=new A195750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195751
{
public static readonly long[] Value={ 98L,298L,15004L,39608L,74283746L,4667448L,471247L,31057338L,79885513801295L,58727863626L,1157365463811298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195751Inst : IEnumerable<long>
{
public static readonly long[] Value=A195751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195751.Bytes);
public long this[int i]=>Value[i];

public static A195751Inst Instance=new A195751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195752
{
public static readonly long[] Value={ 4L,8L,8L,26L,19L,94L,98L,348L,107L,1296L,934L,4834L,539L,18038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195752Inst : IEnumerable<long>
{
public static readonly long[] Value=A195752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195752.Bytes);
public long this[int i]=>Value[i];

public static A195752Inst Instance=new A195752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195753
{
public static readonly long[] Value={ 8L,30L,74L,269L,356L,3309L,11178L,10351L,28028L,519141L,56511L,6511653L,4798118L,3319643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195753Inst : IEnumerable<long>
{
public static readonly long[] Value=A195753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195753.Bytes);
public long this[int i]=>Value[i];

public static A195753Inst Instance=new A195753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195754
{
public static readonly long[] Value={ 8L,74L,62L,960L,2816L,118668L,15004L,3399408L,223244L,20464714L,851928L,1659128426L,136296090L,2866207958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195754Inst : IEnumerable<long>
{
public static readonly long[] Value=A195754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195754.Bytes);
public long this[int i]=>Value[i];

public static A195754Inst Instance=new A195754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195755
{
public static readonly long[] Value={ 26L,269L,960L,417L,5502L,4276501L,50446504L,92694437L,42601245L,74269856053L,3914071518L,78122151013L,981143881088L,176981282511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195755Inst : IEnumerable<long>
{
public static readonly long[] Value=A195755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195755.Bytes);
public long this[int i]=>Value[i];

public static A195755Inst Instance=new A195755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195756
{
public static readonly long[] Value={ 19L,3516L,2816L,5502L,6085L,989568L,74283746L,547462302L,34716123L,19876549906L,82212839L,75644545049024L,34860663827L,126494851419642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195756Inst : IEnumerable<long>
{
public static readonly long[] Value=A195756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195756.Bytes);
public long this[int i]=>Value[i];

public static A195756Inst Instance=new A195756Inst();

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