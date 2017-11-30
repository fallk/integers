using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A177864
{
public static readonly long[] Value={ 4L,2L,3L,3L,2L,4L,2L,4L,2L,3L,2L,4L,2L,4L,3L,3L,4L,2L,2L,2L,3L,2L,2L,4L,2L,3L,3L,2L,2L,3L,2L,4L,4L,2L,3L,4L,2L,4L,3L,3L,2L,2L,4L,2L,4L,2L,3L,3L,2L,2L,2L,3L,2L,2L,4L,2L,3L,2L,4L,4L,4L,2L,2L,4L,4L,2L,3L,3L,2L,2L,2L,3L,4L,2L,4L,3L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,4L,2L,3L,2L,2L,3L,4L,2L,4L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177864Inst : IEnumerable<long>
{
public static readonly long[] Value=A177864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177864.Bytes);
public long this[int i]=>Value[i];

public static A177864Inst Instance=new A177864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177865
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,2L,3L,5L,3L,6L,4L,4L,5L,8L,5L,9L,4L,6L,10L,5L,10L,9L,6L,6L,7L,10L,9L,6L,6L,10L,15L,7L,9L,7L,14L,8L,9L,18L,9L,15L,7L,19L,8L,11L,18L,12L,15L,15L,9L,10L,22L,8L,21L,10L,21L,11L,22L,14L,10L,13L,11L,14L,25L,11L,13L,14L,12L,17L,12L,12L,27L,19L,16L,15L,27L,12L,12L,12L,12L,27L,11L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177865Inst : IEnumerable<long>
{
public static readonly long[] Value=A177865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177865.Bytes);
public long this[int i]=>Value[i];

public static A177865Inst Instance=new A177865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177866
{
public static readonly long[] Value={ 2L,4L,6L,7L,8L,14L,20L,110L,138L,140L,145L,300L,390L,1484L,3194L,3300L,3950L,4986L,5574L,5630L,5874L,8866L,11390L,45130L,86110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177866Inst : IEnumerable<long>
{
public static readonly long[] Value=A177866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177866.Bytes);
public long this[int i]=>Value[i];

public static A177866Inst Instance=new A177866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177867
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,14L,20L,24L,30L,36L,54L,68L,72L,84L,94L,102L,120L,134L,138L,168L,198L,258L,310L,320L,328L,338L,348L,360L,370L,390L,426L,446L,450L,510L,574L,588L,624L,660L,672L,692L,728L,754L,760L,778L,804L,870L,940L,974L,996L,1014L,1030L,1036L,1040L,1044L,1086L,1142L,1166L,1174L,1180L,1194L,1206L,1210L,1212L,1230L,1248L,1260L,1280L,1292L,1296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177867Inst : IEnumerable<long>
{
public static readonly long[] Value=A177867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177867.Bytes);
public long this[int i]=>Value[i];

public static A177867Inst Instance=new A177867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177868
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177868Inst : IEnumerable<long>
{
public static readonly long[] Value=A177868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177868.Bytes);
public long this[int i]=>Value[i];

public static A177868Inst Instance=new A177868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177869
{
public static readonly long[] Value={ 1L,2L,6L,8L,12L,20L,25L,30L,36L,42L,48L,54L,60L,70L,77L,84L,91L,98L,105L,112L,119L,126L,128L,136L,144L,152L,160L,168L,176L,184L,192L,200L,208L,216L,224L,232L,240L,248L,261L,270L,279L,288L,297L,306L,315L,324L,333L,342L,351L,360L,369L,378L,387L,396L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177869Inst : IEnumerable<long>
{
public static readonly long[] Value=A177869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177869.Bytes);
public long this[int i]=>Value[i];

public static A177869Inst Instance=new A177869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177870
{
public static readonly long[] Value={ 2L,3L,5L,6L,1L,9L,4L,4L,9L,0L,1L,9L,2L,3L,4L,4L,9L,2L,8L,8L,4L,6L,9L,8L,2L,5L,3L,7L,4L,5L,9L,6L,2L,7L,1L,6L,3L,1L,4L,7L,8L,7L,7L,0L,4L,9L,5L,3L,1L,3L,2L,9L,3L,6L,5L,7L,3L,1L,2L,0L,8L,4L,4L,4L,2L,3L,0L,8L,6L,2L,3L,0L,4L,7L,1L,4L,6L,5L,6L,7L,4L,8L,9L,7L,1L,0L,2L,6L,1L,1L,9L,0L,0L,6L,5L,8L,7L,8L,0L,0L,9L,8L,6L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177870Inst : IEnumerable<long>
{
public static readonly long[] Value=A177870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177870.Bytes);
public long this[int i]=>Value[i];

public static A177870Inst Instance=new A177870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177871
{
public static readonly long[] Value={ 60L,120L,210L,420L,840L,1260L,1680L,2310L,2730L,3360L,4620L,5460L,6930L,7140L,9240L,10920L,13860L,14280L,15960L,16380L,18480L,21840L,27720L,28560L,30030L,31920L,32760L,36960L,39270L,43680L,43890L,46410L,55440L,57120L,60060L,73920L,78540L,87360L,87780L,90090L,92820L,103740L,106260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177871Inst : IEnumerable<long>
{
public static readonly long[] Value=A177871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177871.Bytes);
public long this[int i]=>Value[i];

public static A177871Inst Instance=new A177871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177872
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,15L,22L,29L,33L,37L,38L,40L,44L,47L,51L,55L,56L,65L,66L,73L,74L,77L,78L,79L,83L,87L,88L,90L,92L,97L,99L,100L,101L,110L,111L,113L,117L,121L,124L,125L,131L,141L,143L,144L,146L,149L,151L,161L,163L,164L,167L,169L,171L,174L,181L,187L,189L,191L,198L,202L,209L,212L,222L,226L,232L,242L,252L,262L,263L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177872Inst : IEnumerable<long>
{
public static readonly long[] Value=A177872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177872.Bytes);
public long this[int i]=>Value[i];

public static A177872Inst Instance=new A177872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177873
{
public static readonly long[] Value={ 29L,37L,47L,73L,79L,83L,97L,113L,149L,163L,167L,263L,277L,283L,311L,317L,349L,359L,389L,421L,433L,449L,461L,509L,521L,607L,617L,641L,761L,941L,953L,983L,1009L,1021L,1031L,1033L,1069L,1097L,1109L,1153L,1181L,1193L,1201L,1213L,1231L,1237L,1283L,1301L,1321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177873Inst : IEnumerable<long>
{
public static readonly long[] Value=A177873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177873.Bytes);
public long this[int i]=>Value[i];

public static A177873Inst Instance=new A177873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177874
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,19L,37L,74L,147L,293L,586L,1172L,2343L,4686L,9371L,18742L,37484L,74967L,149933L,299866L,599731L,1199461L,2398922L,4797844L,9595688L,19191376L,38382751L,76765501L,153531001L,307062002L,614124003L,1228248006L,2456496012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177874Inst : IEnumerable<long>
{
public static readonly long[] Value=A177874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177874.Bytes);
public long this[int i]=>Value[i];

public static A177874Inst Instance=new A177874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177875
{
public static readonly BigInteger[] Value={ 2L,5L,19L,1172L,18742L,74967L,307062002L,329705313529178423L,BigInteger.Parse("88504596182827979077122168"),BigInteger.Parse("23200948861751257747193113585514"),BigInteger.Parse("24327958153659686843520766271043070385") };
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
public class A177875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177875Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177875.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177875.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177875Inst Instance=new A177875Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177876
{
public static readonly long[] Value={ 2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177876Inst : IEnumerable<long>
{
public static readonly long[] Value=A177876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177876.Bytes);
public long this[int i]=>Value[i];

public static A177876Inst Instance=new A177876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177877
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,10L,4L,10L,16L,20L,5L,13L,22L,30L,35L,6L,16L,28L,40L,50L,56L,7L,19L,34L,50L,65L,77L,84L,8L,22L,40L,60L,80L,98L,112L,120L,9L,25L,46L,70L,95L,119L,140L,156L,165L,10L,28L,52L,80L,110L,140L,168L,192L,210L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177877Inst : IEnumerable<long>
{
public static readonly long[] Value=A177877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177877.Bytes);
public long this[int i]=>Value[i];

public static A177877Inst Instance=new A177877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177878
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,2L,4L,2L,4L,0L,5L,3L,6L,2L,3L,6L,4L,8L,4L,6L,0L,7L,5L,10L,6L,9L,3L,4L,8L,6L,12L,8L,12L,6L,8L,0L,9L,7L,14L,10L,15L,9L,12L,4L,5L,10L,8L,16L,12L,18L,12L,16L,8L,10L,0L,11L,9L,18L,14L,21L,15L,20L,12L,15L,5L,6L,12L,10L,20L,16L,24L,18L,24L,16L,20L,10L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177878Inst : IEnumerable<long>
{
public static readonly long[] Value=A177878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177878.Bytes);
public long this[int i]=>Value[i];

public static A177878Inst Instance=new A177878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177879
{
public static readonly BigInteger[] Value={ 7L,97L,31L,708158977L,127L,22783L,BigInteger.Parse("113210499946729046527"),12289L };
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
public class A177879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177879.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177879Inst Instance=new A177879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177880
{
public static readonly long[] Value={ 4L,9L,12L,18L,20L,25L,28L,32L,36L,44L,45L,49L,50L,52L,60L,63L,64L,68L,72L,75L,76L,84L,90L,92L,96L,98L,99L,100L,108L,116L,117L,121L,124L,126L,128L,132L,140L,144L,147L,148L,150L,153L,156L,160L,164L,169L,171L,172L,175L,180L,188L,192L,196L,198L,200L,204L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177880Inst : IEnumerable<long>
{
public static readonly long[] Value=A177880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177880.Bytes);
public long this[int i]=>Value[i];

public static A177880Inst Instance=new A177880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177881
{
public static readonly long[] Value={ 0L,0L,1L,4L,12L,36L,109L,328L,984L,2952L,8857L,26572L,79716L,239148L,717445L,2152336L,6457008L,19371024L,58113073L,174339220L,523017660L,1569052980L,4707158941L,14121476824L,42364430472L,127093291416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177881Inst : IEnumerable<long>
{
public static readonly long[] Value=A177881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177881.Bytes);
public long this[int i]=>Value[i];

public static A177881Inst Instance=new A177881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177882
{
public static readonly long[] Value={ 1L,15L,85L,771L,4369L,65535L,327685L,3342387L,16843009L,252645135L,1431655765L,12884901891L,73014444049L,1095216660735L,5519032976645L,56294136361779L,281479271743489L,4222189076152335L,23925738098196565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177882Inst : IEnumerable<long>
{
public static readonly long[] Value=A177882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177882.Bytes);
public long this[int i]=>Value[i];

public static A177882Inst Instance=new A177882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177883
{
public static readonly long[] Value={ 4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177883Inst : IEnumerable<long>
{
public static readonly long[] Value=A177883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177883.Bytes);
public long this[int i]=>Value[i];

public static A177883Inst Instance=new A177883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177884
{
public static readonly long[] Value={ 1387L,2047L,4371L,8911L,13747L,14491L,19951L,42799L,60787L,90751L,123251L,150851L,256999L,258511L,271951L,272251L,275887L,294271L,387731L,396271L,422659L,435671L,443719L,452051L,476971L,514447L,672487L,680627L,741751L,769567L,877099L,916327L,1024651L,1052503L,1092547L,1152271L,1277179L,1302451L,1325843L,1397419L,1419607L,1433407L,1441091L,1459927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177884Inst : IEnumerable<long>
{
public static readonly long[] Value=A177884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177884.Bytes);
public long this[int i]=>Value[i];

public static A177884Inst Instance=new A177884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177885
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,4L,-27L,256L,-3125L,46656L,-823543L,16777216L,-387420489L,10000000000L,-285311670611L,8916100448256L,-302875106592253L,11112006825558016L,-437893890380859375L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("-827240261886336764177") };
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
public class A177885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177885Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177885.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177885.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177885Inst Instance=new A177885Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177886
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,0L,5L,2L,8L,0L,9L,1L,11L,0L,5L,9L,15L,0L,17L,3L,7L,0L,21L,2L,34L,0L,62L,7L,27L,0L,29L,8L,11L,0L,15L,9L,35L,0L,13L,6L,39L,0L,41L,9L,36L,0L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177886Inst : IEnumerable<long>
{
public static readonly long[] Value=A177886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177886.Bytes);
public long this[int i]=>Value[i];

public static A177886Inst Instance=new A177886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177887
{
public static readonly long[] Value={ 1L,4L,5L,9L,10L,14L,16L,20L,25L,30L,35L,36L,40L,45L,49L,55L,56L,64L,80L,81L,84L,90L,91L,100L,105L,120L,121L,125L,126L,140L,144L,154L,160L,165L,169L,180L,196L,204L,220L,224L,225L,231L,245L,250L,256L,260L,270L,285L,286L,289L,315L,320L,324L,336L,350L,360L,361L,364L,385L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177887Inst : IEnumerable<long>
{
public static readonly long[] Value=A177887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177887.Bytes);
public long this[int i]=>Value[i];

public static A177887Inst Instance=new A177887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177888
{
public static readonly BigInteger[] Value={ 1L,2L,1L,3L,3L,1L,4L,5L,7L,1L,5L,7L,17L,43L,1L,6L,9L,31L,257L,1807L,1L,7L,11L,49L,871L,65537L,3263443L,1L,8L,13L,71L,2209L,756031L,4294967297L,10650056950807L,1L,9L,15L,97L,4691L,4870849L,571580604871L,BigInteger.Parse("18446744073709551617"),BigInteger.Parse("113423713055421844361000443"),1L };
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
public class A177888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177888Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177888.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177888.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177888Inst Instance=new A177888Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177889
{
public static readonly long[] Value={ 6L,2L,8L,0L,0L,4L,5L,2L,7L,9L,3L,7L,9L,9L,0L,4L,6L,8L,6L,9L,8L,2L,3L,1L,4L,8L,9L,1L,3L,6L,2L,0L,8L,1L,6L,7L,7L,7L,1L,3L,3L,3L,1L,5L,9L,5L,8L,8L,2L,0L,8L,1L,4L,7L,2L,8L,5L,2L,1L,8L,2L,0L,6L,2L,0L,8L,7L,5L,0L,1L,3L,5L,3L,0L,7L,1L,7L,9L,3L,7L,7L,4L,0L,6L,3L,3L,2L,6L,6L,5L,6L,7L,0L,3L,4L,1L,2L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177889Inst : IEnumerable<long>
{
public static readonly long[] Value=A177889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177889.Bytes);
public long this[int i]=>Value[i];

public static A177889Inst Instance=new A177889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177890
{
public static readonly long[] Value={ 0L,1L,16L,58L,140L,275L,476L,756L,1128L,1605L,2200L,2926L,3796L,4823L,6020L,7400L,8976L,10761L,12768L,15010L,17500L,20251L,23276L,26588L,30200L,34125L,38376L,42966L,47908L,53215L,58900L,64976L,71456L,78353L,85680L,93450L,101676L,110371L,119548L,129220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177890Inst : IEnumerable<long>
{
public static readonly long[] Value=A177890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177890.Bytes);
public long this[int i]=>Value[i];

public static A177890Inst Instance=new A177890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177891
{
public static readonly long[] Value={ 6L,9L,14L,15L,16L,18L,20L,22L,25L,33L,36L,38L,45L,46L,51L,52L,62L,68L,70L,72L,75L,80L,86L,87L,91L,93L,95L,99L,104L,105L,110L,116L,117L,118L,119L,130L,136L,141L,142L,143L,144L,145L,148L,154L,158L,159L,160L,162L,165L,166L,169L,183L,195L,196L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177891Inst : IEnumerable<long>
{
public static readonly long[] Value=A177891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177891.Bytes);
public long this[int i]=>Value[i];

public static A177891Inst Instance=new A177891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177892
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177892Inst : IEnumerable<long>
{
public static readonly long[] Value=A177892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177892.Bytes);
public long this[int i]=>Value[i];

public static A177892Inst Instance=new A177892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177893
{
public static readonly long[] Value={ 4L,0L,0L,1L,-80L,0L,0L,20L,1L,0L,11200L,0L,0L,0L,0L,60L,0L,0L,1L,-6272000L,0L,0L,-3136000L,0L,0L,78400L,0L,0L,2800L,0L,0L,140L,0L,0L,1L,-38635520000L,0L,0L,19317760000L,0L,0L,1448832000L,0L,0L,-17248000L,0L,0L,627200L,0L,0L,18480L,0L,0L,280L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177893Inst : IEnumerable<long>
{
public static readonly long[] Value=A177893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177893.Bytes);
public long this[int i]=>Value[i];

public static A177893Inst Instance=new A177893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177894
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,0L,-3L,-8L,-15L,-24L,-35L,-48L,-63L,-80L,4L,3L,0L,-5L,-12L,-21L,-32L,-45L,-60L,-77L,9L,8L,5L,0L,-7L,-16L,-27L,-40L,-55L,-72L,16L,15L,12L,7L,0L,-9L,-20L,-33L,-48L,-65L,25L,24L,21L,16L,9L,0L,-11L,-24L,-39L,-56L,36L,35L,32L,27L,20L,11L,0L,-13L,-28L,-45L,49L,48L,45L,40L,33L,24L,13L,0L,-15L,-32L,64L,63L,60L,55L,48L,39L,28L,15L,0L,-17L,81L,80L,77L,72L,65L,56L,45L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177894Inst : IEnumerable<long>
{
public static readonly long[] Value=A177894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177894.Bytes);
public long this[int i]=>Value[i];

public static A177894Inst Instance=new A177894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177895
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177895Inst : IEnumerable<long>
{
public static readonly long[] Value=A177895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177895.Bytes);
public long this[int i]=>Value[i];

public static A177895Inst Instance=new A177895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177896
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,4L,9L,6L,1L,9L,26L,26L,10L,1L,21L,75L,100L,60L,15L,1L,51L,216L,360L,295L,120L,21L,1L,127L,623L,1246L,1295L,735L,217L,28L,1L,323L,1800L,4200L,5292L,3864L,1624L,364L,36L,1L,835L,5211L,13896L,20580L,18396L,10080L,3276L,576L,45L,1L,2188L,15115L,45345L,77190L,81690L,55314L,23730L,6150L,870L,55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177896Inst : IEnumerable<long>
{
public static readonly long[] Value=A177896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177896.Bytes);
public long this[int i]=>Value[i];

public static A177896Inst Instance=new A177896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177897
{
public static readonly BigInteger[] Value={ 1L,255L,21845L,3342387L,286331153L,64424509455L,5519032976645L,844437815230467L,72340172838076673L,18446744073709551615UL,BigInteger.Parse("1567973246265311887445"),BigInteger.Parse("241781474574111093044019") };
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
public class A177897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177897Inst Instance=new A177897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177898
{
public static readonly long[] Value={ 1L,6L,4L,9L,7L,12L,10L,15L,13L,18L,16L,21L,19L,24L,22L,27L,25L,30L,28L,33L,31L,36L,34L,39L,37L,42L,40L,45L,43L,48L,46L,51L,49L,54L,52L,57L,55L,60L,58L,63L,61L,66L,64L,69L,67L,72L,70L,75L,73L,78L,76L,81L,79L,84L,82L,87L,85L,90L,88L,93L,91L,96L,94L,99L,97L,102L,100L,105L,103L,108L,106L,111L,109L,114L,112L,117L,115L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177898Inst : IEnumerable<long>
{
public static readonly long[] Value=A177898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177898.Bytes);
public long this[int i]=>Value[i];

public static A177898Inst Instance=new A177898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177899
{
public static readonly long[] Value={ 8L,16L,24L,27L,40L,48L,54L,56L,80L,81L,88L,104L,112L,120L,125L,135L,136L,152L,162L,168L,176L,184L,189L,208L,216L,232L,240L,248L,250L,264L,270L,272L,280L,296L,297L,304L,312L,328L,336L,343L,344L,351L,368L,375L,376L,378L,405L,408L,424L,432L,440L,456L,459L,464L,472L,488L,496L,512L,513L,520L,528L,536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177899Inst : IEnumerable<long>
{
public static readonly long[] Value=A177899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177899.Bytes);
public long this[int i]=>Value[i];

public static A177899Inst Instance=new A177899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177900
{
public static readonly long[] Value={ 0L,4L,0L,8L,21L,27L,39L,65L,57L,115L,32L,155L,63L,50L,129L,235L,265L,371L,305L,201L,98L,365L,237L,171L,245L,291L,485L,309L,325L,327L,128L,189L,279L,917L,1507L,1529L,242L,785L,489L,835L,865L,1211L,385L,605L,579L,965L,338L,2321L,669L,1115L,687L,1165L,399L,2629L,549L,1285L,595L,1841L,1025L,603L,1385L,715L,3809L,921L,1175L,939L,4121L,1655L,805L,1325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177900Inst : IEnumerable<long>
{
public static readonly long[] Value=A177900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177900.Bytes);
public long this[int i]=>Value[i];

public static A177900Inst Instance=new A177900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177901
{
public static readonly long[] Value={ 2L,3L,5L,14L,22L,27L,35L,95L,96L,197L,261L,5935L,7399L,8998L,11671L,17411L,108965L,165535L,258335L,549545L,1542194L,2064173L,4146167L,4594140L,5814278L,9242360L,21603225L,28563732L,40700787L,54528830L,252544447L,1430841730L,5042264463L,11012237562L,31774693500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177901Inst : IEnumerable<long>
{
public static readonly long[] Value=A177901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177901.Bytes);
public long this[int i]=>Value[i];

public static A177901Inst Instance=new A177901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177902
{
public static readonly long[] Value={ 1L,11L,12L,14L,18L,21L,23L,29L,31L,34L,37L,41L,51L,56L,61L,71L,81L,91L,111L,131L,157L,191L,211L,213L,219L,437L,511L,857L,1111L,1112L,1117L,1121L,1123L,1129L,1131L,1153L,1161L,1172L,1187L,1191L,1212L,1216L,1512L,1731L,2111L,2113L,2119L,2121L,2143L,2173L,2321L,2517L,2587L,2711L,3112L,3121L,3712L,4121L,4153L,4161L,4197L,5111L,5116L,5121L,5176L,5321L,5721L,6121L,7512L,8113L,8121L,8321L,8921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177902Inst : IEnumerable<long>
{
public static readonly long[] Value=A177902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177902.Bytes);
public long this[int i]=>Value[i];

public static A177902Inst Instance=new A177902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177903
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,4L,3L,3L,4L,4L,4L,3L,4L,4L,5L,5L,5L,5L,4L,4L,5L,4L,5L,6L,4L,4L,6L,5L,6L,5L,5L,5L,5L,5L,5L,5L,5L,5L,4L,5L,6L,7L,6L,6L,6L,6L,6L,5L,6L,5L,6L,6L,6L,6L,5L,6L,7L,6L,6L,6L,6L,6L,6L,6L,5L,6L,5L,7L,7L,6L,6L,7L,7L,6L,7L,6L,6L,6L,5L,5L,7L,6L,6L,6L,7L,7L,7L,6L,6L,6L,7L,7L,6L,7L,7L,7L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177903Inst : IEnumerable<long>
{
public static readonly long[] Value=A177903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177903.Bytes);
public long this[int i]=>Value[i];

public static A177903Inst Instance=new A177903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177904
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,3L,11L,19L,11L,41L,71L,41L,17L,43L,101L,23L,167L,97L,41L,61L,199L,43L,101L,7L,151L,37L,13L,67L,13L,31L,37L,3L,71L,37L,37L,29L,103L,13L,29L,29L,71L,43L,13L,127L,61L,67L,17L,29L,113L,53L,13L,179L,7L,199L,11L,31L,241L,283L,37L,17L,337L,23L,29L,389L,7L,17L,59L,83L,53L,13L,149L,43L,41L,233L,317L,197L,83L,199L,479L,761L,1439L,47L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177904Inst : IEnumerable<long>
{
public static readonly long[] Value=A177904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177904.Bytes);
public long this[int i]=>Value[i];

public static A177904Inst Instance=new A177904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177905
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,26L,42L,52L,68L,78L,84L,114L,156L,186L,204L,222L,228L,372L,444L,546L,798L,876L,884L,1092L,1218L,1252L,1302L,1378L,1428L,1482L,1554L,1596L,1806L,2418L,2436L,2604L,2652L,2756L,2886L,2964L,3108L,3534L,3606L,3612L,3756L,3876L,4134L,4218L,4836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177905Inst : IEnumerable<long>
{
public static readonly long[] Value=A177905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177905.Bytes);
public long this[int i]=>Value[i];

public static A177905Inst Instance=new A177905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177906
{
public static readonly long[] Value={ 1L,5L,1555L,9673655L,24181805L,90993505L,200928005L,28298980055L,36850702555L,62488609555L,141377087255L,150435008905L,367279622065L,2256331679135L,7521049172905L,18802586659555L,24599612913355L,54706615318945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177906Inst : IEnumerable<long>
{
public static readonly long[] Value=A177906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177906.Bytes);
public long this[int i]=>Value[i];

public static A177906Inst Instance=new A177906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177907
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,20L,24L,30L,40L,50L,57L,60L,68L,78L,100L,110L,111L,114L,120L,136L,150L,156L,200L,204L,220L,222L,228L,258L,300L,312L,330L,340L,390L,408L,440L,444L,456L,516L,550L,570L,600L,660L,680L,780L,820L,876L,888L,930L,1010L,1020L,1032L,1086L,1100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177907Inst : IEnumerable<long>
{
public static readonly long[] Value=A177907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177907.Bytes);
public long this[int i]=>Value[i];

public static A177907Inst Instance=new A177907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177908
{
public static readonly long[] Value={ 1L,7L,889L,2359L,299593L,2033143L,13549249L,42931441L,100170217L,188097287L,233727361L,310935751L,685169191L,1515836567L,3606045247L,4566096913L,5452293007L,6620620783L,12721617559L,13162910047L,24088984969L,29683374847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177908Inst : IEnumerable<long>
{
public static readonly long[] Value=A177908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177908.Bytes);
public long this[int i]=>Value[i];

public static A177908Inst Instance=new A177908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177909
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,20L,40L,68L,82L,110L,136L,164L,220L,328L,340L,410L,440L,610L,680L,772L,820L,1010L,1210L,1220L,1510L,1544L,1640L,2020L,2420L,2440L,2530L,2788L,3020L,3740L,3860L,4040L,4510L,4840L,5060L,5576L,6040L,6710L,6806L,7004L,7370L,7480L,7720L,8020L,9020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177909Inst : IEnumerable<long>
{
public static readonly long[] Value=A177909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177909.Bytes);
public long this[int i]=>Value[i];

public static A177909Inst Instance=new A177909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177910
{
public static readonly long[] Value={ 9L,3L,3L,7L,1L,6L,6L,3L,5L,8L,1L,4L,9L,1L,4L,0L,1L,1L,7L,5L,1L,4L,0L,5L,3L,0L,9L,1L,8L,0L,3L,1L,6L,6L,6L,5L,6L,7L,9L,0L,8L,2L,0L,1L,8L,8L,0L,7L,8L,7L,2L,9L,4L,3L,6L,6L,9L,2L,6L,2L,7L,4L,0L,3L,2L,4L,1L,6L,1L,0L,7L,2L,0L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177910Inst : IEnumerable<long>
{
public static readonly long[] Value=A177910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177910.Bytes);
public long this[int i]=>Value[i];

public static A177910Inst Instance=new A177910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177911
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,10L,12L,20L,30L,42L,60L,68L,78L,84L,114L,122L,156L,204L,210L,222L,228L,244L,340L,366L,390L,420L,444L,546L,570L,610L,732L,780L,798L,820L,876L,930L,1010L,1020L,1092L,1110L,1140L,1164L,1218L,1220L,1428L,1482L,1554L,1596L,1806L,1830L,1860L,2020L,2220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177911Inst : IEnumerable<long>
{
public static readonly long[] Value=A177911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177911.Bytes);
public long this[int i]=>Value[i];

public static A177911Inst Instance=new A177911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177912
{
public static readonly long[] Value={ 1L,11L,253L,11891L,77209L,768361L,1775807L,17666737L,36112967L,61488361L,83462929L,154261943L,173185331L,591303757L,830336639L,971656873L,2936791979L,4139054953L,5393125859L,8139710557L,8142849781L,45667873031L,53653880269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177912Inst : IEnumerable<long>
{
public static readonly long[] Value=A177912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177912.Bytes);
public long this[int i]=>Value[i];

public static A177912Inst Instance=new A177912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177913
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,10L,12L,14L,20L,28L,30L,34L,42L,60L,68L,70L,84L,102L,110L,114L,140L,170L,183L,204L,210L,220L,222L,228L,238L,330L,340L,366L,406L,420L,444L,476L,510L,570L,660L,714L,732L,770L,798L,812L,820L,876L,930L,942L,1010L,1020L,1110L,1140L,1190L,1218L,1428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177913Inst : IEnumerable<long>
{
public static readonly long[] Value=A177913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177913.Bytes);
public long this[int i]=>Value[i];

public static A177913Inst Instance=new A177913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177914
{
public static readonly long[] Value={ 1L,13L,2041L,8801L,1381757L,24355253L,249302027L,464754407L,2681233451L,16488506281L,16772956369L,39665616523L,72966441899L,168777472279L,388885239223L,420953651807L,2974921088191L,3487599163841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177914Inst : IEnumerable<long>
{
public static readonly long[] Value=A177914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177914.Bytes);
public long this[int i]=>Value[i];

public static A177914Inst Instance=new A177914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177915
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,14L,16L,28L,56L,68L,112L,136L,226L,272L,406L,452L,476L,812L,904L,952L,1582L,1624L,1808L,1904L,2056L,2758L,3164L,3248L,4112L,5516L,5956L,6328L,7684L,9316L,11032L,11912L,12656L,13804L,14392L,15368L,18632L,21512L,22064L,23824L,23954L,25144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177915Inst : IEnumerable<long>
{
public static readonly long[] Value=A177915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177915.Bytes);
public long this[int i]=>Value[i];

public static A177915Inst Instance=new A177915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177916
{
public static readonly long[] Value={ 1L,3L,5L,15L,21L,39L,55L,57L,105L,111L,155L,165L,195L,205L,219L,273L,285L,327L,399L,465L,505L,555L,609L,615L,741L,777L,903L,915L,1095L,1155L,1255L,1265L,1365L,1443L,1515L,1533L,1635L,1705L,1995L,2067L,2109L,2145L,2255L,2265L,2289L,2373L,2667L,2715L,2847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177916Inst : IEnumerable<long>
{
public static readonly long[] Value=A177916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177916.Bytes);
public long this[int i]=>Value[i];

public static A177916Inst Instance=new A177916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177917
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,16L,18L,20L,24L,30L,36L,40L,42L,48L,58L,60L,72L,78L,80L,84L,90L,110L,114L,116L,120L,126L,144L,156L,168L,174L,180L,210L,220L,222L,228L,232L,234L,240L,252L,290L,312L,330L,336L,342L,348L,360L,390L,420L,440L,444L,456L,464L,468L,504L,522L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177917Inst : IEnumerable<long>
{
public static readonly long[] Value=A177917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177917.Bytes);
public long this[int i]=>Value[i];

public static A177917Inst Instance=new A177917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177918
{
public static readonly long[] Value={ 1L,17L,343927L,1414961L,28626075991L,610559655569L,5417488064959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177918Inst : IEnumerable<long>
{
public static readonly long[] Value=A177918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177918.Bytes);
public long this[int i]=>Value[i];

public static A177918Inst Instance=new A177918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177919
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,10L,12L,18L,20L,30L,36L,42L,60L,68L,78L,84L,90L,110L,126L,156L,180L,204L,210L,220L,222L,234L,252L,294L,330L,340L,362L,381L,390L,420L,438L,444L,468L,546L,588L,612L,630L,654L,660L,666L,724L,762L,780L,820L,876L,882L,930L,990L,1010L,1014L,1020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177919Inst : IEnumerable<long>
{
public static readonly long[] Value=A177919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177919.Bytes);
public long this[int i]=>Value[i];

public static A177919Inst Instance=new A177919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177920
{
public static readonly long[] Value={ 1L,19L,7805561L,1432001198261L,3661225986659L,58130944174609L,187470481770989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177920Inst : IEnumerable<long>
{
public static readonly long[] Value=A177920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177920.Bytes);
public long this[int i]=>Value[i];

public static A177920Inst Instance=new A177920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177921
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177921Inst : IEnumerable<long>
{
public static readonly long[] Value=A177921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177921.Bytes);
public long this[int i]=>Value[i];

public static A177921Inst Instance=new A177921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177922
{
public static readonly long[] Value={ 0L,2L,3L,5L,7L,9L,9L,11L,16L,18L,18L,18L,22L,28L,30L,30L,25L,29L,36L,43L,45L,45L,39L,39L,45L,53L,61L,63L,63L,56L,49L,55L,64L,73L,82L,84L,84L,76L,68L,68L,76L,86L,96L,106L,108L,99L,90L,81L,89L,100L,111L,122L,133L,135L,135L,125L,115L,105L,105L,115L,127L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177922Inst : IEnumerable<long>
{
public static readonly long[] Value=A177922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177922.Bytes);
public long this[int i]=>Value[i];

public static A177922Inst Instance=new A177922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177923
{
public static readonly long[] Value={ 19L,13L,37L,23L,73L,19L,23L,23L,13L,59L,19L,13L,13L,5L,31L,7L,43L,3L,53L,11L,67L,131L,19L,31L,181L,11L,223L,83L,317L,89L,163L,569L,821L,1553L,109L,191L,109L,409L,709L,409L,509L,1627L,509L,23L,127L,659L,809L,29L,499L,191L,719L,1409L,773L,967L,67L,139L,23L,229L,23L,11L,263L,11L,19L,293L,19L,331L,643L,331L,29L,59L,419L,13L,491L,71L,23L,13L,107L,13L,19L,139L,19L,59L,31L,109L,199L,113L,421L,733L,181L,89L,59L,47L,13L,17L,11L,41L,23L,5L,23L,17L,5L,5L,3L,13L,7L,23L,43L,73L,139L,17L,229L,11L,257L,71L,113L,7L,191L,311L,509L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177923Inst : IEnumerable<long>
{
public static readonly long[] Value=A177923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177923.Bytes);
public long this[int i]=>Value[i];

public static A177923Inst Instance=new A177923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177924
{
public static readonly long[] Value={ 1L,4L,3L,3L,0L,2L,5L,0L,3L,4L,1L,1L,5L,2L,2L,3L,6L,6L,5L,9L,6L,0L,6L,1L,1L,9L,5L,3L,4L,6L,6L,7L,8L,7L,4L,7L,3L,1L,1L,5L,6L,4L,8L,9L,9L,1L,4L,1L,0L,3L,8L,9L,4L,9L,4L,8L,8L,5L,4L,9L,3L,5L,1L,7L,6L,7L,4L,0L,2L,9L,5L,0L,7L,6L,3L,9L,3L,6L,2L,7L,6L,0L,8L,7L,3L,5L,1L,8L,6L,9L,4L,3L,6L,9L,8L,2L,6L,4L,4L,1L,4L,6L,5L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177924Inst : IEnumerable<long>
{
public static readonly long[] Value=A177924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177924.Bytes);
public long this[int i]=>Value[i];

public static A177924Inst Instance=new A177924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177925
{
public static readonly long[] Value={ 5L,2L,2L,4L,9L,4L,0L,1L,9L,1L,0L,4L,5L,2L,5L,2L,5L,2L,9L,3L,7L,9L,4L,2L,6L,9L,3L,9L,4L,1L,4L,0L,0L,9L,8L,4L,9L,4L,4L,7L,6L,3L,4L,3L,5L,1L,8L,9L,8L,1L,8L,1L,1L,7L,1L,3L,5L,8L,7L,6L,3L,6L,9L,8L,9L,7L,4L,5L,6L,5L,2L,4L,2L,7L,8L,0L,4L,3L,1L,4L,6L,0L,8L,9L,1L,7L,0L,4L,6L,8L,8L,4L,7L,1L,0L,2L,8L,0L,7L,2L,2L,0L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177925Inst : IEnumerable<long>
{
public static readonly long[] Value=A177925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177925.Bytes);
public long this[int i]=>Value[i];

public static A177925Inst Instance=new A177925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177926
{
public static readonly BigInteger[] Value={ 1L,4L,576L,518400L,13168189440000L,229442532802560000L,BigInteger.Parse("437763136697395052544000000"),BigInteger.Parse("40990389067797283140009984000000"),BigInteger.Parse("1263377636044591724886240423994982400000000"),BigInteger.Parse("92956902680071188234494975268405495542386262016000000000000") };
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
public class A177926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177926Inst Instance=new A177926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177927
{
public static readonly long[] Value={ 4L,9L,10L,22L,24L,25L,27L,34L,42L,46L,55L,58L,60L,72L,78L,81L,82L,85L,94L,105L,106L,114L,115L,118L,121L,126L,128L,132L,142L,145L,150L,166L,178L,180L,186L,187L,192L,195L,202L,204L,205L,214L,216L,222L,224L,226L,231L,234L,235L,243L,253L,256L,258L,262L,265L,274L,276L,285L,289L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177927Inst : IEnumerable<long>
{
public static readonly long[] Value=A177927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177927.Bytes);
public long this[int i]=>Value[i];

public static A177927Inst Instance=new A177927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177928
{
public static readonly long[] Value={ 1L,2L,3L,9L,27L,33L,66L,99L,123L,246L,271L,333L,351L,407L,429L,462L,481L,518L,546L,567L,666L,693L,702L,715L,777L,814L,819L,924L,936L,999L,1434L,2151L,2868L,3333L,4521L,4818L,6666L,7227L,7373L,7535L,8631L,9042L,9999L,33333L,53658L,54546L,66666L,80487L,81819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177928Inst : IEnumerable<long>
{
public static readonly long[] Value=A177928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177928.Bytes);
public long this[int i]=>Value[i];

public static A177928Inst Instance=new A177928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177929
{
public static readonly long[] Value={ 4L,6L,10L,12L,22L,24L,28L,30L,58L,60L,118L,120L,126L,130L,132L,138L,274L,276L,280L,282L,562L,564L,568L,570L,1138L,1140L,1146L,1150L,1152L,2302L,2304L,2308L,2310L,4618L,4620L,4650L,9298L,9300L,9316L,9318L,9324L,9328L,9330L,9336L,9340L,9342L,18682L,18684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177929Inst : IEnumerable<long>
{
public static readonly long[] Value=A177929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177929.Bytes);
public long this[int i]=>Value[i];

public static A177929Inst Instance=new A177929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177930
{
public static readonly long[] Value={ 3L,5L,3L,11L,3L,5L,3L,29L,3L,59L,3L,7L,5L,3L,7L,137L,3L,5L,3L,281L,3L,5L,3L,569L,3L,7L,5L,3L,1151L,3L,5L,3L,2309L,3L,31L,4649L,3L,17L,3L,7L,5L,3L,7L,5L,3L,9341L,3L,5L,3L,11L,3L,59L,3L,29L,3L,19L,7L,5L,3L,7L,19L,5L,3L,7L,109L,5L,3L,61L,7L,79L,5L,3L,13L,5L,3L,19139L,3L,101L,3L,7L,13L,11L,3L,71L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177930Inst : IEnumerable<long>
{
public static readonly long[] Value=A177930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177930.Bytes);
public long this[int i]=>Value[i];

public static A177930Inst Instance=new A177930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177931
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,16L,20L,24L,29L,33L,36L,46L,76L,99L,108L,132L,179L,213L,217L,251L,286L,397L,431L,439L,445L,471L,535L,658L,677L,702L,780L,889L,1227L,1296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177931Inst : IEnumerable<long>
{
public static readonly long[] Value=A177931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177931.Bytes);
public long this[int i]=>Value[i];

public static A177931Inst Instance=new A177931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177932
{
public static readonly long[] Value={ 3L,5L,11L,29L,59L,137L,281L,569L,1151L,2309L,4649L,9341L,19139L,38711L,77489L,155381L,311681L,624047L,1248101L,2497421L,4998941L,10002437L,20005289L,40010609L,80021309L,160043909L,320090921L,640196267L,1280392739L,2560793201L,5121618767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177932Inst : IEnumerable<long>
{
public static readonly long[] Value=A177932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177932.Bytes);
public long this[int i]=>Value[i];

public static A177932Inst Instance=new A177932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177933
{
public static readonly long[] Value={ 1L,4L,3L,3L,1L,2L,7L,4L,2L,6L,7L,2L,2L,2L,9L,1L,1L,3L,0L,6L,9L,3L,4L,5L,3L,5L,5L,4L,9L,7L,5L,2L,3L,5L,5L,5L,7L,3L,6L,9L,3L,4L,0L,0L,8L,4L,0L,6L,9L,9L,9L,7L,1L,4L,6L,6L,5L,9L,6L,4L,6L,7L,0L,3L,1L,7L,6L,1L,3L,7L,8L,0L,1L,6L,6L,3L,2L,3L,6L,8L,1L,2L,3L,2L,5L,7L,5L,9L,2L,8L,7L,6L,3L,6L,4L,5L,9L,6L,2L,1L,6L,8L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177933Inst : IEnumerable<long>
{
public static readonly long[] Value=A177933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177933.Bytes);
public long this[int i]=>Value[i];

public static A177933Inst Instance=new A177933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177934
{
public static readonly long[] Value={ 2L,6L,6L,8L,6L,5L,0L,6L,6L,6L,6L,6L,6L,5L,8L,3L,3L,9L,5L,2L,8L,7L,2L,3L,9L,6L,2L,5L,7L,5L,1L,6L,2L,6L,1L,3L,0L,0L,5L,2L,1L,5L,9L,5L,9L,8L,0L,8L,1L,3L,7L,4L,6L,5L,9L,5L,8L,9L,9L,4L,3L,9L,9L,1L,5L,9L,0L,9L,6L,5L,3L,5L,0L,6L,7L,8L,3L,5L,1L,1L,4L,2L,0L,4L,4L,2L,3L,3L,6L,9L,1L,0L,8L,2L,1L,4L,5L,3L,0L,0L,8L,4L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177934Inst : IEnumerable<long>
{
public static readonly long[] Value=A177934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177934.Bytes);
public long this[int i]=>Value[i];

public static A177934Inst Instance=new A177934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177935
{
public static readonly long[] Value={ 1L,0L,3L,4L,4L,0L,8L,0L,4L,3L,2L,7L,8L,8L,6L,0L,0L,4L,6L,9L,7L,3L,8L,5L,9L,9L,4L,4L,2L,6L,2L,6L,9L,9L,7L,3L,6L,8L,3L,0L,2L,0L,2L,2L,3L,7L,4L,9L,7L,1L,6L,8L,7L,9L,4L,5L,6L,7L,7L,1L,1L,5L,3L,5L,7L,6L,0L,0L,5L,9L,0L,0L,3L,7L,4L,1L,9L,3L,7L,0L,8L,7L,9L,5L,1L,7L,9L,5L,2L,5L,5L,0L,3L,2L,8L,5L,3L,2L,7L,4L,8L,4L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177935Inst : IEnumerable<long>
{
public static readonly long[] Value=A177935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177935.Bytes);
public long this[int i]=>Value[i];

public static A177935Inst Instance=new A177935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177936
{
public static readonly long[] Value={ 1L,3L,3L,7L,9L,0L,8L,8L,1L,6L,0L,2L,5L,9L,6L,5L,2L,0L,1L,5L,0L,2L,6L,8L,8L,1L,3L,5L,4L,7L,8L,6L,3L,0L,7L,0L,5L,7L,9L,8L,1L,4L,0L,4L,6L,2L,9L,1L,7L,5L,3L,2L,8L,8L,5L,1L,3L,2L,1L,1L,2L,4L,8L,6L,3L,3L,7L,7L,6L,1L,3L,6L,0L,2L,8L,9L,6L,2L,3L,9L,5L,0L,7L,8L,3L,6L,0L,1L,3L,8L,1L,7L,6L,1L,7L,4L,4L,4L,2L,8L,4L,9L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177936Inst : IEnumerable<long>
{
public static readonly long[] Value=A177936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177936.Bytes);
public long this[int i]=>Value[i];

public static A177936Inst Instance=new A177936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177937
{
public static readonly long[] Value={ 1L,3L,3L,3L,8L,2L,9L,0L,7L,4L,5L,0L,6L,9L,2L,4L,9L,6L,8L,9L,1L,2L,1L,0L,6L,3L,0L,3L,3L,1L,9L,8L,8L,8L,5L,1L,8L,9L,1L,0L,0L,3L,1L,0L,9L,4L,8L,1L,6L,2L,9L,7L,9L,1L,9L,0L,5L,0L,2L,3L,7L,1L,8L,7L,8L,3L,7L,6L,2L,9L,4L,1L,3L,8L,2L,9L,0L,1L,1L,5L,6L,2L,8L,3L,3L,4L,5L,0L,1L,1L,1L,8L,4L,3L,2L,9L,4L,2L,9L,9L,6L,7L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177937Inst : IEnumerable<long>
{
public static readonly long[] Value=A177937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177937.Bytes);
public long this[int i]=>Value[i];

public static A177937Inst Instance=new A177937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177938
{
public static readonly long[] Value={ 1L,1L,1L,6L,5L,1L,60L,47L,12L,1L,840L,638L,179L,22L,1L,15120L,11274L,3325L,485L,35L,1L,332640L,245004L,74524L,11985L,1075L,51L,1L,8648640L,6314664L,1961470L,336049L,34300L,2086L,70L,1L,259459200L,188204400L,59354028L,10630508L,1182769L,83720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177938Inst : IEnumerable<long>
{
public static readonly long[] Value=A177938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177938.Bytes);
public long this[int i]=>Value[i];

public static A177938Inst Instance=new A177938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177939
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,30L,30L,1L,1L,336L,3024L,336L,1L,1L,5040L,665280L,665280L,5040L,1L,1L,95040L,259459200L,4151347200L,259459200L,95040L,1L,1L,2162160L,158789030400L,60339831552000L,60339831552000L,158789030400L,2162160L,1L,1L,57657600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177939Inst : IEnumerable<long>
{
public static readonly long[] Value=A177939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177939.Bytes);
public long this[int i]=>Value[i];

public static A177939Inst Instance=new A177939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177940
{
public static readonly long[] Value={ 2L,1L,3L,4L,8L,3L,1L,4L,6L,0L,6L,7L,4L,1L,5L,7L,3L,0L,3L,3L,7L,0L,7L,8L,6L,5L,1L,6L,8L,5L,3L,9L,3L,2L,5L,8L,4L,2L,6L,9L,6L,6L,2L,9L,2L,1L,3L,4L,8L,3L,1L,4L,6L,0L,6L,7L,4L,1L,5L,7L,3L,0L,3L,3L,7L,0L,7L,8L,6L,5L,1L,6L,8L,5L,3L,9L,3L,2L,5L,8L,4L,2L,6L,9L,6L,6L,2L,9L,2L,1L,3L,4L,8L,3L,1L,4L,6L,0L,6L,7L,4L,1L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177940Inst : IEnumerable<long>
{
public static readonly long[] Value=A177940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177940.Bytes);
public long this[int i]=>Value[i];

public static A177940Inst Instance=new A177940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177941
{
public static readonly long[] Value={ 5L,7L,9L,15L,27L,31L,33L,37L,39L,75L,81L,159L,165L,327L,331L,333L,337L,339L,349L,351L,699L,715L,717L,721L,723L,727L,729L,745L,747L,751L,753L,757L,759L,1515L,1531L,1533L,1537L,1539L,1561L,1563L,1567L,1569L,3135L,3147L,3151L,3153L,3157L,3159L,3165L,6327L,6331L,6333L,6337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177941Inst : IEnumerable<long>
{
public static readonly long[] Value=A177941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177941.Bytes);
public long this[int i]=>Value[i];

public static A177941Inst Instance=new A177941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177942
{
public static readonly long[] Value={ 3L,3L,7L,13L,5L,3L,5L,3L,37L,7L,79L,7L,163L,5L,3L,5L,3L,11L,3L,349L,17L,3L,5L,3L,5L,3L,17L,3L,5L,3L,5L,3L,757L,17L,3L,5L,3L,23L,3L,5L,3L,1567L,13L,5L,3L,5L,3L,7L,3163L,5L,3L,5L,3L,17L,3L,5L,3L,5L,3L,23L,3L,5L,3L,37L,7L,17L,3L,7L,23L,3L,13L,7L,5L,3L,5L,3L,7L,11L,3L,5L,3L,5L,3L,6547L,7L,13099L,7L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177942Inst : IEnumerable<long>
{
public static readonly long[] Value=A177942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177942.Bytes);
public long this[int i]=>Value[i];

public static A177942Inst Instance=new A177942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177943
{
public static readonly long[] Value={ 1L,3L,4L,9L,11L,13L,20L,33L,42L,49L,84L,86L,107L,109L,123L,128L,191L,295L,296L,318L,330L,337L,396L,453L,481L,616L,663L,771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177943Inst : IEnumerable<long>
{
public static readonly long[] Value=A177943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177943.Bytes);
public long this[int i]=>Value[i];

public static A177943Inst Instance=new A177943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177944
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,9L,9L,1L,1L,16L,26L,16L,1L,1L,25L,55L,55L,25L,1L,1L,36L,99L,134L,99L,36L,1L,1L,49L,161L,273L,273L,161L,49L,1L,1L,64L,244L,496L,622L,496L,244L,64L,1L,1L,81L,351L,831L,1251L,1251L,831L,351L,81L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177944Inst : IEnumerable<long>
{
public static readonly long[] Value=A177944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177944.Bytes);
public long this[int i]=>Value[i];

public static A177944Inst Instance=new A177944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177945
{
public static readonly long[] Value={ 3L,7L,13L,37L,79L,163L,349L,757L,1567L,3163L,6547L,13099L,26497L,52999L,106273L,212557L,426889L,855427L,1710853L,3421903L,6845869L,13691767L,27385087L,54771007L,109542907L,219096259L,438203677L,876417229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177945Inst : IEnumerable<long>
{
public static readonly long[] Value=A177945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177945.Bytes);
public long this[int i]=>Value[i];

public static A177945Inst Instance=new A177945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177946
{
public static readonly BigInteger[] Value={ 2L,3L,20L,210L,332640L,8648640L,70572902400L,3016991577600L,71241227785728000L,BigInteger.Parse("2436552577639909048320000"),BigInteger.Parse("205999445200465037721600000"),BigInteger.Parse("28734252852655074735274328064000000"),BigInteger.Parse("5372155913332392772506888374845440000000") };
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
public class A177946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177946Inst Instance=new A177946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177947
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,8L,8L,1L,1L,13L,22L,13L,1L,1L,19L,45L,45L,19L,1L,1L,26L,79L,110L,79L,26L,1L,1L,34L,126L,224L,224L,126L,34L,1L,1L,43L,188L,406L,518L,406L,188L,43L,1L,1L,53L,267L,678L,1050L,1050L,678L,267L,53L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177947Inst : IEnumerable<long>
{
public static readonly long[] Value=A177947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177947.Bytes);
public long this[int i]=>Value[i];

public static A177947Inst Instance=new A177947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177948
{
public static readonly long[] Value={ 1L,10L,14L,25L,104L,116L,124L,136L,145L,149L,151L,157L,161L,167L,173L,184L,188L,190L,205L,224L,245L,251L,266L,268L,272L,280L,287L,289L,310L,1006L,1024L,1036L,1060L,1070L,1124L,1150L,1216L,1220L,1240L,1244L,1250L,1286L,1306L,1310L,1336L,1366L,1376L,1406L,1417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177948Inst : IEnumerable<long>
{
public static readonly long[] Value=A177948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177948.Bytes);
public long this[int i]=>Value[i];

public static A177948Inst Instance=new A177948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177949
{
public static readonly long[] Value={ 15684L,15685L,15686L,15687L,15688L,15689L,15690L,15691L,15692L,15693L,15694L,15695L,15696L,15697L,15698L,15699L,15700L,15701L,15702L,15703L,15704L,15705L,15706L,15707L,15708L,15709L,15710L,15711L,15712L,15713L,15714L,15715L,15716L,15717L,15718L,15719L,15720L,15721L,15722L,15723L,15724L,15725L,15726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177949Inst : IEnumerable<long>
{
public static readonly long[] Value=A177949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177949.Bytes);
public long this[int i]=>Value[i];

public static A177949Inst Instance=new A177949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177950
{
public static readonly long[] Value={ 1L,2L,3L,9L,11L,22L,26L,33L,48L,66L,87L,99L,101L,111L,117L,121L,202L,212L,216L,264L,273L,288L,297L,307L,333L,484L,513L,528L,666L,783L,819L,836L,999L,1001L,1111L,1323L,1331L,1452L,1474L,1602L,2002L,2178L,2285L,2622L,2636L,3333L,4884L,4961L,6666L,7161L,7575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177950Inst : IEnumerable<long>
{
public static readonly long[] Value=A177950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177950.Bytes);
public long this[int i]=>Value[i];

public static A177950Inst Instance=new A177950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177951
{
public static readonly long[] Value={ 4L,1L,3L,2L,8L,7L,7L,4L,4L,9L,3L,6L,6L,29L,10L,5L,5L,5L,8L,8L,8L,8L,28L,28L,7L,7L,7L,7L,30L,30L,30L,4L,13L,13L,27L,27L,9L,9L,9L,9L,9L,9L,9L,19L,11L,11L,11L,11L,11L,11L,6L,6L,6L,6L,26L,26L,6L,6L,31L,23L,31L,15L,15L,29L,15L,29L,29L,29L,15L,15L,10L,10L,10L,10L,10L,10L,10L,10L,10L,21L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177951Inst : IEnumerable<long>
{
public static readonly long[] Value=A177951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177951.Bytes);
public long this[int i]=>Value[i];

public static A177951Inst Instance=new A177951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177952
{
public static readonly long[] Value={ 0L,0L,7L,13L,86L,293L,1212L,4699L,17380L,60623L,203799L,664953L,2135649L,6800449L,21572602L,68311990L,216144075L,683666674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177952Inst : IEnumerable<long>
{
public static readonly long[] Value=A177952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177952.Bytes);
public long this[int i]=>Value[i];

public static A177952Inst Instance=new A177952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177953
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,8L,3L,4L,1L,16L,4L,11L,4L,1L,32L,5L,26L,10L,6L,1L,64L,6L,57L,20L,22L,6L,128L,7L,120L,35L,64L,21L,8L,1L,256L,8L,247L,56L,163L,56L,37L,8L,1L,512L,9L,502L,84L,382L,126L,130L,36L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177953Inst : IEnumerable<long>
{
public static readonly long[] Value=A177953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177953.Bytes);
public long this[int i]=>Value[i];

public static A177953Inst Instance=new A177953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177954
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,3L,5L,4L,1L,3L,6L,7L,4L,1L,4L,11L,17L,14L,6L,1L,4L,12L,22L,24L,16L,6L,1L,5L,19L,43L,59L,51L,27L,8L,1L,5L,20L,50L,80L,86L,62L,29L,8L,1L,6L,19L,86L,164L,212L,188L,113L,44L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177954Inst : IEnumerable<long>
{
public static readonly long[] Value=A177954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177954.Bytes);
public long this[int i]=>Value[i];

public static A177954Inst Instance=new A177954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177955
{
public static readonly long[] Value={ 3L,10L,18L,33L,57L,83L,114L,149L,197L,260L,340L,439L,559L,683L,810L,953L,1121L,1316L,1531L,1755L,1997L,2252L,2540L,2863L,3205L,3565L,3964L,4404L,4887L,5398L,5926L,6501L,7125L,7800L,8528L,9311L,10151L,11050L,12010L,13009L,14032L,15120L,16275L,17499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177955Inst : IEnumerable<long>
{
public static readonly long[] Value=A177955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177955.Bytes);
public long this[int i]=>Value[i];

public static A177955Inst Instance=new A177955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177956
{
public static readonly long[] Value={ 2L,2L,4L,60L,28L,2L,234L,2L,10L,186L,32L,8L,22L,6L,76L,330L,78L,62L,462L,88L,1416L,1440L,150L,40L,308L,144L,260L,42L,492L,2320L,132L,328L,838L,696L,736L,234L,56L,2786L,172L,382L,4872L,128L,4752L,7292L,826L,1856L,3960L,1124L,424L,612L,2052L,430L,1104L,280L,78L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177956Inst : IEnumerable<long>
{
public static readonly long[] Value=A177956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177956.Bytes);
public long this[int i]=>Value[i];

public static A177956Inst Instance=new A177956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177957
{
public static readonly long[] Value={ 1L,5L,6L,5L,6L,9L,6L,8L,0L,7L,8L,5L,7L,8L,3L,4L,1L,1L,1L,9L,8L,4L,3L,1L,4L,9L,9L,3L,4L,0L,4L,4L,6L,5L,8L,4L,9L,7L,4L,9L,8L,1L,5L,9L,8L,3L,8L,0L,9L,6L,3L,2L,6L,8L,2L,5L,5L,9L,9L,5L,5L,7L,3L,7L,2L,3L,3L,0L,7L,7L,2L,3L,0L,3L,8L,5L,1L,0L,3L,1L,1L,1L,0L,6L,8L,2L,7L,6L,7L,1L,4L,8L,1L,8L,3L,8L,5L,6L,5L,9L,6L,9L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177957Inst : IEnumerable<long>
{
public static readonly long[] Value=A177957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177957.Bytes);
public long this[int i]=>Value[i];

public static A177957Inst Instance=new A177957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177958
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,12L,18L,9L,27L,36L,24L,8L,16L,32L,40L,10L,20L,30L,15L,45L,54L,42L,7L,14L,21L,28L,35L,49L,56L,48L,60L,50L,25L,75L,90L,63L,70L,77L,11L,22L,33L,44L,55L,66L,72L,64L,80L,88L,96L,78L,13L,26L,39L,52L,65L,91L,84L,98L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177958Inst : IEnumerable<long>
{
public static readonly long[] Value=A177958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177958.Bytes);
public long this[int i]=>Value[i];

public static A177958Inst Instance=new A177958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177959
{
public static readonly long[] Value={ 1L,3L,4L,7L,10L,12L,14L,17L,22L,28L,31L,34L,38L,41L,46L,51L,58L,60L,63L,68L,69L,77L,80L,86L,93L,98L,101L,105L,107L,110L,127L,126L,132L,135L,145L,148L,154L,159L,164L,170L,176L,178L,190L,188L,193L,196L,208L,222L,224L,226L,230L,238L,238L,250L,250L,258L,264L,267L,272L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177959Inst : IEnumerable<long>
{
public static readonly long[] Value=A177959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177959.Bytes);
public long this[int i]=>Value[i];

public static A177959Inst Instance=new A177959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177960
{
public static readonly long[] Value={ 3L,5L,17L,51L,257L,1285L,3855L,13107L,65537L,196611L,983055L,1114129L,5570645L,16711935L,50529027L,84215045L,858993459L,4294967297L,21474836485L,219043332147L,365072220245L,1103806595329L,3311419785987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177960Inst : IEnumerable<long>
{
public static readonly long[] Value=A177960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177960.Bytes);
public long this[int i]=>Value[i];

public static A177960Inst Instance=new A177960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177961
{
public static readonly long[] Value={ 2L,4L,6L,5L,7L,12L,8L,10L,18L,11L,13L,14L,4L,16L,30L,17L,4L,21L,20L,22L,42L,23L,25L,27L,5L,28L,29L,4L,31L,60L,32L,4L,36L,35L,37L,72L,38L,5L,43L,41L,43L,44L,4L,46L,48L,5L,4L,51L,50L,52L,102L,53L,55L,108L,56L,58L,59L,4L,5L,9L,7L,4L,66L,65L,67L,69L,5L,70L,138L,71L,7L,8L,4L,76L,150L,77L,4L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177961Inst : IEnumerable<long>
{
public static readonly long[] Value=A177961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177961.Bytes);
public long this[int i]=>Value[i];

public static A177961Inst Instance=new A177961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177962
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,3L,2L,2L,1L,3L,3L,2L,2L,4L,1L,2L,1L,3L,6L,1L,2L,2L,2L,6L,2L,2L,4L,6L,3L,3L,2L,5L,1L,3L,2L,3L,4L,2L,4L,2L,2L,12L,2L,3L,1L,2L,6L,3L,2L,6L,10L,2L,3L,3L,2L,6L,5L,1L,2L,12L,2L,2L,2L,4L,12L,2L,3L,2L,2L,2L,6L,3L,3L,6L,6L,4L,6L,2L,10L,6L,2L,5L,6L,2L,3L,3L,2L,2L,20L,1L,2L,2L,3L,1L,12L,1L,2L,6L,12L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177962Inst : IEnumerable<long>
{
public static readonly long[] Value=A177962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177962.Bytes);
public long this[int i]=>Value[i];

public static A177962Inst Instance=new A177962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177963
{
public static readonly BigInteger[] Value={ 1L,4L,576L,1625702400L,13168189440000L,BigInteger.Parse("7600054456551997440000"),BigInteger.Parse("437763136697395052544000000"),BigInteger.Parse("5919012181389927685417441689600000000"),BigInteger.Parse("162644002617632464507038883409628607021056000000000000") };
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
public class A177963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177963Inst Instance=new A177963Inst();

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