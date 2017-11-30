using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A106841
{
public static readonly long[] Value={ 8L,16L,32L,40L,64L,72L,80L,104L,128L,136L,144L,160L,168L,200L,208L,232L,256L,264L,272L,288L,296L,320L,328L,336L,360L,392L,400L,416L,424L,456L,464L,488L,512L,520L,528L,544L,552L,576L,584L,592L,616L,640L,648L,656L,672L,680L,712L,720L,744L,776L,784L,800L,808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106841Inst : IEnumerable<long>
{
public static readonly long[] Value=A106841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106841.Bytes);
public long this[int i]=>Value[i];

public static A106841Inst Instance=new A106841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106842
{
public static readonly BigInteger[] Value={ 1L,3L,49L,2197L,194481L,28629151L,6321363049L,1954897493193L,806460091894081L,427929800129788411L,BigInteger.Parse("283942098606901565601"),BigInteger.Parse("230339304218442143770717"),BigInteger.Parse("224282727500720205065439601"),BigInteger.Parse("258145266804692077858261512663") };
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
public class A106842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106842Inst Instance=new A106842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106843
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,9L,11L,13L,15L,17L,18L,19L,21L,23L,27L,29L,31L,33L,37L,39L,41L,43L,45L,47L,51L,53L,54L,57L,59L,61L,63L,67L,69L,71L,73L,79L,81L,83L,87L,89L,93L,97L,99L,101L,103L,107L,109L,111L,113L,117L,123L,127L,129L,131L,135L,137L,139L,141L,149L,151L,153L,157L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106843Inst : IEnumerable<long>
{
public static readonly long[] Value=A106843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106843.Bytes);
public long this[int i]=>Value[i];

public static A106843Inst Instance=new A106843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106844
{
public static readonly long[] Value={ 0L,2L,0L,1L,0L,3L,1L,0L,2L,0L,1L,4L,0L,0L,2L,1L,0L,3L,1L,2L,0L,0L,5L,1L,0L,1L,3L,0L,0L,2L,1L,0L,4L,2L,0L,3L,1L,0L,0L,1L,6L,0L,2L,0L,0L,1L,2L,0L,4L,1L,0L,1L,3L,0L,2L,1L,5L,0L,0L,0L,3L,1L,0L,0L,4L,0L,2L,1L,1L,2L,0L,7L,0L,1L,3L,0L,0L,1L,1L,2L,0L,0L,3L,0L,1L,5L,0L,2L,1L,0L,2L,0L,4L,1L,0L,0L,3L,2L,0L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106844Inst : IEnumerable<long>
{
public static readonly long[] Value=A106844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106844.Bytes);
public long this[int i]=>Value[i];

public static A106844Inst Instance=new A106844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106845
{
public static readonly long[] Value={ 0L,1L,14L,72L,244L,650L,1476L,2989L,5552L,9639L,15850L,24926L,37764L,55432L,79184L,110475L,150976L,202589L,267462L,348004L,446900L,567126L,711964L,885017L,1090224L,1331875L,1614626L,1943514L,2323972L,2761844L,3263400L,3835351L,4484864L,5219577L,6047614L,6977600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106845Inst : IEnumerable<long>
{
public static readonly long[] Value=A106845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106845.Bytes);
public long this[int i]=>Value[i];

public static A106845Inst Instance=new A106845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106846
{
public static readonly long[] Value={ 0L,4L,22L,64L,144L,269L,461L,720L,1072L,1522L,2092L,2774L,3626L,4614L,5776L,7126L,8694L,10445L,12461L,14684L,17204L,19997L,23077L,26412L,30156L,34206L,38600L,43352L,48532L,54042L,60072L,66458L,73338L,80664L,88450L,96710L,105638L,114999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106846Inst : IEnumerable<long>
{
public static readonly long[] Value=A106846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106846.Bytes);
public long this[int i]=>Value[i];

public static A106846Inst Instance=new A106846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106847
{
public static readonly long[] Value={ 0L,0L,2L,11L,31L,71L,131L,229L,357L,537L,767L,1064L,1412L,1867L,2385L,3000L,3720L,4570L,5506L,6608L,7808L,9194L,10734L,12436L,14260L,16360L,18622L,21079L,23739L,26668L,29758L,33199L,36815L,40742L,44924L,49369L,54085L,59265L,64661L,70355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106847Inst : IEnumerable<long>
{
public static readonly long[] Value=A106847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106847.Bytes);
public long this[int i]=>Value[i];

public static A106847Inst Instance=new A106847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106848
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,6L,6L,3L,0L,16L,9L,18L,1L,6L,2L,22L,0L,0L,6L,27L,6L,28L,1L,15L,0L,2L,16L,6L,0L,3L,18L,6L,1L,5L,6L,21L,2L,9L,22L,46L,0L,42L,1L,48L,0L,13L,27L,2L,0L,18L,28L,58L,1L,60L,15L,6L,0L,6L,2L,33L,16L,22L,1L,35L,0L,8L,3L,0L,0L,2L,6L,13L,1L,81L,5L,41L,6L,16L,21L,84L,2L,44L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106848Inst : IEnumerable<long>
{
public static readonly long[] Value=A106848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106848.Bytes);
public long this[int i]=>Value[i];

public static A106848Inst Instance=new A106848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106849
{
public static readonly long[] Value={ 2L,17L,19L,23L,29L,47L,59L,61L,97L,109L,113L,131L,149L,167L,179L,181L,193L,223L,229L,233L,257L,263L,269L,313L,337L,367L,379L,383L,389L,419L,433L,461L,487L,491L,499L,503L,509L,541L,571L,577L,593L,619L,647L,659L,701L,709L,727L,743L,811L,821L,823L,857L,863L,887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106849Inst : IEnumerable<long>
{
public static readonly long[] Value=A106849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106849.Bytes);
public long this[int i]=>Value[i];

public static A106849Inst Instance=new A106849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106850
{
public static readonly long[] Value={ 0L,6L,33L,174L,915L,4854L,25962L,139836L,757545L,4123236L,22527393L,123451554L,678148620L,3732306474L,20572095777L,113524359906L,627044542215L,3465927182766L,19168307134278L,106056611012784L,587001832650825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106850Inst : IEnumerable<long>
{
public static readonly long[] Value=A106850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106850.Bytes);
public long this[int i]=>Value[i];

public static A106850Inst Instance=new A106850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106851
{
public static readonly long[] Value={ 0L,2L,9L,37L,152L,626L,2585L,10701L,44400L,184610L,769065L,3209461L,13415048L,56153618L,235357241L,987609501L,4148575200L,17443003202L,73402179657L,309116995525L,1302649664888L,5492768393906L,23173154692697L,97810060234605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106851Inst : IEnumerable<long>
{
public static readonly long[] Value=A106851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106851.Bytes);
public long this[int i]=>Value[i];

public static A106851Inst Instance=new A106851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106852
{
public static readonly long[] Value={ 1L,1L,-2L,-5L,1L,16L,13L,-35L,-74L,31L,253L,160L,-599L,-1079L,718L,3955L,1801L,-10064L,-15467L,14725L,61126L,16951L,-166427L,-217280L,282001L,933841L,87838L,-2713685L,-2977199L,5163856L,14095453L,-1396115L,-43682474L,-39494129L,91553293L,210035680L,-64624199L,-694731239L,-500858642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106852Inst : IEnumerable<long>
{
public static readonly long[] Value=A106852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106852.Bytes);
public long this[int i]=>Value[i];

public static A106852Inst Instance=new A106852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106853
{
public static readonly long[] Value={ 1L,1L,-3L,-7L,5L,33L,13L,-119L,-171L,305L,989L,-231L,-4187L,-3263L,13485L,26537L,-27403L,-133551L,-23939L,510265L,606021L,-1435039L,-3859123L,1881033L,17317525L,9793393L,-59476707L,-98650279L,139256549L,533857665L,-23168531L,-2158599191L,-2065925067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106853Inst : IEnumerable<long>
{
public static readonly long[] Value=A106853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106853.Bytes);
public long this[int i]=>Value[i];

public static A106853Inst Instance=new A106853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106854
{
public static readonly long[] Value={ 1L,1L,-4L,-9L,11L,56L,1L,-279L,-284L,1111L,2531L,-3024L,-15679L,-559L,77836L,80631L,-308549L,-711704L,831041L,4389561L,234356L,-21713449L,-22885229L,85682016L,200108161L,-228301919L,-1228842724L,-87333129L,6056880491L,6493546136L,-23790856319L,-56258586999L,62695694596L,343988629591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106854Inst : IEnumerable<long>
{
public static readonly long[] Value=A106854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106854.Bytes);
public long this[int i]=>Value[i];

public static A106854Inst Instance=new A106854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106855
{
public static readonly long[] Value={ 1L,0L,1L,-3L,1L,-6L,10L,-9L,28L,-39L,55L,-123L,172L,-288L,541L,-804L,1405L,-2427L,3817L,-6642L,11098L,-18093L,31024L,-51387L,85303L,-144459L,239464L,-400368L,672841L,-1118760L,1873945L,-3137283L,5230225L,-8759118L,14642074L,-24449793L,40919428L,-68376015L,114268807L,-191134299L,319396852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106855Inst : IEnumerable<long>
{
public static readonly long[] Value=A106855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106855.Bytes);
public long this[int i]=>Value[i];

public static A106855Inst Instance=new A106855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106856
{
public static readonly long[] Value={ 2L,11L,23L,37L,43L,53L,71L,79L,107L,109L,127L,137L,149L,151L,163L,193L,197L,211L,233L,239L,263L,281L,317L,331L,337L,373L,389L,401L,421L,431L,443L,463L,487L,491L,499L,541L,547L,557L,569L,599L,613L,617L,641L,653L,659L,673L,683L,739L,743L,751L,757L,809L,821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106856Inst : IEnumerable<long>
{
public static readonly long[] Value=A106856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106856.Bytes);
public long this[int i]=>Value[i];

public static A106856Inst Instance=new A106856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106857
{
public static readonly long[] Value={ 3L,5L,23L,31L,37L,47L,53L,59L,67L,89L,97L,113L,157L,163L,179L,181L,191L,199L,251L,257L,269L,311L,313L,317L,331L,367L,379L,383L,389L,401L,419L,433L,443L,449L,463L,487L,499L,509L,521L,577L,587L,599L,617L,641L,643L,647L,653L,683L,691L,709L,719L,727L,751L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106857Inst : IEnumerable<long>
{
public static readonly long[] Value=A106857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106857.Bytes);
public long this[int i]=>Value[i];

public static A106857Inst Instance=new A106857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106858
{
public static readonly long[] Value={ 2L,5L,23L,83L,107L,137L,173L,257L,293L,347L,353L,467L,503L,617L,647L,653L,743L,797L,857L,953L,983L,1223L,1277L,1283L,1307L,1427L,1487L,1493L,1523L,1553L,1637L,1787L,1877L,1913L,1997L,2003L,2027L,2213L,2237L,2243L,2393L,2423L,2447L,2657L,2663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106858Inst : IEnumerable<long>
{
public static readonly long[] Value=A106858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106858.Bytes);
public long this[int i]=>Value[i];

public static A106858Inst Instance=new A106858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106859
{
public static readonly long[] Value={ 2L,3L,5L,17L,23L,47L,53L,83L,107L,113L,137L,167L,173L,197L,227L,233L,257L,263L,293L,317L,347L,353L,383L,443L,467L,503L,557L,563L,587L,593L,617L,647L,653L,677L,683L,743L,773L,797L,827L,857L,863L,887L,947L,953L,977L,983L,1013L,1097L,1103L,1163L,1187L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106859Inst : IEnumerable<long>
{
public static readonly long[] Value=A106859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106859.Bytes);
public long this[int i]=>Value[i];

public static A106859Inst Instance=new A106859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106860
{
public static readonly long[] Value={ 2L,3L,17L,47L,53L,113L,167L,197L,227L,233L,263L,317L,383L,443L,557L,563L,587L,593L,677L,683L,773L,827L,863L,887L,947L,977L,1013L,1097L,1103L,1163L,1187L,1193L,1217L,1367L,1373L,1433L,1583L,1607L,1613L,1667L,1697L,1733L,1823L,1847L,1907L,1973L,2063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106860Inst : IEnumerable<long>
{
public static readonly long[] Value=A106860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106860.Bytes);
public long this[int i]=>Value[i];

public static A106860Inst Instance=new A106860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106861
{
public static readonly long[] Value={ 19L,31L,79L,109L,151L,181L,199L,211L,229L,271L,331L,349L,409L,421L,439L,499L,571L,601L,619L,631L,661L,691L,709L,769L,811L,829L,859L,919L,991L,1021L,1039L,1051L,1069L,1129L,1171L,1201L,1249L,1291L,1321L,1381L,1399L,1429L,1459L,1471L,1489L,1531L,1579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106861Inst : IEnumerable<long>
{
public static readonly long[] Value=A106861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106861.Bytes);
public long this[int i]=>Value[i];

public static A106861Inst Instance=new A106861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106862
{
public static readonly long[] Value={ 5L,7L,11L,17L,23L,47L,61L,73L,83L,101L,131L,137L,139L,149L,157L,163L,191L,197L,199L,229L,251L,263L,271L,277L,283L,311L,347L,349L,353L,359L,367L,389L,419L,443L,457L,461L,463L,467L,499L,503L,541L,557L,571L,593L,613L,617L,619L,631L,643L,647L,653L,691L,701L,719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106862Inst : IEnumerable<long>
{
public static readonly long[] Value=A106862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106862.Bytes);
public long this[int i]=>Value[i];

public static A106862Inst Instance=new A106862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106863
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,23L,43L,47L,61L,73L,83L,101L,131L,137L,139L,149L,157L,163L,191L,197L,199L,229L,233L,239L,251L,263L,271L,277L,283L,311L,313L,347L,349L,353L,359L,367L,389L,397L,419L,443L,457L,461L,463L,467L,479L,491L,499L,503L,541L,557L,571L,577L,587L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106863Inst : IEnumerable<long>
{
public static readonly long[] Value=A106863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106863.Bytes);
public long this[int i]=>Value[i];

public static A106863Inst Instance=new A106863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106864
{
public static readonly long[] Value={ 2L,3L,7L,43L,47L,83L,103L,107L,163L,167L,223L,263L,283L,347L,367L,383L,443L,467L,487L,503L,523L,547L,607L,643L,683L,743L,787L,823L,827L,863L,883L,887L,947L,967L,983L,1063L,1087L,1123L,1223L,1303L,1307L,1367L,1423L,1427L,1447L,1483L,1487L,1523L,1583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106864Inst : IEnumerable<long>
{
public static readonly long[] Value=A106864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106864.Bytes);
public long this[int i]=>Value[i];

public static A106864Inst Instance=new A106864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106865
{
public static readonly long[] Value={ 2L,3L,7L,23L,43L,47L,67L,83L,103L,107L,127L,163L,167L,223L,227L,263L,283L,307L,347L,367L,383L,443L,463L,467L,487L,503L,523L,547L,563L,587L,607L,643L,647L,683L,727L,743L,787L,823L,827L,863L,883L,887L,907L,947L,967L,983L,1063L,1087L,1103L,1123L,1163L,1187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106865Inst : IEnumerable<long>
{
public static readonly long[] Value=A106865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106865.Bytes);
public long this[int i]=>Value[i];

public static A106865Inst Instance=new A106865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106866
{
public static readonly long[] Value={ 2L,3L,13L,41L,71L,127L,139L,179L,257L,269L,311L,331L,409L,439L,443L,461L,541L,587L,673L,739L,761L,823L,887L,967L,1051L,1061L,1087L,1129L,1153L,1223L,1237L,1277L,1373L,1381L,1409L,1427L,1439L,1567L,1619L,1733L,1741L,1783L,1933L,1973L,2017L,2063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106866Inst : IEnumerable<long>
{
public static readonly long[] Value=A106866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106866.Bytes);
public long this[int i]=>Value[i];

public static A106866Inst Instance=new A106866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106867
{
public static readonly long[] Value={ 2L,3L,13L,29L,31L,41L,47L,71L,73L,127L,131L,139L,151L,163L,179L,193L,197L,233L,239L,257L,269L,277L,311L,331L,349L,353L,397L,409L,439L,443L,461L,487L,491L,499L,509L,541L,547L,577L,587L,601L,647L,653L,673L,683L,739L,761L,811L,823L,857L,859L,863L,887L,929L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106867Inst : IEnumerable<long>
{
public static readonly long[] Value=A106867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106867.Bytes);
public long this[int i]=>Value[i];

public static A106867Inst Instance=new A106867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106868
{
public static readonly long[] Value={ 2L,3L,29L,31L,47L,73L,131L,151L,163L,193L,197L,233L,239L,277L,349L,353L,397L,487L,491L,499L,509L,547L,577L,601L,647L,653L,683L,811L,857L,859L,863L,929L,947L,1013L,1021L,1039L,1093L,1283L,1289L,1291L,1297L,1301L,1327L,1361L,1429L,1499L,1511L,1531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106868Inst : IEnumerable<long>
{
public static readonly long[] Value=A106868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106868.Bytes);
public long this[int i]=>Value[i];

public static A106868Inst Instance=new A106868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106869
{
public static readonly long[] Value={ 59L,101L,167L,173L,223L,271L,307L,317L,347L,449L,463L,593L,599L,607L,691L,719L,809L,821L,877L,883L,991L,997L,1097L,1117L,1151L,1181L,1231L,1319L,1451L,1453L,1553L,1613L,1669L,1697L,1787L,1789L,1871L,1889L,1913L,2027L,2053L,2143L,2339L,2347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106869Inst : IEnumerable<long>
{
public static readonly long[] Value=A106869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106869.Bytes);
public long this[int i]=>Value[i];

public static A106869Inst Instance=new A106869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106870
{
public static readonly long[] Value={ 7L,13L,19L,31L,37L,43L,67L,73L,79L,97L,103L,127L,139L,151L,157L,163L,181L,193L,199L,211L,223L,229L,241L,271L,277L,283L,307L,313L,349L,367L,373L,379L,397L,409L,421L,439L,457L,463L,487L,499L,523L,541L,571L,577L,601L,607L,613L,619L,631L,643L,661L,673L,709L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106870Inst : IEnumerable<long>
{
public static readonly long[] Value=A106870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106870.Bytes);
public long this[int i]=>Value[i];

public static A106870Inst Instance=new A106870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106871
{
public static readonly long[] Value={ 2L,7L,41L,59L,101L,107L,109L,233L,257L,281L,307L,311L,397L,419L,421L,503L,599L,659L,691L,733L,751L,907L,1051L,1061L,1087L,1103L,1163L,1217L,1249L,1279L,1291L,1307L,1321L,1361L,1373L,1433L,1471L,1489L,1597L,1621L,1693L,1733L,1777L,1787L,1831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106871Inst : IEnumerable<long>
{
public static readonly long[] Value=A106871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106871.Bytes);
public long this[int i]=>Value[i];

public static A106871Inst Instance=new A106871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106872
{
public static readonly long[] Value={ 2L,5L,7L,19L,41L,59L,71L,97L,101L,103L,107L,109L,113L,157L,163L,191L,193L,211L,233L,257L,281L,307L,311L,317L,359L,373L,397L,419L,421L,439L,443L,467L,479L,503L,541L,547L,563L,593L,599L,659L,661L,683L,691L,701L,727L,733L,751L,769L,877L,887L,907L,977L,997L,1033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106872Inst : IEnumerable<long>
{
public static readonly long[] Value=A106872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106872.Bytes);
public long this[int i]=>Value[i];

public static A106872Inst Instance=new A106872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106873
{
public static readonly long[] Value={ 2L,5L,19L,71L,97L,103L,113L,157L,163L,191L,193L,211L,317L,359L,373L,439L,443L,467L,479L,541L,547L,563L,593L,661L,683L,701L,727L,769L,877L,887L,977L,997L,1033L,1039L,1093L,1123L,1151L,1223L,1229L,1289L,1399L,1409L,1423L,1427L,1459L,1601L,1609L,1613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106873Inst : IEnumerable<long>
{
public static readonly long[] Value=A106873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106873.Bytes);
public long this[int i]=>Value[i];

public static A106873Inst Instance=new A106873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106874
{
public static readonly long[] Value={ 47L,67L,131L,149L,173L,227L,293L,349L,379L,431L,521L,577L,607L,617L,653L,811L,839L,853L,857L,919L,937L,971L,1031L,1063L,1187L,1213L,1237L,1259L,1303L,1327L,1451L,1493L,1559L,1583L,1619L,1663L,1721L,1723L,1741L,1879L,1931L,1973L,2003L,2017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106874Inst : IEnumerable<long>
{
public static readonly long[] Value=A106874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106874.Bytes);
public long this[int i]=>Value[i];

public static A106874Inst Instance=new A106874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106875
{
public static readonly long[] Value={ 3L,19L,59L,107L,163L,211L,251L,347L,419L,499L,571L,587L,619L,659L,883L,907L,947L,1051L,1171L,1259L,1283L,1459L,1483L,1499L,1579L,1627L,1747L,1907L,1931L,1987L,2003L,2083L,2179L,2203L,2347L,2411L,2459L,2467L,2531L,2539L,2707L,2803L,2819L,2963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106875Inst : IEnumerable<long>
{
public static readonly long[] Value=A106875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106875.Bytes);
public long this[int i]=>Value[i];

public static A106875Inst Instance=new A106875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106876
{
public static readonly long[] Value={ 3L,11L,43L,67L,83L,131L,139L,179L,227L,283L,307L,331L,379L,443L,467L,491L,523L,547L,563L,643L,683L,691L,739L,787L,811L,827L,859L,971L,1019L,1091L,1123L,1163L,1187L,1291L,1307L,1427L,1451L,1523L,1531L,1571L,1619L,1667L,1699L,1723L,1787L,1811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106876Inst : IEnumerable<long>
{
public static readonly long[] Value=A106876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106876.Bytes);
public long this[int i]=>Value[i];

public static A106876Inst Instance=new A106876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106877
{
public static readonly long[] Value={ 3L,7L,17L,83L,97L,157L,173L,223L,257L,307L,313L,397L,523L,587L,607L,643L,647L,733L,773L,787L,887L,937L,983L,1013L,1223L,1277L,1307L,1427L,1483L,1487L,1613L,1637L,1693L,1753L,1777L,1783L,1907L,2203L,2267L,2273L,2357L,2383L,2393L,2593L,2663L,2677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106877Inst : IEnumerable<long>
{
public static readonly long[] Value=A106877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106877.Bytes);
public long this[int i]=>Value[i];

public static A106877Inst Instance=new A106877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106878
{
public static readonly long[] Value={ 3L,5L,7L,13L,17L,47L,73L,83L,97L,103L,157L,167L,173L,223L,227L,257L,283L,293L,307L,313L,353L,367L,383L,397L,433L,467L,503L,523L,563L,577L,587L,593L,607L,643L,647L,677L,727L,733L,773L,787L,797L,853L,857L,887L,937L,983L,997L,1013L,1063L,1097L,1123L,1153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106878Inst : IEnumerable<long>
{
public static readonly long[] Value=A106878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106878.Bytes);
public long this[int i]=>Value[i];

public static A106878Inst Instance=new A106878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106879
{
public static readonly long[] Value={ 3L,5L,13L,47L,73L,103L,167L,227L,283L,293L,353L,367L,383L,433L,467L,503L,563L,577L,593L,677L,727L,797L,853L,857L,997L,1063L,1097L,1123L,1153L,1193L,1217L,1237L,1433L,1447L,1543L,1553L,1567L,1627L,1657L,1697L,1823L,1847L,1867L,1973L,1987L,1993L,2063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106879Inst : IEnumerable<long>
{
public static readonly long[] Value=A106879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106879.Bytes);
public long this[int i]=>Value[i];

public static A106879Inst Instance=new A106879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106880
{
public static readonly long[] Value={ 11L,29L,71L,109L,149L,151L,179L,191L,211L,239L,281L,331L,359L,379L,389L,401L,421L,449L,491L,499L,541L,571L,599L,631L,641L,659L,701L,739L,751L,809L,821L,911L,919L,991L,1009L,1019L,1031L,1051L,1129L,1171L,1201L,1229L,1289L,1381L,1409L,1429L,1439L,1451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106880Inst : IEnumerable<long>
{
public static readonly long[] Value=A106880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106880.Bytes);
public long this[int i]=>Value[i];

public static A106880Inst Instance=new A106880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106881
{
public static readonly long[] Value={ 11L,29L,71L,79L,109L,149L,151L,179L,191L,211L,239L,281L,331L,359L,379L,389L,401L,421L,431L,449L,491L,499L,541L,569L,571L,599L,631L,641L,659L,701L,709L,739L,751L,809L,821L,911L,919L,991L,1009L,1019L,1031L,1051L,1061L,1129L,1171L,1201L,1229L,1289L,1381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106881Inst : IEnumerable<long>
{
public static readonly long[] Value=A106881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106881.Bytes);
public long this[int i]=>Value[i];

public static A106881Inst Instance=new A106881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106882
{
public static readonly long[] Value={ 2L,5L,17L,29L,53L,89L,101L,137L,149L,173L,197L,257L,269L,281L,293L,317L,353L,401L,449L,461L,509L,521L,593L,617L,641L,653L,677L,701L,797L,809L,857L,881L,929L,941L,953L,977L,1049L,1061L,1109L,1181L,1193L,1217L,1229L,1277L,1289L,1373L,1409L,1433L,1481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106882Inst : IEnumerable<long>
{
public static readonly long[] Value=A106882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106882.Bytes);
public long this[int i]=>Value[i];

public static A106882Inst Instance=new A106882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106883
{
public static readonly long[] Value={ 3L,61L,79L,127L,199L,283L,313L,433L,571L,601L,727L,757L,829L,883L,919L,937L,1069L,1093L,1213L,1291L,1297L,1531L,1609L,1663L,1699L,1741L,1777L,2053L,2083L,2089L,2161L,2239L,2341L,2383L,2677L,2707L,2713L,2731L,2887L,3019L,3169L,3301L,3319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106883Inst : IEnumerable<long>
{
public static readonly long[] Value=A106883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106883.Bytes);
public long this[int i]=>Value[i];

public static A106883Inst Instance=new A106883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106884
{
public static readonly long[] Value={ 3L,13L,61L,79L,127L,199L,211L,283L,313L,337L,373L,433L,571L,601L,727L,757L,829L,859L,883L,907L,919L,937L,1069L,1093L,1213L,1291L,1297L,1303L,1327L,1447L,1531L,1543L,1609L,1621L,1663L,1699L,1741L,1777L,1873L,2053L,2083L,2089L,2161L,2239L,2341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106884Inst : IEnumerable<long>
{
public static readonly long[] Value=A106884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106884.Bytes);
public long this[int i]=>Value[i];

public static A106884Inst Instance=new A106884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106885
{
public static readonly long[] Value={ 2L,5L,41L,59L,83L,89L,197L,227L,293L,359L,431L,479L,587L,617L,743L,821L,863L,929L,1019L,1061L,1151L,1163L,1181L,1217L,1289L,1367L,1373L,1451L,1487L,1571L,1601L,1607L,1619L,1697L,1709L,1877L,1913L,2099L,2243L,2309L,2333L,2351L,2399L,2423L,2459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106885Inst : IEnumerable<long>
{
public static readonly long[] Value=A106885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106885.Bytes);
public long this[int i]=>Value[i];

public static A106885Inst Instance=new A106885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106886
{
public static readonly long[] Value={ 2L,5L,11L,41L,47L,59L,71L,83L,89L,137L,149L,167L,197L,227L,239L,281L,293L,317L,353L,359L,383L,401L,431L,449L,461L,479L,509L,557L,587L,593L,617L,683L,743L,761L,773L,821L,827L,839L,863L,929L,941L,947L,977L,983L,1019L,1061L,1097L,1103L,1151L,1163L,1181L,1217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106886Inst : IEnumerable<long>
{
public static readonly long[] Value=A106886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106886.Bytes);
public long this[int i]=>Value[i];

public static A106886Inst Instance=new A106886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106887
{
public static readonly long[] Value={ 2L,5L,11L,47L,71L,137L,149L,167L,239L,281L,317L,353L,383L,401L,449L,461L,509L,557L,593L,683L,761L,773L,827L,839L,941L,947L,977L,983L,1097L,1103L,1229L,1259L,1307L,1319L,1409L,1493L,1523L,1553L,1721L,1787L,1931L,1997L,2039L,2069L,2087L,2111L,2153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106887Inst : IEnumerable<long>
{
public static readonly long[] Value=A106887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106887.Bytes);
public long this[int i]=>Value[i];

public static A106887Inst Instance=new A106887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106888
{
public static readonly long[] Value={ 43L,103L,139L,181L,277L,367L,439L,523L,547L,607L,673L,751L,823L,997L,1039L,1063L,1117L,1153L,1171L,1231L,1249L,1381L,1453L,1459L,1483L,1693L,1759L,1933L,1951L,1993L,1999L,2011L,2029L,2131L,2287L,2311L,2467L,2473L,2539L,2557L,2617L,2833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106888Inst : IEnumerable<long>
{
public static readonly long[] Value=A106888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106888.Bytes);
public long this[int i]=>Value[i];

public static A106888Inst Instance=new A106888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106889
{
public static readonly long[] Value={ 2L,5L,7L,13L,23L,37L,47L,53L,103L,127L,157L,167L,173L,197L,223L,263L,277L,293L,317L,367L,373L,383L,397L,463L,487L,503L,557L,607L,613L,647L,653L,677L,727L,733L,743L,757L,773L,797L,823L,853L,863L,877L,887L,967L,983L,997L,1013L,1063L,1087L,1093L,1103L,1117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106889Inst : IEnumerable<long>
{
public static readonly long[] Value=A106889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106889.Bytes);
public long this[int i]=>Value[i];

public static A106889Inst Instance=new A106889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106890
{
public static readonly long[] Value={ 11L,13L,17L,23L,31L,41L,47L,53L,59L,67L,79L,83L,101L,103L,107L,109L,127L,139L,167L,181L,193L,197L,229L,239L,251L,281L,283L,293L,307L,311L,317L,337L,353L,359L,367L,379L,397L,401L,431L,439L,443L,461L,479L,487L,509L,541L,547L,557L,563L,569L,599L,613L,617L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106890Inst : IEnumerable<long>
{
public static readonly long[] Value=A106890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106890.Bytes);
public long this[int i]=>Value[i];

public static A106890Inst Instance=new A106890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106891
{
public static readonly long[] Value={ 11L,13L,17L,23L,31L,41L,43L,47L,53L,59L,67L,79L,83L,97L,101L,103L,107L,109L,127L,139L,167L,173L,181L,193L,197L,229L,239L,251L,269L,271L,281L,283L,293L,307L,311L,317L,337L,353L,359L,367L,379L,397L,401L,431L,439L,443L,461L,479L,487L,509L,541L,547L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106891Inst : IEnumerable<long>
{
public static readonly long[] Value=A106891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106891.Bytes);
public long this[int i]=>Value[i];

public static A106891Inst Instance=new A106891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106892
{
public static readonly long[] Value={ 3L,23L,37L,89L,113L,157L,179L,191L,317L,331L,379L,389L,433L,487L,509L,577L,643L,709L,751L,823L,859L,881L,971L,983L,1153L,1171L,1193L,1259L,1277L,1279L,1301L,1373L,1423L,1489L,1607L,1637L,1709L,1741L,1747L,1879L,2027L,2029L,2143L,2179L,2203L,2269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106892Inst : IEnumerable<long>
{
public static readonly long[] Value=A106892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106892.Bytes);
public long this[int i]=>Value[i];

public static A106892Inst Instance=new A106892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106893
{
public static readonly long[] Value={ 3L,5L,31L,59L,67L,71L,97L,137L,181L,223L,229L,251L,313L,353L,367L,383L,443L,449L,463L,467L,521L,619L,631L,641L,647L,653L,661L,691L,719L,727L,797L,829L,839L,947L,977L,1013L,1039L,1049L,1061L,1093L,1103L,1213L,1303L,1321L,1409L,1453L,1483L,1499L,1511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106893Inst : IEnumerable<long>
{
public static readonly long[] Value=A106893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106893.Bytes);
public long this[int i]=>Value[i];

public static A106893Inst Instance=new A106893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106894
{
public static readonly long[] Value={ 3L,71L,101L,103L,239L,277L,307L,401L,457L,571L,617L,733L,853L,929L,1051L,1153L,1223L,1259L,1283L,1301L,1381L,1471L,1669L,1747L,1889L,1933L,2027L,2029L,2039L,2237L,2377L,2411L,2659L,2683L,2693L,2729L,2857L,2909L,3011L,3167L,3181L,3299L,3343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106894Inst : IEnumerable<long>
{
public static readonly long[] Value=A106894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106894.Bytes);
public long this[int i]=>Value[i];

public static A106894Inst Instance=new A106894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106895
{
public static readonly long[] Value={ 3L,17L,37L,71L,79L,101L,103L,149L,239L,241L,251L,271L,277L,307L,347L,383L,397L,401L,457L,571L,617L,653L,659L,661L,733L,769L,773L,811L,853L,863L,929L,1019L,1051L,1061L,1097L,1109L,1123L,1153L,1187L,1223L,1249L,1259L,1283L,1297L,1301L,1303L,1381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106895Inst : IEnumerable<long>
{
public static readonly long[] Value=A106895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106895.Bytes);
public long this[int i]=>Value[i];

public static A106895Inst Instance=new A106895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106896
{
public static readonly long[] Value={ 3L,17L,37L,79L,149L,241L,251L,271L,347L,383L,397L,653L,659L,661L,769L,773L,811L,863L,1019L,1061L,1097L,1109L,1123L,1187L,1249L,1297L,1303L,1459L,1559L,1567L,1583L,1601L,1607L,1619L,1663L,1847L,1901L,1931L,2011L,2143L,2243L,2281L,2309L,2503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106896Inst : IEnumerable<long>
{
public static readonly long[] Value=A106896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106896.Bytes);
public long this[int i]=>Value[i];

public static A106896Inst Instance=new A106896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106897
{
public static readonly long[] Value={ 2L,59L,61L,157L,173L,283L,379L,431L,601L,613L,647L,683L,739L,827L,941L,967L,991L,1087L,1129L,1181L,1217L,1367L,1399L,1553L,1657L,1753L,1823L,1951L,2069L,2179L,2251L,2293L,2311L,2357L,2371L,2609L,2617L,2687L,2753L,2801L,2903L,3067L,3119L,3251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106897Inst : IEnumerable<long>
{
public static readonly long[] Value=A106897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106897.Bytes);
public long this[int i]=>Value[i];

public static A106897Inst Instance=new A106897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106898
{
public static readonly long[] Value={ 2L,7L,53L,59L,61L,89L,97L,131L,157L,173L,263L,283L,331L,337L,353L,379L,431L,479L,491L,521L,541L,601L,613L,643L,647L,683L,709L,719L,739L,827L,883L,911L,941L,967L,991L,1021L,1087L,1093L,1117L,1129L,1181L,1217L,1229L,1231L,1367L,1399L,1427L,1489L,1493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106898Inst : IEnumerable<long>
{
public static readonly long[] Value=A106898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106898.Bytes);
public long this[int i]=>Value[i];

public static A106898Inst Instance=new A106898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106899
{
public static readonly long[] Value={ 2L,7L,53L,89L,97L,131L,263L,331L,337L,353L,479L,491L,521L,541L,643L,709L,719L,883L,911L,1021L,1093L,1117L,1229L,1231L,1427L,1489L,1493L,1511L,1531L,1699L,1787L,1789L,1907L,1999L,2063L,2089L,2129L,2131L,2399L,2591L,2621L,2657L,2707L,2711L,2791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106899Inst : IEnumerable<long>
{
public static readonly long[] Value=A106899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106899.Bytes);
public long this[int i]=>Value[i];

public static A106899Inst Instance=new A106899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106900
{
public static readonly long[] Value={ 83L,191L,197L,269L,439L,487L,523L,619L,823L,907L,947L,977L,1193L,1277L,1319L,1447L,1481L,1499L,1579L,1709L,1741L,1811L,1861L,1867L,2053L,2213L,2221L,2273L,2351L,2447L,2539L,2777L,2789L,2879L,2917L,2939L,2963L,3061L,3089L,3203L,3373L,3449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106900Inst : IEnumerable<long>
{
public static readonly long[] Value=A106900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106900.Bytes);
public long this[int i]=>Value[i];

public static A106900Inst Instance=new A106900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106901
{
public static readonly long[] Value={ 3L,5L,11L,23L,29L,41L,131L,167L,173L,197L,233L,269L,311L,317L,347L,401L,419L,431L,449L,479L,503L,617L,641L,653L,677L,683L,743L,821L,827L,839L,857L,887L,911L,929L,947L,983L,1013L,1031L,1049L,1061L,1151L,1187L,1193L,1217L,1367L,1433L,1439L,1451L,1493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106901Inst : IEnumerable<long>
{
public static readonly long[] Value=A106901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106901.Bytes);
public long this[int i]=>Value[i];

public static A106901Inst Instance=new A106901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106902
{
public static readonly long[] Value={ 3L,5L,11L,17L,23L,29L,41L,71L,107L,113L,131L,167L,173L,197L,227L,233L,269L,311L,317L,347L,401L,419L,431L,449L,479L,503L,521L,617L,641L,653L,677L,683L,719L,743L,809L,821L,827L,839L,857L,881L,887L,911L,929L,941L,947L,983L,1013L,1031L,1049L,1061L,1091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106902Inst : IEnumerable<long>
{
public static readonly long[] Value=A106902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106902.Bytes);
public long this[int i]=>Value[i];

public static A106902Inst Instance=new A106902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106903
{
public static readonly long[] Value={ 13L,19L,43L,67L,103L,127L,151L,157L,223L,229L,271L,307L,331L,349L,373L,409L,421L,433L,457L,523L,577L,613L,661L,727L,733L,739L,757L,769L,829L,859L,883L,919L,937L,967L,1021L,1063L,1069L,1087L,1123L,1171L,1237L,1249L,1327L,1381L,1429L,1447L,1453L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106903Inst : IEnumerable<long>
{
public static readonly long[] Value=A106903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106903.Bytes);
public long this[int i]=>Value[i];

public static A106903Inst Instance=new A106903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106904
{
public static readonly long[] Value={ 13L,19L,43L,67L,103L,127L,151L,157L,223L,229L,271L,307L,331L,349L,373L,409L,421L,433L,457L,463L,523L,577L,613L,631L,661L,727L,733L,739L,757L,769L,829L,859L,883L,919L,937L,967L,1021L,1033L,1039L,1063L,1069L,1087L,1123L,1171L,1237L,1249L,1279L,1291L,1327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106904Inst : IEnumerable<long>
{
public static readonly long[] Value=A106904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106904.Bytes);
public long this[int i]=>Value[i];

public static A106904Inst Instance=new A106904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106905
{
public static readonly long[] Value={ 2L,7L,11L,19L,31L,47L,67L,71L,83L,151L,223L,227L,239L,271L,307L,359L,379L,383L,431L,463L,479L,487L,499L,587L,619L,631L,643L,683L,691L,739L,743L,839L,863L,947L,967L,983L,1019L,1051L,1087L,1151L,1163L,1259L,1279L,1307L,1319L,1367L,1399L,1423L,1451L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106905Inst : IEnumerable<long>
{
public static readonly long[] Value=A106905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106905.Bytes);
public long this[int i]=>Value[i];

public static A106905Inst Instance=new A106905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106906
{
public static readonly long[] Value={ 2L,7L,11L,19L,31L,47L,59L,67L,71L,83L,151L,163L,167L,223L,227L,239L,271L,307L,331L,359L,379L,383L,431L,463L,479L,487L,499L,587L,619L,631L,643L,683L,691L,739L,743L,787L,811L,827L,839L,863L,947L,967L,983L,1019L,1051L,1087L,1103L,1123L,1151L,1163L,1259L,1279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106906Inst : IEnumerable<long>
{
public static readonly long[] Value=A106906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106906.Bytes);
public long this[int i]=>Value[i];

public static A106906Inst Instance=new A106906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106907
{
public static readonly long[] Value={ 11L,181L,401L,521L,619L,709L,719L,829L,911L,971L,1511L,1709L,1831L,1879L,2039L,2161L,2179L,2281L,2579L,2861L,3001L,3061L,3221L,3259L,3359L,3499L,4051L,4159L,4409L,4691L,4871L,4931L,4951L,5009L,5171L,5351L,5449L,5569L,5591L,5839L,6131L,6449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106907Inst : IEnumerable<long>
{
public static readonly long[] Value=A106907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106907.Bytes);
public long this[int i]=>Value[i];

public static A106907Inst Instance=new A106907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106908
{
public static readonly long[] Value={ 5L,11L,31L,89L,179L,181L,191L,331L,401L,419L,421L,449L,521L,599L,619L,641L,709L,719L,829L,859L,911L,971L,991L,1021L,1039L,1109L,1259L,1291L,1301L,1489L,1511L,1549L,1621L,1709L,1831L,1871L,1879L,2011L,2039L,2099L,2161L,2179L,2281L,2311L,2381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106908Inst : IEnumerable<long>
{
public static readonly long[] Value=A106908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106908.Bytes);
public long this[int i]=>Value[i];

public static A106908Inst Instance=new A106908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106909
{
public static readonly long[] Value={ 5L,31L,89L,179L,191L,331L,419L,421L,449L,599L,641L,859L,991L,1021L,1039L,1109L,1259L,1291L,1301L,1489L,1549L,1621L,1871L,2011L,2099L,2311L,2381L,2539L,2689L,2909L,3041L,3169L,3301L,3331L,3389L,3391L,3821L,3919L,3931L,4019L,4211L,4229L,4261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106909Inst : IEnumerable<long>
{
public static readonly long[] Value=A106909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106909.Bytes);
public long this[int i]=>Value[i];

public static A106909Inst Instance=new A106909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106910
{
public static readonly long[] Value={ 2L,7L,17L,43L,107L,193L,227L,277L,293L,307L,457L,523L,593L,613L,673L,827L,857L,877L,967L,997L,1063L,1097L,1117L,1217L,1223L,1283L,1447L,1493L,1613L,1627L,1657L,1663L,1667L,1693L,1733L,1823L,1867L,1877L,2087L,2153L,2207L,2243L,2287L,2383L,2393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106910Inst : IEnumerable<long>
{
public static readonly long[] Value=A106910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106910.Bytes);
public long this[int i]=>Value[i];

public static A106910Inst Instance=new A106910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106911
{
public static readonly long[] Value={ 2L,7L,13L,17L,43L,73L,83L,107L,127L,167L,173L,193L,197L,227L,233L,263L,277L,283L,293L,307L,337L,347L,373L,457L,503L,523L,547L,557L,563L,593L,607L,613L,673L,677L,733L,743L,787L,827L,853L,857L,877L,887L,937L,953L,967L,997L,1033L,1063L,1097L,1117L,1163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106911Inst : IEnumerable<long>
{
public static readonly long[] Value=A106911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106911.Bytes);
public long this[int i]=>Value[i];

public static A106911Inst Instance=new A106911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106912
{
public static readonly long[] Value={ 2L,7L,13L,73L,83L,127L,167L,173L,197L,233L,263L,283L,337L,347L,373L,503L,547L,557L,563L,607L,677L,733L,743L,787L,853L,887L,937L,953L,1033L,1163L,1187L,1297L,1327L,1427L,1487L,1553L,1583L,1597L,1723L,1777L,1847L,1913L,1933L,1987L,1993L,1997L,2053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106912Inst : IEnumerable<long>
{
public static readonly long[] Value=A106912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106912.Bytes);
public long this[int i]=>Value[i];

public static A106912Inst Instance=new A106912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106913
{
public static readonly long[] Value={ 59L,71L,199L,229L,251L,269L,311L,379L,389L,509L,631L,661L,691L,751L,839L,929L,1049L,1061L,1171L,1181L,1279L,1321L,1409L,1439L,1499L,1571L,1609L,1699L,1721L,1741L,1901L,1951L,2029L,2069L,2269L,2341L,2399L,2531L,2621L,2671L,2729L,2819L,2971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106913Inst : IEnumerable<long>
{
public static readonly long[] Value=A106913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106913.Bytes);
public long this[int i]=>Value[i];

public static A106913Inst Instance=new A106913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106914
{
public static readonly long[] Value={ 3L,5L,59L,61L,131L,157L,283L,293L,349L,397L,461L,523L,587L,661L,677L,691L,787L,853L,859L,997L,1013L,1091L,1109L,1237L,1277L,1301L,1427L,1459L,1571L,1699L,1811L,1973L,1979L,2029L,2141L,2203L,2243L,2309L,2467L,2579L,2659L,2693L,2749L,2803L,2861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106914Inst : IEnumerable<long>
{
public static readonly long[] Value=A106914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106914.Bytes);
public long this[int i]=>Value[i];

public static A106914Inst Instance=new A106914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106915
{
public static readonly long[] Value={ 3L,5L,13L,19L,59L,61L,83L,101L,131L,139L,157L,173L,181L,227L,229L,251L,269L,283L,293L,307L,349L,397L,419L,461L,467L,509L,523L,563L,587L,619L,643L,661L,677L,691L,733L,773L,787L,797L,811L,829L,853L,859L,941L,971L,997L,1013L,1021L,1069L,1091L,1109L,1123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106915Inst : IEnumerable<long>
{
public static readonly long[] Value=A106915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106915.Bytes);
public long this[int i]=>Value[i];

public static A106915Inst Instance=new A106915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106916
{
public static readonly long[] Value={ 3L,5L,13L,19L,83L,101L,139L,173L,181L,227L,229L,251L,269L,307L,419L,467L,509L,563L,619L,643L,733L,773L,797L,811L,829L,941L,971L,1021L,1069L,1123L,1181L,1259L,1291L,1307L,1483L,1531L,1613L,1627L,1637L,1669L,1693L,1741L,1861L,1867L,1907L,1931L,1949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106916Inst : IEnumerable<long>
{
public static readonly long[] Value=A106916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106916.Bytes);
public long this[int i]=>Value[i];

public static A106916Inst Instance=new A106916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106917
{
public static readonly long[] Value={ 2L,7L,71L,79L,113L,191L,193L,263L,337L,401L,457L,463L,569L,599L,617L,631L,641L,809L,823L,863L,919L,991L,1009L,1031L,1201L,1289L,1297L,1327L,1367L,1471L,1583L,1607L,1801L,1831L,1913L,1999L,2087L,2111L,2143L,2153L,2297L,2311L,2473L,2521L,2543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106917Inst : IEnumerable<long>
{
public static readonly long[] Value=A106917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106917.Bytes);
public long this[int i]=>Value[i];

public static A106917Inst Instance=new A106917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106918
{
public static readonly long[] Value={ 3L,5L,19L,53L,167L,181L,193L,257L,263L,271L,281L,293L,307L,331L,359L,379L,449L,487L,523L,557L,607L,617L,619L,761L,829L,883L,911L,947L,997L,1031L,1049L,1187L,1231L,1303L,1433L,1487L,1523L,1549L,1553L,1667L,1669L,1759L,1811L,1889L,1933L,1973L,1993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106918Inst : IEnumerable<long>
{
public static readonly long[] Value=A106918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106918.Bytes);
public long this[int i]=>Value[i];

public static A106918Inst Instance=new A106918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106919
{
public static readonly long[] Value={ 3L,5L,7L,19L,29L,41L,53L,79L,107L,127L,137L,167L,181L,193L,199L,239L,241L,251L,257L,263L,271L,277L,281L,293L,307L,311L,331L,359L,379L,433L,449L,487L,491L,499L,523L,557L,577L,593L,599L,607L,617L,619L,643L,647L,653L,661L,709L,757L,761L,829L,853L,877L,883L,907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106919Inst : IEnumerable<long>
{
public static readonly long[] Value=A106919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106919.Bytes);
public long this[int i]=>Value[i];

public static A106919Inst Instance=new A106919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106920
{
public static readonly long[] Value={ 3L,5L,7L,29L,41L,79L,107L,127L,137L,199L,239L,241L,251L,277L,311L,433L,491L,499L,577L,593L,599L,643L,647L,653L,661L,709L,757L,853L,877L,907L,971L,1039L,1051L,1069L,1087L,1091L,1097L,1259L,1301L,1307L,1319L,1423L,1451L,1543L,1579L,1583L,1597L,1609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106920Inst : IEnumerable<long>
{
public static readonly long[] Value=A106920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106920.Bytes);
public long this[int i]=>Value[i];

public static A106920Inst Instance=new A106920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106921
{
public static readonly long[] Value={ 17L,71L,139L,163L,197L,223L,317L,373L,383L,389L,439L,461L,479L,521L,547L,631L,641L,677L,727L,733L,743L,787L,827L,1019L,1063L,1103L,1181L,1229L,1237L,1327L,1361L,1373L,1511L,1559L,1619L,1657L,1693L,1747L,1823L,1907L,1913L,1951L,2113L,2129L,2131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106921Inst : IEnumerable<long>
{
public static readonly long[] Value=A106921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106921.Bytes);
public long this[int i]=>Value[i];

public static A106921Inst Instance=new A106921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106922
{
public static readonly long[] Value={ 17L,59L,71L,139L,163L,197L,223L,317L,373L,383L,389L,439L,461L,479L,521L,547L,631L,641L,677L,727L,733L,743L,787L,827L,953L,1019L,1063L,1103L,1181L,1201L,1229L,1237L,1327L,1361L,1373L,1511L,1559L,1619L,1657L,1693L,1747L,1787L,1823L,1907L,1913L,1951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106922Inst : IEnumerable<long>
{
public static readonly long[] Value=A106922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106922.Bytes);
public long this[int i]=>Value[i];

public static A106922Inst Instance=new A106922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106923
{
public static readonly long[] Value={ 43L,109L,151L,331L,337L,499L,751L,757L,907L,919L,1117L,1201L,1303L,1471L,1549L,1789L,2053L,2137L,2143L,2221L,2311L,2473L,2647L,2713L,3049L,3259L,3301L,3361L,3607L,3697L,3943L,4099L,4363L,4447L,4621L,4783L,4789L,5209L,5527L,5623L,5653L,5737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106923Inst : IEnumerable<long>
{
public static readonly long[] Value=A106923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106923.Bytes);
public long this[int i]=>Value[i];

public static A106923Inst Instance=new A106923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106924
{
public static readonly long[] Value={ 7L,37L,43L,109L,151L,193L,211L,331L,337L,379L,457L,487L,499L,673L,709L,751L,757L,883L,907L,919L,991L,1117L,1171L,1201L,1303L,1327L,1381L,1423L,1429L,1453L,1471L,1549L,1597L,1747L,1759L,1789L,1801L,1873L,2017L,2053L,2083L,2137L,2143L,2221L,2311L,2347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106924Inst : IEnumerable<long>
{
public static readonly long[] Value=A106924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106924.Bytes);
public long this[int i]=>Value[i];

public static A106924Inst Instance=new A106924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106925
{
public static readonly long[] Value={ 7L,37L,193L,211L,379L,457L,487L,673L,709L,883L,991L,1171L,1327L,1381L,1423L,1429L,1453L,1597L,1747L,1759L,1801L,1873L,2017L,2083L,2347L,2521L,2671L,2851L,3313L,3319L,3469L,3529L,3613L,3739L,3823L,3847L,3889L,4027L,4327L,4519L,4603L,4813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106925Inst : IEnumerable<long>
{
public static readonly long[] Value=A106925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106925.Bytes);
public long this[int i]=>Value[i];

public static A106925Inst Instance=new A106925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106926
{
public static readonly long[] Value={ 2L,11L,29L,113L,137L,179L,191L,233L,347L,359L,401L,431L,449L,617L,659L,701L,743L,809L,821L,863L,911L,947L,1019L,1103L,1187L,1229L,1283L,1367L,1373L,1409L,1493L,1583L,1733L,1913L,1997L,2003L,2027L,2039L,2081L,2087L,2207L,2333L,2381L,2447L,2531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106926Inst : IEnumerable<long>
{
public static readonly long[] Value=A106926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106926.Bytes);
public long this[int i]=>Value[i];

public static A106926Inst Instance=new A106926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106927
{
public static readonly long[] Value={ 2L,11L,23L,29L,53L,71L,107L,113L,137L,149L,179L,191L,197L,233L,239L,263L,281L,317L,347L,359L,389L,401L,431L,443L,449L,491L,557L,569L,599L,617L,641L,653L,659L,683L,701L,743L,809L,821L,827L,863L,911L,947L,953L,977L,1019L,1031L,1061L,1103L,1163L,1187L,1229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106927Inst : IEnumerable<long>
{
public static readonly long[] Value=A106927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106927.Bytes);
public long this[int i]=>Value[i];

public static A106927Inst Instance=new A106927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106928
{
public static readonly long[] Value={ 2L,23L,53L,71L,107L,149L,197L,239L,263L,281L,317L,389L,443L,491L,557L,569L,599L,641L,653L,683L,827L,953L,977L,1031L,1061L,1163L,1289L,1439L,1451L,1481L,1499L,1523L,1607L,1619L,1667L,1709L,1787L,1871L,1877L,1901L,2069L,2111L,2129L,2153L,2213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106928Inst : IEnumerable<long>
{
public static readonly long[] Value=A106928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106928.Bytes);
public long this[int i]=>Value[i];

public static A106928Inst Instance=new A106928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106929
{
public static readonly long[] Value={ 67L,79L,127L,163L,277L,373L,421L,463L,541L,547L,613L,631L,739L,823L,877L,967L,1033L,1051L,1087L,1093L,1129L,1213L,1297L,1621L,1663L,1723L,1831L,1933L,1999L,2011L,2179L,2251L,2377L,2389L,2437L,2503L,2557L,2683L,2689L,2731L,2767L,2797L,2857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106929Inst : IEnumerable<long>
{
public static readonly long[] Value=A106929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106929.Bytes);
public long this[int i]=>Value[i];

public static A106929Inst Instance=new A106929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106930
{
public static readonly long[] Value={ 67L,79L,127L,163L,277L,373L,421L,463L,541L,547L,571L,613L,631L,739L,823L,877L,967L,1009L,1033L,1051L,1087L,1093L,1129L,1213L,1297L,1579L,1621L,1663L,1723L,1831L,1933L,1999L,2011L,2179L,2251L,2269L,2293L,2377L,2389L,2437L,2503L,2557L,2683L,2689L,2731L,2767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106930Inst : IEnumerable<long>
{
public static readonly long[] Value=A106930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106930.Bytes);
public long this[int i]=>Value[i];

public static A106930Inst Instance=new A106930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106931
{
public static readonly long[] Value={ 5L,13L,29L,53L,61L,149L,157L,173L,181L,229L,269L,277L,293L,317L,389L,397L,421L,461L,541L,557L,613L,653L,661L,709L,733L,773L,821L,829L,853L,877L,941L,997L,1013L,1061L,1093L,1109L,1117L,1213L,1229L,1301L,1373L,1429L,1549L,1597L,1621L,1637L,1693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106931Inst : IEnumerable<long>
{
public static readonly long[] Value=A106931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106931.Bytes);
public long this[int i]=>Value[i];

public static A106931Inst Instance=new A106931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106932
{
public static readonly long[] Value={ 17L,19L,23L,29L,37L,47L,59L,71L,73L,83L,89L,103L,107L,127L,131L,149L,157L,163L,167L,173L,181L,193L,199L,211L,223L,227L,241L,257L,263L,277L,283L,293L,307L,317L,349L,359L,389L,397L,431L,439L,449L,457L,461L,467L,479L,491L,509L,523L,557L,569L,571L,601L,613L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106932Inst : IEnumerable<long>
{
public static readonly long[] Value=A106932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106932.Bytes);
public long this[int i]=>Value[i];

public static A106932Inst Instance=new A106932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106933
{
public static readonly long[] Value={ 17L,19L,23L,29L,37L,47L,59L,67L,71L,73L,83L,89L,103L,107L,127L,131L,149L,151L,157L,163L,167L,173L,181L,193L,199L,211L,223L,227L,241L,257L,263L,269L,277L,283L,293L,307L,317L,349L,359L,389L,397L,419L,421L,431L,439L,449L,457L,461L,467L,479L,491L,509L,523L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106933Inst : IEnumerable<long>
{
public static readonly long[] Value=A106933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106933.Bytes);
public long this[int i]=>Value[i];

public static A106933Inst Instance=new A106933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106934
{
public static readonly long[] Value={ 3L,11L,31L,107L,163L,167L,199L,211L,311L,367L,431L,439L,547L,643L,751L,787L,811L,887L,907L,911L,983L,1187L,1367L,1399L,1423L,1523L,1571L,1663L,1847L,1867L,1907L,1931L,1979L,1999L,2063L,2203L,2207L,2251L,2339L,2459L,2579L,2591L,2647L,2659L,2663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106934Inst : IEnumerable<long>
{
public static readonly long[] Value=A106934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106934.Bytes);
public long this[int i]=>Value[i];

public static A106934Inst Instance=new A106934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106935
{
public static readonly long[] Value={ 3L,7L,11L,23L,31L,71L,79L,107L,131L,139L,163L,167L,199L,211L,227L,283L,311L,347L,367L,379L,419L,431L,439L,479L,487L,499L,503L,547L,571L,607L,619L,643L,683L,691L,719L,743L,751L,787L,811L,823L,827L,839L,887L,907L,911L,947L,983L,991L,1031L,1051L,1091L,1151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106935Inst : IEnumerable<long>
{
public static readonly long[] Value=A106935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106935.Bytes);
public long this[int i]=>Value[i];

public static A106935Inst Instance=new A106935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106936
{
public static readonly long[] Value={ 3L,7L,23L,71L,79L,131L,139L,227L,283L,347L,379L,419L,479L,487L,499L,503L,571L,607L,619L,683L,691L,719L,743L,823L,827L,839L,947L,991L,1031L,1051L,1091L,1151L,1163L,1231L,1303L,1319L,1439L,1451L,1459L,1499L,1559L,1567L,1627L,1723L,1831L,2003L,2011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106936Inst : IEnumerable<long>
{
public static readonly long[] Value=A106936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106936.Bytes);
public long this[int i]=>Value[i];

public static A106936Inst Instance=new A106936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106937
{
public static readonly long[] Value={ 2L,13L,89L,101L,137L,229L,257L,373L,389L,433L,457L,557L,577L,757L,761L,769L,773L,953L,1021L,1109L,1181L,1249L,1277L,1301L,1373L,1429L,1481L,1549L,1613L,1657L,1789L,1801L,1889L,1993L,2333L,2389L,2393L,2549L,2593L,2677L,2741L,2753L,2797L,2801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106937Inst : IEnumerable<long>
{
public static readonly long[] Value=A106937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106937.Bytes);
public long this[int i]=>Value[i];

public static A106937Inst Instance=new A106937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106938
{
public static readonly long[] Value={ 2L,13L,89L,101L,137L,229L,257L,373L,389L,421L,433L,457L,557L,577L,701L,757L,761L,769L,773L,953L,1021L,1033L,1069L,1109L,1181L,1249L,1277L,1301L,1373L,1429L,1481L,1549L,1613L,1657L,1789L,1801L,1889L,1913L,1973L,1993L,1997L,2333L,2389L,2393L,2549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106938Inst : IEnumerable<long>
{
public static readonly long[] Value=A106938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106938.Bytes);
public long this[int i]=>Value[i];

public static A106938Inst Instance=new A106938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106939
{
public static readonly long[] Value={ 5L,79L,167L,359L,373L,577L,617L,877L,881L,947L,1213L,1223L,1231L,1567L,1741L,1861L,1889L,2179L,2347L,2381L,2521L,2539L,2633L,2789L,2843L,3203L,3433L,3659L,3701L,3719L,3823L,4049L,4051L,4127L,4297L,4549L,4871L,4973L,4999L,5297L,5477L,5507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106939Inst : IEnumerable<long>
{
public static readonly long[] Value=A106939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106939.Bytes);
public long this[int i]=>Value[i];

public static A106939Inst Instance=new A106939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106940
{
public static readonly long[] Value={ 5L,43L,73L,79L,131L,167L,179L,229L,263L,359L,367L,373L,521L,569L,577L,617L,811L,877L,881L,947L,953L,997L,1009L,1021L,1051L,1151L,1163L,1213L,1223L,1231L,1279L,1283L,1307L,1409L,1429L,1439L,1567L,1607L,1697L,1741L,1747L,1783L,1823L,1861L,1889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106940Inst : IEnumerable<long>
{
public static readonly long[] Value=A106940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106940.Bytes);
public long this[int i]=>Value[i];

public static A106940Inst Instance=new A106940Inst();

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