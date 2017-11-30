using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A285978
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285978Inst : IEnumerable<long>
{
public static readonly long[] Value=A285978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285978.Bytes);
public long this[int i]=>Value[i];

public static A285978Inst Instance=new A285978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285979
{
public static readonly long[] Value={ 1L,4L,11L,14L,18L,24L,31L,37L,41L,44L,51L,54L,58L,64L,68L,71L,78L,84L,91L,94L,98L,104L,111L,117L,121L,124L,131L,137L,144L,147L,151L,157L,161L,164L,171L,174L,178L,184L,191L,197L,201L,204L,211L,214L,218L,224L,228L,231L,238L,244L,251L,254L,258L,264L,268L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285979Inst : IEnumerable<long>
{
public static readonly long[] Value=A285979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285979.Bytes);
public long this[int i]=>Value[i];

public static A285979Inst Instance=new A285979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285980
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,8L,9L,10L,12L,13L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,43L,45L,46L,47L,48L,49L,50L,52L,53L,55L,56L,57L,59L,60L,61L,62L,63L,65L,66L,67L,69L,70L,72L,73L,74L,75L,76L,77L,79L,80L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285980Inst : IEnumerable<long>
{
public static readonly long[] Value=A285980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285980.Bytes);
public long this[int i]=>Value[i];

public static A285980Inst Instance=new A285980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285981
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,10L,20L,44L,67L,149L,277L,528L,959L,1673L,3107L,5572L,9992L,17801L,31647L,55379L,98445L,173288L,305355L,536709L,943353L,1655316L,2900221L,5088098L,8916905L,15624332L,27368888L,47935241L,83939143L,146974040L,257277523L,450432510L,788487147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285981Inst : IEnumerable<long>
{
public static readonly long[] Value=A285981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285981.Bytes);
public long this[int i]=>Value[i];

public static A285981Inst Instance=new A285981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285982
{
public static readonly long[] Value={ 1L,1L,2L,0L,3L,0L,0L,0L,5L,0L,6L,0L,0L,0L,8L,0L,9L,0L,0L,0L,11L,0L,0L,0L,0L,0L,14L,0L,15L,0L,0L,0L,0L,0L,18L,0L,0L,0L,20L,0L,21L,0L,0L,0L,23L,0L,0L,0L,0L,0L,26L,0L,0L,0L,0L,0L,29L,0L,30L,0L,0L,0L,0L,0L,33L,0L,0L,0L,35L,0L,36L,0L,0L,0L,0L,0L,39L,0L,0L,0L,41L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285982Inst : IEnumerable<long>
{
public static readonly long[] Value=A285982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285982.Bytes);
public long this[int i]=>Value[i];

public static A285982Inst Instance=new A285982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285983
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,19L,23L,37L,47L,59L,61L,67L,79L,89L,103L,139L,173L,191L,199L,269L,271L,277L,293L,349L,353L,383L,409L,431L,433L,439L,541L,557L,643L,677L,709L,757L,769L,863L,887L,911L,929L,991L,1039L,1087L,1109L,1123L,1129L,1153L,1181L,1187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285983Inst : IEnumerable<long>
{
public static readonly long[] Value=A285983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285983.Bytes);
public long this[int i]=>Value[i];

public static A285983Inst Instance=new A285983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285984
{
public static readonly BigInteger[] Value={ 0L,110L,374L,107184L,363264L,103968854L,352366190L,100849681680L,341794841520L,97824087261230L,331540643908694L,94889263793711904L,321594082796592144L,BigInteger.Parse("92042488055813286134"),BigInteger.Parse("311945928772050471470"),BigInteger.Parse("89281118524875093838560"),BigInteger.Parse("302587229314806160734240"),BigInteger.Parse("86602592926640785210117550") };
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
public class A285984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285984Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285984.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285984.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285984Inst Instance=new A285984Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285985
{
public static readonly BigInteger[] Value={ 0L,9L,225L,14400L,278784L,16769025L,322382025L,19356600384L,372051201600L,22337675375625L,429347532814209L,25777663981977600L,495466706924481600L,BigInteger.Parse("29747402099825117409"),BigInteger.Parse("571768151330225342025"),BigInteger.Parse("34328476252406392070400"),BigInteger.Parse("659819951198501829398784"),BigInteger.Parse("39615031848108328736769225"),BigInteger.Parse("761431651915943270106720225"),BigInteger.Parse("45715712424248689455481003584"),BigInteger.Parse("878691466491082103705616000000") };
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
public class A285985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285985.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285985Inst Instance=new A285985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285986
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,12L,13L,14L,15L,16L,21L,22L,23L,24L,25L,30L,31L,32L,36L,42L,43L,44L,45L,46L,47L,48L,56L,57L,58L,59L,60L,61L,62L,63L,64L,72L,80L,81L,90L,91L,92L,93L,94L,95L,96L,97L,98L,114L,117L,118L,120L,121L,136L,137L,138L,141L,144L,156L,157L,158L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285986Inst : IEnumerable<long>
{
public static readonly long[] Value=A285986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285986.Bytes);
public long this[int i]=>Value[i];

public static A285986Inst Instance=new A285986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285987
{
public static readonly long[] Value={ 1L,5L,19L,51L,197L,901L,2038L,5839L,13476L,18517L,36993L,60544L,60557L,60555L,60553L,705691L,705758L,2528254L,4762881L,5645512L,5645535L,20250250L,20250249L,26733097L,66978018L,66978001L,66978016L,66978065L,66978193L,133956385L,187142781L,589907497L,1018886425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285987Inst : IEnumerable<long>
{
public static readonly long[] Value=A285987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285987.Bytes);
public long this[int i]=>Value[i];

public static A285987Inst Instance=new A285987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285988
{
public static readonly long[] Value={ 1L,-2L,-6L,-4L,22L,72L,92L,-48L,-522L,-1294L,-1624L,300L,6948L,19032L,30192L,20432L,-45578L,-202788L,-437178L,-599460L,-311112L,1038624L,4023532L,8423280L,11892004L,8429270L,-12073032L,-60747944L,-139842736L,-223644552L,-232762256L,-15050944L,636838518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285988Inst : IEnumerable<long>
{
public static readonly long[] Value=A285988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285988.Bytes);
public long this[int i]=>Value[i];

public static A285988Inst Instance=new A285988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286247
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,3L,7L,5L,0L,10L,11L,0L,0L,0L,3L,16L,8L,5L,0L,0L,21L,22L,0L,0L,0L,0L,0L,3L,29L,12L,0L,14L,0L,0L,0L,36L,37L,0L,8L,0L,0L,0L,0L,0L,10L,46L,17L,0L,0L,5L,0L,0L,0L,0L,21L,56L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,67L,23L,12L,19L,0L,27L,0L,0L,0L,0L,0L,78L,79L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,92L,30L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,21L,106L,0L,17L,0L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286247Inst : IEnumerable<long>
{
public static readonly long[] Value=A286247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286247.Bytes);
public long this[int i]=>Value[i];

public static A286247Inst Instance=new A286247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286248
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,3L,7L,0L,5L,10L,11L,0L,0L,0L,3L,16L,0L,0L,8L,5L,21L,22L,0L,0L,0L,0L,0L,3L,29L,0L,0L,0L,12L,0L,14L,36L,37L,0L,0L,0L,0L,0L,8L,0L,10L,46L,0L,0L,0L,0L,17L,0L,0L,5L,21L,56L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,67L,0L,0L,0L,0L,0L,23L,0L,12L,19L,27L,78L,79L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,92L,0L,0L,0L,0L,0L,0L,30L,0L,0L,0L,0L,5L,21L,106L,0L,0L,0L,0L,0L,0L,0L,0L,0L,17L,0L,8L,0L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286248Inst : IEnumerable<long>
{
public static readonly long[] Value=A286248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286248.Bytes);
public long this[int i]=>Value[i];

public static A286248Inst Instance=new A286248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286249
{
public static readonly long[] Value={ 1L,3L,2L,3L,0L,4L,10L,5L,0L,7L,3L,0L,0L,0L,11L,21L,5L,8L,0L,0L,16L,3L,0L,0L,0L,0L,0L,22L,36L,14L,0L,12L,0L,0L,0L,29L,10L,0L,8L,0L,0L,0L,0L,0L,37L,21L,5L,0L,0L,17L,0L,0L,0L,0L,46L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,56L,78L,27L,19L,12L,0L,23L,0L,0L,0L,0L,0L,67L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,79L,21L,5L,0L,0L,0L,0L,30L,0L,0L,0L,0L,0L,0L,92L,21L,0L,8L,0L,17L,0L,0L,0L,0L,0L,0L,0L,0L,0L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286249Inst : IEnumerable<long>
{
public static readonly long[] Value=A286249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286249.Bytes);
public long this[int i]=>Value[i];

public static A286249Inst Instance=new A286249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286250
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,2L,6L,2L,4L,6L,2L,2L,2L,6L,12L,6L,8L,2L,2L,2L,2L,16L,2L,6L,4L,6L,6L,2L,2L,30L,12L,6L,6L,4L,12L,6L,6L,6L,6L,6L,2L,2L,6L,6L,30L,2L,6L,2L,6L,6L,2L,6L,2L,6L,6L,6L,6L,2L,6L,6L,2L,12L,2L,36L,2L,6L,4L,2L,12L,30L,12L,12L,2L,12L,2L,24L,2L,2L,6L,6L,24L,2L,2L,12L,2L,24L,12L,2L,2L,30L,30L,6L,6L,2L,2L,4L,6L,2L,30L,6L,32L,2L,6L,2L,6L,2L,6L,12L,4L,2L,30L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286250Inst : IEnumerable<long>
{
public static readonly long[] Value=A286250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286250.Bytes);
public long this[int i]=>Value[i];

public static A286250Inst Instance=new A286250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286251
{
public static readonly long[] Value={ 3L,2L,9L,7L,5L,16L,14L,29L,12L,16L,9L,67L,5L,16L,50L,121L,5L,67L,9L,67L,23L,16L,14L,277L,12L,16L,48L,67L,5L,436L,27L,497L,23L,16L,31L,631L,5L,16L,40L,277L,5L,436L,9L,67L,80L,16L,20L,1129L,12L,67L,31L,67L,5L,277L,40L,277L,23L,16L,9L,1771L,5L,16L,160L,2017L,23L,436L,9L,67L,23L,436L,14L,2557L,5L,16L,94L,67L,23L,436L,20L,1129L,138L,16L,9L,1771L,23L,16L,40L,277L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286251Inst : IEnumerable<long>
{
public static readonly long[] Value=A286251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286251.Bytes);
public long this[int i]=>Value[i];

public static A286251Inst Instance=new A286251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286252
{
public static readonly long[] Value={ 1L,5L,2L,18L,2L,23L,7L,59L,2L,23L,16L,94L,7L,80L,29L,195L,2L,23L,16L,94L,16L,467L,67L,355L,7L,80L,67L,706L,29L,302L,121L,672L,2L,23L,16L,94L,16L,467L,67L,355L,16L,467L,436L,1894L,67L,1832L,277L,1331L,7L,80L,67L,706L,67L,1832L,631L,2779L,29L,302L,277L,2704L,121L,1178L,497L,2422L,2L,23L,16L,94L,16L,467L,67L,355L,16L,467L,436L,1894L,67L,1832L,277L,1331L,16L,467L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286252Inst : IEnumerable<long>
{
public static readonly long[] Value=A286252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286252.Bytes);
public long this[int i]=>Value[i];

public static A286252Inst Instance=new A286252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286253
{
public static readonly long[] Value={ 0L,1L,8L,1L,9L,1L,25L,1L,5L,1L,26L,1L,27L,1L,17L,1L,35L,1L,53L,1L,5L,1L,75L,1L,9L,1L,8L,1L,65L,1L,131L,1L,5L,1L,13L,1L,90L,1L,12L,1L,104L,1L,134L,1L,5L,1L,186L,1L,14L,1L,8L,1L,152L,1L,18L,1L,5L,1L,188L,1L,189L,1L,30L,1L,9L,1L,229L,1L,5L,1L,273L,1L,252L,1L,8L,1L,14L,1L,347L,1L,5L,1L,323L,1L,9L,1L,12L,1L,324L,1L,19L,1L,5L,1L,31L,1L,350L,1L,8L,1L,377L,1L,462L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286253Inst : IEnumerable<long>
{
public static readonly long[] Value=A286253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286253.Bytes);
public long this[int i]=>Value[i];

public static A286253Inst Instance=new A286253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286254
{
public static readonly long[] Value={ 1L,5L,1L,13L,1L,12L,1L,14L,1L,17L,1L,31L,1L,5L,1L,60L,1L,38L,1L,9L,1L,47L,1L,19L,1L,5L,1L,69L,1L,68L,1L,27L,1L,8L,1L,94L,1L,5L,1L,124L,1L,107L,1L,9L,1L,122L,1L,33L,1L,5L,1L,156L,1L,8L,1L,14L,1L,155L,1L,193L,1L,5L,1L,43L,1L,192L,1L,9L,1L,212L,1L,280L,1L,5L,1L,18L,1L,255L,1L,20L,1L,278L,1L,13L,1L,5L,1L,355L,1L,12L,1L,9L,1L,8L,1L,441L,1L,5L,1L,381L,1L,380L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286254Inst : IEnumerable<long>
{
public static readonly long[] Value=A286254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286254.Bytes);
public long this[int i]=>Value[i];

public static A286254Inst Instance=new A286254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286255
{
public static readonly long[] Value={ 2L,5L,12L,14L,23L,27L,38L,63L,40L,27L,80L,90L,23L,61L,216L,152L,80L,90L,80L,148L,61L,27L,302L,375L,40L,84L,179L,90L,467L,495L,530L,698L,61L,61L,826L,702L,23L,61L,412L,324L,467L,495L,80L,265L,148L,27L,1178L,1323L,109L,148L,142L,90L,302L,430L,412L,430L,61L,27L,1832L,1890L,23L,142L,2787L,2410L,601L,495L,80L,148L,601L,495L,2630L,2700L,23L,142L,265L,148L,601L,495L,1178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286255Inst : IEnumerable<long>
{
public static readonly long[] Value=A286255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286255.Bytes);
public long this[int i]=>Value[i];

public static A286255Inst Instance=new A286255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286256
{
public static readonly long[] Value={ 2L,12L,5L,40L,5L,84L,12L,86L,14L,142L,5L,148L,23L,216L,27L,367L,5L,265L,23L,148L,27L,412L,12L,430L,59L,142L,44L,832L,5L,1860L,23L,698L,61L,826L,27L,856L,23L,412L,27L,1402L,5L,850L,80L,148L,90L,1384L,12L,1759L,40L,265L,27L,607L,23L,1105L,61L,430L,27L,2086L,5L,2140L,80L,2352L,148L,4342L,27L,850L,23L,832L,27L,5080L,5L,2998L,80L,142L,148L,832L,27L,2956L,138L,1426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286256Inst : IEnumerable<long>
{
public static readonly long[] Value=A286256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286256.Bytes);
public long this[int i]=>Value[i];

public static A286256Inst Instance=new A286256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286257
{
public static readonly long[] Value={ 1L,5L,5L,14L,12L,27L,5L,86L,14L,27L,23L,90L,12L,84L,27L,152L,23L,148L,5L,148L,27L,27L,80L,324L,25L,61L,44L,148L,23L,495L,5L,935L,61L,27L,61L,702L,5L,142L,61L,324L,138L,495L,23L,148L,90L,61L,23L,1426L,14L,265L,27L,90L,467L,324L,27L,430L,27L,61L,80L,2140L,12L,61L,183L,2144L,61L,495L,23L,607L,27L,495L,23L,2998L,23L,142L,90L,90L,142L,625L,5L,1426L,226L,27L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286257Inst : IEnumerable<long>
{
public static readonly long[] Value=A286257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286257.Bytes);
public long this[int i]=>Value[i];

public static A286257Inst Instance=new A286257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286258
{
public static readonly long[] Value={ 2L,5L,5L,25L,5L,27L,23L,44L,14L,61L,5L,117L,38L,27L,27L,226L,23L,90L,23L,90L,27L,142L,5L,375L,40L,27L,86L,148L,5L,495L,80L,698L,27L,61L,27L,702L,80L,61L,27L,765L,5L,625L,23L,90L,148L,61L,23L,1224L,109L,90L,27L,832L,5L,324L,61L,324L,61L,142L,23L,2013L,23L,84L,90L,2410L,27L,625L,302L,90L,27L,625L,23L,2998L,80L,27L,90L,265L,61L,495L,23L,1426L,152L,601L,5L,2013L,142L,27L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286258Inst : IEnumerable<long>
{
public static readonly long[] Value=A286258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286258.Bytes);
public long this[int i]=>Value[i];

public static A286258Inst Instance=new A286258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286259
{
public static readonly long[] Value={ 1L,2L,1L,6L,4L,5L,11L,25L,16L,23L,37L,31L,56L,57L,56L,110L,106L,80L,137L,123L,137L,173L,211L,175L,232L,255L,254L,279L,352L,255L,407L,471L,407L,467L,466L,409L,596L,597L,596L,599L,742L,597L,821L,783L,742L,905L,991L,866L,1036L,992L,1082L,1131L,1276L,1083L,1276L,1279L,1379L,1487L,1597L,1228L,1712L,1713L,1597L,1960L,1831L,1713L,2081L,2019L,2081L,1955L,2347L,1957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286259Inst : IEnumerable<long>
{
public static readonly long[] Value=A286259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286259.Bytes);
public long this[int i]=>Value[i];

public static A286259Inst Instance=new A286259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286260
{
public static readonly long[] Value={ 1L,8L,1L,39L,4L,8L,1L,157L,79L,47L,4L,39L,22L,8L,4L,600L,37L,782L,11L,256L,1L,47L,4L,157L,466L,233L,11L,39L,106L,47L,1L,2284L,4L,380L,4L,4281L,172L,122L,22L,1132L,211L,8L,56L,256L,742L,47L,4L,600L,1597L,4373L,37L,1278L,352L,122L,37L,157L,11L,1037L,106L,256L,466L,8L,79L,8785L,211L,47L,137L,2083L,4L,47L,37L,19507L,667L,1655L,466L,669L,4L,233L,11L,4661L,7261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286260Inst : IEnumerable<long>
{
public static readonly long[] Value=A286260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286260.Bytes);
public long this[int i]=>Value[i];

public static A286260Inst Instance=new A286260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286261
{
public static readonly long[] Value={ 7L,8L,14L,15L,16L,17L,23L,24L,28L,29L,30L,31L,32L,33L,34L,35L,39L,40L,42L,46L,47L,48L,49L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,78L,79L,80L,81L,84L,85L,87L,88L,92L,93L,94L,95L,96L,97L,98L,99L,103L,104L,106L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L,128L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286261Inst : IEnumerable<long>
{
public static readonly long[] Value=A286261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286261.Bytes);
public long this[int i]=>Value[i];

public static A286261Inst Instance=new A286261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286262
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,13L,18L,19L,20L,21L,22L,25L,26L,27L,36L,37L,38L,41L,43L,44L,45L,50L,51L,52L,53L,54L,73L,74L,75L,76L,77L,82L,83L,86L,89L,90L,91L,100L,101L,102L,105L,107L,108L,109L,146L,147L,148L,150L,153L,154L,155L,164L,165L,166L,172L,173L,178L,179L,180L,181L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286262Inst : IEnumerable<long>
{
public static readonly long[] Value=A286262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286262.Bytes);
public long this[int i]=>Value[i];

public static A286262Inst Instance=new A286262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286791
{
public static readonly BigInteger[] Value={ 1L,189L,16576L,1023340L,52563182L,2445890678L,108248782988L,4693939818672L,203214066766123L,8891156436472127L,396276632116578640L,18084968846773765272UL,BigInteger.Parse("847923332620865268252"),BigInteger.Parse("40927316768759272656876"),BigInteger.Parse("2036183873275911481501656"),BigInteger.Parse("104482592642320957223810448") };
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
public class A286791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286791Inst Instance=new A286791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286792
{
public static readonly BigInteger[] Value={ 1L,268L,31356L,2471008L,156688950L,8769288752L,457164358716L,22959079494036L,1135195898868631L,56066461542293032L,2793059847097230456L,BigInteger.Parse("141275485011659499936"),BigInteger.Parse("7287917154352619470284"),BigInteger.Parse("384587934464798917826784"),BigInteger.Parse("20802129691800205763744280"),BigInteger.Parse("1154767942465769017202459544") };
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
public class A286792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286792Inst Instance=new A286792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286793
{
public static readonly BigInteger[] Value={ 1L,366L,55650L,5493004L,423998498L,28236562692L,1719625254528L,99364697625603L,5581585635090040L,309848573192308938L,17191725056094651066UL,BigInteger.Parse("960908576231662848594"),BigInteger.Parse("54403314773991195041214"),BigInteger.Parse("3132006013784614723699158"),BigInteger.Parse("183841318769012678798846646"),BigInteger.Parse("11022935912713058281592718756") };
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
public class A286793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286793Inst Instance=new A286793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286794
{
public static readonly BigInteger[] Value={ 1L,3L,20L,189L,2232L,31130L,497016L,8907885L,176829104L,3849436062L,91187523000L,2335691914050L,64344487654800L,1897619527612692L,59667237154623280L,1993022006345620605L,BigInteger.Parse("70488571028815935072"),BigInteger.Parse("2631925423768158446390"),BigInteger.Parse("103469607286411235941944"),BigInteger.Parse("4272438866376100717458486") };
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
public class A286794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286794Inst Instance=new A286794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286795
{
public static readonly long[] Value={ 1L,1L,4L,3L,27L,31L,5L,248L,357L,117L,7L,2830L,4742L,2218L,314L,9L,38232L,71698L,42046L,9258L,690L,11L,593859L,1216251L,837639L,243987L,30057L,1329L,13L,10401712L,22877725L,17798029L,6314177L,1071809L,81963L,2331L,15L,202601898L,472751962L,404979234L,166620434L,35456432L,3857904L,196532L,3812L,17L,4342263000L,10651493718L,9869474106L,4561150162L,1149976242L,160594860L,11946360L,426852L,5904L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286795Inst : IEnumerable<long>
{
public static readonly long[] Value=A286795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286795.Bytes);
public long this[int i]=>Value[i];

public static A286795Inst Instance=new A286795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286796
{
public static readonly long[] Value={ 1L,1L,1L,4L,5L,1L,27L,40L,14L,1L,248L,419L,200L,30L,1L,2830L,5308L,3124L,700L,55L,1L,38232L,78070L,53620L,15652L,1960L,91L,1L,593859L,1301088L,1007292L,356048L,60550L,4704L,140L,1L,10401712L,24177939L,20604768L,8430844L,1787280L,194854L,10080L,204L,1L,202601898L,495263284L,456715752L,209878440L,52619854L,7322172L,545908L,19800L,285L,1L,4342263000L,11085720018L,10921213644L,5516785032L,1579263840L,264576774L,25677652L,1372228L,36300L,385L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286796Inst : IEnumerable<long>
{
public static readonly long[] Value=A286796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286796.Bytes);
public long this[int i]=>Value[i];

public static A286796Inst Instance=new A286796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286797
{
public static readonly BigInteger[] Value={ 1L,2L,10L,82L,898L,12018L,187626L,3323682L,65607682L,1424967394L,33736908874L,864372576626L,23825543471234L,703074672632018L,22118247888976170L,739081808704195650L,BigInteger.Parse("26146116129400483842"),BigInteger.Parse("976382058777174451650"),BigInteger.Parse("38386296866727499728522"),BigInteger.Parse("1584986693941237056394386") };
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
public class A286797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286797Inst Instance=new A286797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286798
{
public static readonly long[] Value={ 1L,1L,4L,2L,27L,22L,248L,264L,30L,2830L,3610L,830L,8L,38232L,55768L,18746L,1078L,593859L,961740L,414720L,46986L,576L,10401712L,18326976L,9457788L,1593664L,62682L,112L,202601898L,382706674L,226526362L,49941310L,3569882L,45296L,4342263000L,8697475368L,5740088706L,1540965514L,160998750L,4909674L,16896L,101551822350L,213865372020L,154271354280L,48205014786L,6580808784L,337737294L,4200032L,2560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286798Inst : IEnumerable<long>
{
public static readonly long[] Value=A286798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286798.Bytes);
public long this[int i]=>Value[i];

public static A286798Inst Instance=new A286798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286799
{
public static readonly BigInteger[] Value={ 1L,1L,6L,49L,542L,7278L,113824L,2017881L,39842934L,865391422L,20486717908L,524816312106L,14463876594476L,426759508580416L,13423937511765492L,448515527244396873L,15865571912065180326UL,BigInteger.Parse("592432249691301719190"),BigInteger.Parse("23290086526099237126180"),BigInteger.Parse("961614574423928988516286"),BigInteger.Parse("41607005553456012247259844") };
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
public class A286799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286799Inst Instance=new A286799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286800
{
public static readonly long[] Value={ 1L,1L,2L,7L,6L,63L,74L,10L,729L,974L,254L,8L,10113L,15084L,5376L,406L,161935L,264724L,117424L,14954L,320L,2923135L,5163276L,2697804L,481222L,23670L,112L,58547761L,110483028L,65662932L,14892090L,1186362L,21936L,1286468225L,2570021310L,1695874928L,461501018L,51034896L,1866986L,11264L,30747331223L,64547199082L,46461697760L,14603254902L,2055851560L,116329886L,1905888L,2560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286800Inst : IEnumerable<long>
{
public static readonly long[] Value=A286800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286800.Bytes);
public long this[int i]=>Value[i];

public static A286800Inst Instance=new A286800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286801
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286801Inst : IEnumerable<long>
{
public static readonly long[] Value=A286801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286801.Bytes);
public long this[int i]=>Value[i];

public static A286801Inst Instance=new A286801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286802
{
public static readonly long[] Value={ 3L,6L,7L,9L,12L,15L,16L,18L,21L,24L,27L,28L,30L,33L,36L,37L,39L,42L,45L,48L,49L,51L,54L,57L,58L,60L,63L,66L,67L,69L,72L,75L,78L,79L,81L,84L,87L,88L,90L,93L,96L,99L,100L,102L,105L,108L,109L,111L,114L,117L,118L,120L,123L,126L,129L,130L,132L,135L,138L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286802Inst : IEnumerable<long>
{
public static readonly long[] Value=A286802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286802.Bytes);
public long this[int i]=>Value[i];

public static A286802Inst Instance=new A286802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286803
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,11L,13L,14L,17L,19L,20L,22L,23L,25L,26L,29L,31L,32L,34L,35L,38L,40L,41L,43L,44L,46L,47L,50L,52L,53L,55L,56L,59L,61L,62L,64L,65L,68L,70L,71L,73L,74L,76L,77L,80L,82L,83L,85L,86L,89L,91L,92L,94L,95L,97L,98L,101L,103L,104L,106L,107L,110L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286803Inst : IEnumerable<long>
{
public static readonly long[] Value=A286803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286803.Bytes);
public long this[int i]=>Value[i];

public static A286803Inst Instance=new A286803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286804
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286804Inst : IEnumerable<long>
{
public static readonly long[] Value=A286804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286804.Bytes);
public long this[int i]=>Value[i];

public static A286804Inst Instance=new A286804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286805
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,12L,13L,15L,16L,19L,20L,23L,24L,26L,27L,30L,31L,34L,35L,38L,39L,41L,42L,45L,46L,49L,50L,52L,53L,56L,57L,60L,61L,64L,65L,67L,68L,71L,72L,75L,76L,78L,79L,82L,83L,86L,87L,89L,90L,93L,94L,97L,98L,101L,102L,104L,105L,108L,109L,112L,113L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286805Inst : IEnumerable<long>
{
public static readonly long[] Value=A286805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286805.Bytes);
public long this[int i]=>Value[i];

public static A286805Inst Instance=new A286805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286806
{
public static readonly long[] Value={ 3L,6L,7L,10L,11L,14L,17L,18L,21L,22L,25L,28L,29L,32L,33L,36L,37L,40L,43L,44L,47L,48L,51L,54L,55L,58L,59L,62L,63L,66L,69L,70L,73L,74L,77L,80L,81L,84L,85L,88L,91L,92L,95L,96L,99L,100L,103L,106L,107L,110L,111L,114L,117L,118L,121L,122L,125L,126L,129L,132L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286806Inst : IEnumerable<long>
{
public static readonly long[] Value=A286806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286806.Bytes);
public long this[int i]=>Value[i];

public static A286806Inst Instance=new A286806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286807
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286807Inst : IEnumerable<long>
{
public static readonly long[] Value=A286807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286807.Bytes);
public long this[int i]=>Value[i];

public static A286807Inst Instance=new A286807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286808
{
public static readonly long[] Value={ 1L,2L,5L,8L,10L,12L,15L,17L,19L,21L,23L,25L,27L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,124L,126L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286808Inst : IEnumerable<long>
{
public static readonly long[] Value=A286808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286808.Bytes);
public long this[int i]=>Value[i];

public static A286808Inst Instance=new A286808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286809
{
public static readonly long[] Value={ 3L,4L,6L,7L,9L,11L,13L,14L,16L,18L,20L,22L,24L,26L,28L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286809Inst : IEnumerable<long>
{
public static readonly long[] Value=A286809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286809.Bytes);
public long this[int i]=>Value[i];

public static A286809Inst Instance=new A286809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286810
{
public static readonly ulong[] Value={ 1L,9L,49L,324L,2209L,15129L,103684L,710649L,4870849L,33385284L,228826129L,1568397609L,10749957124L,73681302249L,505019158609L,3461452808004L,23725150497409L,162614600673849L,1114577054219524L,7639424778862809L,52361396397820129L,358890350005878084L,2459871053643326449L,16860207025497407049UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286810Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286810.Bytes);
public ulong this[int i]=>Value[i];

public static A286810Inst Instance=new A286810Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286811
{
public static readonly BigInteger[] Value={ 1L,11L,11L,1111L,11L,111111L,1111L,11111111L,1111L,1111111111L,1111L,111111111111L,1111L,11111111111111L,11111111L,1111111111111111L,11111111L,111111111111111111L,11111111L,11111111111111111111UL,11111111L,BigInteger.Parse("1111111111111111111111"),11111111L };
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
public class A286811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286811Inst Instance=new A286811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286812
{
public static readonly long[] Value={ 104L,103L,101L,97L,89L,73L,41L,-23L,-151L,-407L,-919L,-1943L,-3991L,-8087L,-16279L,-32663L,-65431L,-130967L,-262039L,-524183L,-1048471L,-2097047L,-4194199L,-8388503L,-16777111L,-33554327L,-67108759L,-134217623L,-268435351L,-536870807L,-1073741719L,-2147483543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286812Inst : IEnumerable<long>
{
public static readonly long[] Value=A286812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286812.Bytes);
public long this[int i]=>Value[i];

public static A286812Inst Instance=new A286812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286813
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,0L,0L,1L,2L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286813Inst : IEnumerable<long>
{
public static readonly long[] Value=A286813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286813.Bytes);
public long this[int i]=>Value[i];

public static A286813Inst Instance=new A286813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286814
{
public static readonly long[] Value={ 2L,3L,10L,29L,82L,227L,618L,1661L,4418L,11651L,30506L,79389L,205522L,529635L,1359434L,3476989L,8865026L,22538755L,57157578L,144615709L,365127634L,920110051L,2314564522L,5812911741L,14576950082L,36503608707L,91294323178L,228049363229L,569017421650L,1418290058723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286814Inst : IEnumerable<long>
{
public static readonly long[] Value=A286814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286814.Bytes);
public long this[int i]=>Value[i];

public static A286814Inst Instance=new A286814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286815
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,4L,0L,0L,1L,6L,4L,0L,0L,1L,8L,12L,0L,2L,0L,1L,10L,24L,8L,4L,0L,0L,1L,12L,40L,32L,6L,8L,0L,0L,1L,14L,60L,80L,24L,24L,0L,0L,0L,1L,16L,84L,160L,90L,48L,24L,0L,0L,0L,1L,18L,112L,280L,252L,112L,96L,0L,4L,2L,0L,1L,20L,144L,448L,574L,312L,240L,64L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286815Inst : IEnumerable<long>
{
public static readonly long[] Value=A286815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286815.Bytes);
public long this[int i]=>Value[i];

public static A286815Inst Instance=new A286815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286816
{
public static readonly long[] Value={ 5L,17L,8L,449L,26L,7L,557L,226L,18L,18L,19601L,1207L,1207L,148L,3L,132857L,54568L,1451L,606L,239L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286816Inst : IEnumerable<long>
{
public static readonly long[] Value=A286816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286816.Bytes);
public long this[int i]=>Value[i];

public static A286816Inst Instance=new A286816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286817
{
public static readonly long[] Value={ 4480114337L,11598050027L,16107995833L,19544227597L,19921527331L,26594502101L,29300624819L,29558893643L,30312236239L,30570499049L,31578774413L,38072416381L,38554165297L,43191763313L,44924731961L,45264825169L,45870718093L,46642295699L,47647807219L,48621561623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286817Inst : IEnumerable<long>
{
public static readonly long[] Value=A286817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286817.Bytes);
public long this[int i]=>Value[i];

public static A286817Inst Instance=new A286817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286818
{
public static readonly BigInteger[] Value={ 1L,11L,11L,1110L,111L,111110L,1111L,11111110L,11011L,1111111100L,110011L,111111111110L,1111111L,11111111100000L,11011111L,1111111111111000L,111110111L,111111111111111000L,1111110111L,11111111111111111000UL,11001111111L,BigInteger.Parse("1111111111111110111011"),110111100110L };
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
public class A286818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286818Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286818.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286818.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286818Inst Instance=new A286818Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286819
{
public static readonly BigInteger[] Value={ 1L,11L,110L,111L,11100L,11111L,1111000L,1111111L,110110000L,11111111L,11001100000L,11111111111L,1111111000000L,111111111L,111110110000000L,1111111111111L,11101111100000000L,111111111111111L,1110111111000000000L,11111111111111111L,BigInteger.Parse("111111100110000000000") };
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
public class A286819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286819Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286819.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286819.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286819Inst Instance=new A286819Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286820
{
public static readonly long[] Value={ 1L,2L,3L,8L,25L,6L,7L,8L,9L,30L,33L,24L,26L,126L,30L,32L,153L,126L,152L,120L,126L,726L,5888L,24L,25L,26L,27L,728L,145L,30L,31L,32L,33L,5066L,840L,144L,5883L,152L,5070L,120L,123L,126L,129L,5192L,720L,5888L,752L,144L,147L,150L,153L,728L,848L,864L,46200L,728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286820Inst : IEnumerable<long>
{
public static readonly long[] Value=A286820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286820.Bytes);
public long this[int i]=>Value[i];

public static A286820Inst Instance=new A286820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286821
{
public static readonly long[] Value={ 1L,1L,11L,1L,101L,11L,1011L,101L,11001L,1011L,100001L,111L,1110001L,1011L,10111101L,10011L,110011011L,1010111L,1001011011L,10010111L,11110011011L,110111L,101100111011L,1010111L,1100101011011L,1111000111L,10010111001011L,1111101111L,111101101111011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286821Inst : IEnumerable<long>
{
public static readonly long[] Value=A286821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286821.Bytes);
public long this[int i]=>Value[i];

public static A286821Inst Instance=new A286821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286822
{
public static readonly ulong[] Value={ 1L,10L,110L,1000L,10100L,110000L,1101000L,10100000L,100110000L,1101000000L,10000100000L,111000000000L,1000111000000L,11010000000000L,101111010000000L,1100100000000000L,11011001100000000L,111010100000000000L,1101101001000000000L,11101001000000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286822Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286822.Bytes);
public ulong this[int i]=>Value[i];

public static A286822Inst Instance=new A286822Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286839
{
public static readonly long[] Value={ 8L,7L,11L,12L,7L,7L,11L,12L,11L,4L,4L,6L,0L,6L,9L,12L,8L,5L,8L,7L,12L,7L,11L,8L,1L,5L,6L,2L,7L,7L,7L,3L,6L,2L,6L,10L,7L,12L,12L,10L,1L,5L,5L,12L,5L,7L,0L,9L,8L,10L,3L,6L,5L,10L,0L,5L,6L,11L,7L,12L,7L,9L,1L,12L,2L,0L,9L,4L,7L,6L,2L,7L,3L,6L,3L,10L,4L,7L,12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286839Inst : IEnumerable<long>
{
public static readonly long[] Value=A286839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286839.Bytes);
public long this[int i]=>Value[i];

public static A286839Inst Instance=new A286839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286840
{
public static readonly BigInteger[] Value={ 0L,5L,70L,239L,239L,143044L,1999509L,6826318L,6826318L,822557039L,85658552023L,1188526486815L,11941488851037L,291518510320809L,2108769149874327L,13920898306972194L,13920898306972194L,2675587335039691558L,BigInteger.Parse("63228498770709057089"),BigInteger.Parse("513050126578538629605") };
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
public class A286840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286840Inst Instance=new A286840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286841
{
public static readonly BigInteger[] Value={ 0L,8L,99L,1958L,28322L,228249L,2827300L,55922199L,808904403L,9781942334L,52199939826L,603633907222L,11356596271444L,11356596271444L,1828607235824962L,37264994707118563L,651495710876207647L,5974828584341646375L,BigInteger.Parse("49226908181248336040") };
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
public class A286841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286841Inst Instance=new A286841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286842
{
public static readonly long[] Value={ 4L,2L,7L,1L,7L,54L,3L,1L,3L,5L,5L,27L,3L,7L,35L,2L,5L,18L,3L,40L,1L,11L,5L,96L,2L,13L,1L,14L,7L,120L,5L,1L,99L,68L,1L,9L,3L,19L,1L,20L,5L,5145000L,3L,88L,80L,23L,5L,48L,2L,1L,323L,52L,5L,6L,1L,7L,1L,116L,7L,60L,5L,124L,1L,2L,1L,1650L,3L,34L,299L,35L,7L,32L,5L,37L,7L,19L,1L,26693550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286842Inst : IEnumerable<long>
{
public static readonly long[] Value=A286842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286842.Bytes);
public long this[int i]=>Value[i];

public static A286842Inst Instance=new A286842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286843
{
public static readonly long[] Value={ 10L,14L,22L,38L,44L,92L,110L,130L,134L,136L,152L,170L,184L,248L,250L,262L,284L,376L,410L,442L,632L,730L,752L,884L,988L,1012L,1052L,1276L,1292L,1370L,1628L,2144L,2168L,2272L,2332L,2528L,3068L,4064L,4124L,5210L,6112L,6364L,6556L,7372L,8198L,8312L,8384L,8648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286843Inst : IEnumerable<long>
{
public static readonly long[] Value=A286843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286843.Bytes);
public long this[int i]=>Value[i];

public static A286843Inst Instance=new A286843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286844
{
public static readonly long[] Value={ 1L,2L,3L,4L,2L,4L,2L,3L,6L,1L,2L,4L,3L,4L,5L,7L,6L,5L,6L,7L,6L,7L,4L,2L,4L,3L,8L,5L,6L,8L,6L,2L,8L,3L,7L,4L,8L,6L,10L,10L,7L,10L,9L,10L,12L,10L,2L,4L,6L,11L,7L,4L,10L,6L,5L,7L,11L,2L,3L,9L,5L,8L,6L,8L,12L,7L,11L,10L,12L,1L,3L,11L,4L,10L,8L,7L,10L,4L,15L,12L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286844Inst : IEnumerable<long>
{
public static readonly long[] Value=A286844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286844.Bytes);
public long this[int i]=>Value[i];

public static A286844Inst Instance=new A286844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286845
{
public static readonly long[] Value={ 459L,468L,486L,495L,549L,567L,576L,594L,639L,648L,657L,675L,693L,729L,738L,783L,792L,819L,837L,846L,864L,873L,891L,918L,927L,936L,945L,954L,963L,972L,981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286845Inst : IEnumerable<long>
{
public static readonly long[] Value=A286845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286845.Bytes);
public long this[int i]=>Value[i];

public static A286845Inst Instance=new A286845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286846
{
public static readonly long[] Value={ 459173286L,459176283L,459183276L,459186273L,459273186L,459276183L,459283176L,459286173L,468173295L,468175293L,468193275L,468195273L,468273195L,468275193L,468293175L,468295173L,486127359L,486129357L,486157329L,486159327L,486327159L,486329157L,486357129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286846Inst : IEnumerable<long>
{
public static readonly long[] Value=A286846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286846.Bytes);
public long this[int i]=>Value[i];

public static A286846Inst Instance=new A286846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286847
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,2L,4L,7L,7L,4L,4L,18L,16L,18L,4L,7L,39L,53L,53L,39L,7L,9L,75L,154L,306L,154L,75L,9L,13L,155L,436L,1167L,1167L,436L,155L,13L,18L,310L,1268L,4939L,6958L,4939L,1268L,310L,18L,25L,638L,3660L,21313L,40931L,40931L,21313L,3660L,638L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286847Inst : IEnumerable<long>
{
public static readonly long[] Value=A286847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286847.Bytes);
public long this[int i]=>Value[i];

public static A286847Inst Instance=new A286847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286848
{
public static readonly long[] Value={ 2L,7L,16L,53L,154L,436L,1268L,3660L,10610L,30744L,89079L,258251L,748420L,2169219L,6287336L,18222901L,52817261L,153084840L,443698814L,1286012537L,3727362387L,10803344089L,31312289784L,90755170545L,263043739916L,762402920030L,2209739758798L,6404684091893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286848Inst : IEnumerable<long>
{
public static readonly long[] Value=A286848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286848.Bytes);
public long this[int i]=>Value[i];

public static A286848Inst Instance=new A286848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286849
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,4L,6L,6L,4L,4L,16L,12L,16L,4L,7L,20L,36L,36L,20L,7L,9L,52L,64L,256L,64L,52L,9L,13L,80L,204L,400L,400L,204L,80L,13L,18L,176L,446L,2704L,971L,2704L,446L,176L,18L,25L,296L,1184L,6400L,6486L,6486L,6400L,1184L,296L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286849Inst : IEnumerable<long>
{
public static readonly long[] Value=A286849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286849.Bytes);
public long this[int i]=>Value[i];

public static A286849Inst Instance=new A286849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286850
{
public static readonly long[] Value={ 2L,4L,6L,16L,20L,52L,80L,176L,296L,592L,1104L,2064L,3936L,7296L,14048L,25984L,49600L,92736L,175872L,330240L,623232L,1175296L,2213632L,4176128L,7863808L,14838784L,27948544L,52707328L,99320832L,187257856L,352940032L,665276416L,1254090752L,2363805696L,4455927808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286850Inst : IEnumerable<long>
{
public static readonly long[] Value=A286850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286850.Bytes);
public long this[int i]=>Value[i];

public static A286850Inst Instance=new A286850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286851
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,25L,2L,2L,2L,129L,2L,170L,2L,742L,450L,2L,2L,4603L,2L,1503L,3321L,29967L,2L,9278L,2L,200390L,2L,13460L,2L,154004511L,2L,2L,226020L,9262157L,51886L,127654L,2L,63346598L,2044895L,170354L,2L,185493291001L,2L,1304512L,567124L,2972038875L,2L,59489916L,2L,20367343494L,184947044L,14324735L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286851Inst : IEnumerable<long>
{
public static readonly long[] Value=A286851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286851.Bytes);
public long this[int i]=>Value[i];

public static A286851Inst Instance=new A286851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286852
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,1L,0L,0L,2L,1L,1L,1L,2L,2L,0L,1L,1L,1L,1L,2L,2L,1L,1L,0L,2L,0L,1L,1L,21L,1L,0L,2L,2L,2L,0L,1L,2L,2L,1L,1L,28L,1L,1L,1L,2L,1L,1L,0L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,5L,1L,2L,1L,0L,2L,42L,1L,1L,2L,43L,1L,0L,1L,2L,1L,1L,2L,49L,1L,1L,0L,2L,1L,5L,2L,2L,2L,1L,1L,10L,2L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286852Inst : IEnumerable<long>
{
public static readonly long[] Value=A286852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286852.Bytes);
public long this[int i]=>Value[i];

public static A286852Inst Instance=new A286852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286853
{
public static readonly long[] Value={ 198L,22L,110L,220L,110L,220L,110L,36L,184L,110L,220L,110L,6L,60L,154L,110L,220L,110L,120L,100L,110L,88L,132L,110L,220L,44L,66L,48L,172L,110L,220L,110L,220L,66L,44L,220L,110L,132L,88L,110L,220L,110L,70L,150L,110L,6L,148L,66L,110L,220L,110L,220L,110L,220L,110L,220L,110L,22L,198L,32L,78L,198L,22L,110L,220L,110L,210L,10L,30L,80L,220L,110L,220L,110L,66L,154L,110L,220L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286853Inst : IEnumerable<long>
{
public static readonly long[] Value=A286853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286853.Bytes);
public long this[int i]=>Value[i];

public static A286853Inst Instance=new A286853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286854
{
public static readonly long[] Value={ 55L,253L,275L,385L,605L,715L,935L,1045L,1081L,1265L,1375L,1595L,1705L,1711L,1771L,1925L,2035L,2255L,2365L,2485L,2585L,2695L,2783L,2915L,3025L,3245L,3289L,3355L,3403L,3575L,3685L,3905L,4015L,4235L,4301L,4345L,4565L,4675L,4807L,4895L,5005L,5225L,5335L,5405L,5555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286854Inst : IEnumerable<long>
{
public static readonly long[] Value=A286854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286854.Bytes);
public long this[int i]=>Value[i];

public static A286854Inst Instance=new A286854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286888
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286888Inst : IEnumerable<long>
{
public static readonly long[] Value=A286888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286888.Bytes);
public long this[int i]=>Value[i];

public static A286888Inst Instance=new A286888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286889
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,1L,0L,1L,-1L,0L,0L,1L,-3L,2L,0L,3L,-1L,-2L,-10L,8L,5L,8L,-6L,-3L,-24L,17L,8L,12L,-15L,19L,-37L,18L,-29L,18L,3L,109L,-72L,-28L,-153L,46L,72L,335L,-165L,-86L,-346L,84L,-34L,650L,-224L,245L,-492L,-69L,-1054L,966L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286889Inst : IEnumerable<long>
{
public static readonly long[] Value=A286889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286889.Bytes);
public long this[int i]=>Value[i];

public static A286889Inst Instance=new A286889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286890
{
public static readonly long[] Value={ 1L,10L,11L,12L,2L,20L,21L,22L,23L,3L,13L,30L,31L,32L,33L,34L,4L,14L,24L,40L,41L,42L,43L,44L,45L,5L,15L,25L,35L,50L,51L,52L,53L,54L,55L,56L,6L,16L,26L,36L,46L,60L,61L,62L,63L,64L,65L,66L,67L,7L,17L,27L,37L,47L,57L,70L,71L,72L,73L,74L,75L,76L,77L,78L,8L,18L,28L,38L,48L,58L,68L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,9L,19L,29L,39L,49L,59L,69L,79L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,109L,119L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286890Inst : IEnumerable<long>
{
public static readonly long[] Value=A286890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286890.Bytes);
public long this[int i]=>Value[i];

public static A286890Inst Instance=new A286890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286891
{
public static readonly long[] Value={ 41203L,556243L,576193L,715849L,752263L,859249L,891799L,1107763L,1191079L,1201999L,1210369L,1510189L,1601599L,1893163L,2530963L,2678719L,2881243L,3257689L,3431479L,3545263L,3792949L,3804919L,4041109L,4479463L,4867309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286891Inst : IEnumerable<long>
{
public static readonly long[] Value=A286891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286891.Bytes);
public long this[int i]=>Value[i];

public static A286891Inst Instance=new A286891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286892
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,3L,1L,3L,27L,438L,1L,6L,140L,8766L,504504L,1L,16L,1056L,189774L,33258880L,6573403050L,1L,48L,8730L,4292514L,2366403930L,1387750992012L,846182953495152L,1L,108L,63108L,99797220L,159511561440L,282061024690536L,530143167401850960L,BigInteger.Parse("976645996512669379710") };
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
public class A286892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286892Inst Instance=new A286892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286893
{
public static readonly BigInteger[] Value={ 1L,1L,6L,1L,21L,351L,1L,126L,12096L,2544696L,1L,666L,420876L,544638816L,705278736576L,1L,3996L,15132096L,117564302016L,914040184444416L,7107572245840091136L,1L,23436L,544230576L,25390538401536L,1184595336212990976L,BigInteger.Parse("55268479955808421134336"),BigInteger.Parse("2578606199622710056510488576") };
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
public class A286893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286893Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286893.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286893Inst Instance=new A286893Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286894
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,6L,14L,14L,14L,20L,34L,34L,34L,44L,72L,72L,72L,86L,114L,114L,148L,148L,154L,154L,210L,220L,222L,248L,282L,282L,292L,336L,354L,382L,456L,464L,468L,486L,532L,540L,602L,652L,674L,716L,766L,778L,804L,906L,906L,906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286894Inst : IEnumerable<long>
{
public static readonly long[] Value=A286894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286894.Bytes);
public long this[int i]=>Value[i];

public static A286894Inst Instance=new A286894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286895
{
public static readonly BigInteger[] Value={ 1L,1L,7L,1L,28L,637L,1L,196L,30184L,10151428L,1L,1225L,1443001L,3461821825L,8308236966001L,1L,8575L,70656628L,1186972525900L,19948070175962425L,BigInteger.Parse("335267157313994232775"),1L,58996L,3460410037L,407106879976216L,BigInteger.Parse("47895307855522569001"),BigInteger.Parse("5634835073082541702198396"),BigInteger.Parse("662932711464914589254954278237") };
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
public class A286895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286895Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286895.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286895Inst Instance=new A286895Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286896
{
public static readonly BigInteger[] Value={ 1L,3L,17L,137L,1395L,16955L,237426L,3740609L,65197797L,1241499241L,25577181324L,565688751435L,13346516581331L,334144326030052L,8837737924901855L,245998212661731213L,7182425756528424275L,BigInteger.Parse("219332432679783740235"),BigInteger.Parse("6987451758608249737342"),BigInteger.Parse("231704015156531645221237") };
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
public class A286896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286896Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286896.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286896.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286896Inst Instance=new A286896Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286897
{
public static readonly long[] Value={ 1L,5L,1L,23L,6L,1L,109L,33L,7L,1L,544L,182L,45L,8L,1L,2876L,1034L,284L,59L,9L,1L,16113L,6122L,1815L,420L,75L,10L,1L,95495L,37927L,11931L,2987L,595L,93L,11L,1L,597155L,246030L,81205L,21620L,4665L,814L,113L,12L,1L,3929243L,1669941L,573724L,160607L,36900L,6979L,1082L,135L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286897Inst : IEnumerable<long>
{
public static readonly long[] Value=A286897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286897.Bytes);
public long this[int i]=>Value[i];

public static A286897Inst Instance=new A286897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286898
{
public static readonly long[] Value={ 81L,87L,69L,82L,84L,89L,85L,73L,79L,80L,65L,83L,68L,70L,71L,72L,74L,75L,76L,90L,88L,67L,86L,66L,78L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286898Inst : IEnumerable<long>
{
public static readonly long[] Value=A286898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286898.Bytes);
public long this[int i]=>Value[i];

public static A286898Inst Instance=new A286898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286899
{
public static readonly long[] Value={ 1L,1L,2L,1L,8L,3L,1L,32L,21L,4L,1L,128L,183L,40L,5L,1L,512L,1641L,544L,65L,6L,1L,2048L,14763L,8320L,1205L,96L,7L,1L,8192L,132861L,131584L,26465L,2256L,133L,8L,1L,32768L,1195743L,2099200L,628805L,64896L,3787L,176L,9L,1L,131072L,10761681L,33562624L,15424865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286899Inst : IEnumerable<long>
{
public static readonly long[] Value=A286899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286899.Bytes);
public long this[int i]=>Value[i];

public static A286899Inst Instance=new A286899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286900
{
public static readonly long[] Value={ 3L,5L,12L,9L,18L,13L,45L,38L,30L,21L,36L,25L,75L,62L,48L,33L,54L,37L,105L,86L,66L,45L,182L,159L,135L,110L,84L,57L,90L,61L,238L,207L,175L,142L,108L,73L,195L,158L,120L,81L,126L,85L,225L,182L,138L,93L,350L,303L,255L,206L,156L,105L,392L,339L,285L,230L,174L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286900Inst : IEnumerable<long>
{
public static readonly long[] Value=A286900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286900.Bytes);
public long this[int i]=>Value[i];

public static A286900Inst Instance=new A286900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286901
{
public static readonly long[] Value={ 5L,7L,12L,11L,18L,15L,24L,34L,45L,23L,36L,27L,42L,58L,75L,35L,54L,39L,60L,82L,105L,47L,98L,125L,153L,182L,59L,90L,63L,96L,130L,165L,201L,238L,75L,114L,154L,195L,83L,126L,87L,132L,178L,225L,95L,144L,194L,245L,297L,350L,107L,162L,218L,275L,333L,392L,119L,180L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286901Inst : IEnumerable<long>
{
public static readonly long[] Value=A286901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286901.Bytes);
public long this[int i]=>Value[i];

public static A286901Inst Instance=new A286901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286902
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,35L,79L,195L,498L,1290L,3362L,8611L,22172L,57130L,147205L,379235L,976778L,2516243L,6481974L,16697759L,43013723L,110804025L,285433859L,735283984L,1894107464L,4879261724L,12569084165L,32378235236L,83407038514L,214858345697L,553479773713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286902Inst : IEnumerable<long>
{
public static readonly long[] Value=A286902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286902.Bytes);
public long this[int i]=>Value[i];

public static A286902Inst Instance=new A286902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286903
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286903Inst : IEnumerable<long>
{
public static readonly long[] Value=A286903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286903.Bytes);
public long this[int i]=>Value[i];

public static A286903Inst Instance=new A286903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286968
{
public static readonly long[] Value={ 1L,2L,3L,14L,5L,56L,12L,245L,16L,992L,49L,4080L,65L,16304L,193L,65328L,449L,261872L,769L,1047792L,1665L,4192960L,3713L,16773824L,4225L,67102912L,12417L,268433600L,16513L,1073717440L,49281L,4294901952L,114817L,17179771072L,196737L,68719216832L,395393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286968Inst : IEnumerable<long>
{
public static readonly long[] Value=A286968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286968.Bytes);
public long this[int i]=>Value[i];

public static A286968Inst Instance=new A286968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286969
{
public static readonly long[] Value={ 1L,1L,6L,7L,20L,7L,24L,175L,16L,31L,1120L,255L,4160L,895L,16768L,3327L,67328L,15871L,263680L,62463L,1059840L,55295L,4241408L,217087L,16912384L,811007L,67657728L,3276799L,270548992L,12681215L,1082228736L,50397183L,4328980480L,201719807L,17314480128L,822345727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286969Inst : IEnumerable<long>
{
public static readonly long[] Value=A286969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286969.Bytes);
public long this[int i]=>Value[i];

public static A286969Inst Instance=new A286969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286970
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,3L,2L,6L,6L,10L,16L,20L,35L,45L,72L,103L,150L,228L,324L,491L,710L,1053L,1552L,2272L,3369L,4930L,7288L,10711L,15771L,23244L,34175L,50382L,74113L,109168L,160722L,236596L,348446L,512894L,755303L,1111946L,1637205L,2410592L,3549023L,5225659L,7693623L,11327912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286970Inst : IEnumerable<long>
{
public static readonly long[] Value=A286970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286970.Bytes);
public long this[int i]=>Value[i];

public static A286970Inst Instance=new A286970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286971
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,1L,0L,2L,1L,0L,1L,2L,2L,1L,1L,1L,4L,2L,2L,2L,2L,1L,3L,3L,3L,2L,3L,3L,4L,1L,3L,3L,4L,2L,3L,3L,5L,5L,4L,5L,5L,3L,5L,6L,6L,4L,3L,4L,4L,3L,7L,7L,6L,3L,3L,6L,8L,6L,4L,4L,3L,8L,8L,8L,7L,2L,7L,10L,8L,5L,5L,6L,4L,8L,8L,12L,7L,3L,7L,11L,11L,8L,3L,7L,9L,6L,10L,14L,8L,4L,5L,12L,13L,10L,7L,9L,8L,12L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286971Inst : IEnumerable<long>
{
public static readonly long[] Value=A286971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286971.Bytes);
public long this[int i]=>Value[i];

public static A286971Inst Instance=new A286971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286972
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,9L,11L,12L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,42L,43L,47L,49L,51L,53L,55L,57L,59L,61L,64L,65L,67L,69L,71L,73L,75L,77L,78L,79L,80L,81L,83L,84L,85L,87L,89L,91L,93L,95L,97L,100L,101L,103L,105L,107L,108L,109L,110L,111L,113L,114L,115L,119L,121L,123L,127L,129L,131L,132L,133L,135L,137L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286972Inst : IEnumerable<long>
{
public static readonly long[] Value=A286972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286972.Bytes);
public long this[int i]=>Value[i];

public static A286972Inst Instance=new A286972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286973
{
public static readonly long[] Value={ 0L,0L,5L,30L,126L,520L,2088L,8192L,32083L,125728L,492331L,1927334L,7545086L,29542032L,115713230L,453479812L,1778221568L,6976989468L,27390464896L,107590106636L,422842742731L,1662688326476L,6541232413273L,25746371202362L,101384373381977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286973Inst : IEnumerable<long>
{
public static readonly long[] Value=A286973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286973.Bytes);
public long this[int i]=>Value[i];

public static A286973Inst Instance=new A286973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286974
{
public static readonly long[] Value={ 0L,5L,50L,538L,3932L,32253L,238532L,1875212L,14222474L,110768815L,851356180L,6619388000L,51243150110L,398853561051L,3101596551513L,24188042117410L,188685917890136L,1474444397004861L,11529364760294089L,90260751863587788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286974Inst : IEnumerable<long>
{
public static readonly long[] Value=A286974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286974.Bytes);
public long this[int i]=>Value[i];

public static A286974Inst Instance=new A286974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286975
{
public static readonly BigInteger[] Value={ 0L,30L,538L,8270L,123706L,1853532L,27938670L,424161696L,6473516290L,99212813068L,1525788269640L,23533226594814L,363874149524074L,5638501690692214L,87539755014915366L,1361389260565705844L,BigInteger.Parse("21203931694258697402") };
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
public class A286975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286975.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286975Inst Instance=new A286975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286976
{
public static readonly BigInteger[] Value={ 0L,126L,3932L,123706L,3584756L,108110791L,3229944132L,98063836816L,2979455186170L,91160980841335L,2796112154318134L,86095874180805420L,2657384402642912532L,BigInteger.Parse("82232542990639333587"),BigInteger.Parse("2549783287899756993727") };
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
public class A286976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286976Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286976.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286976.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286976Inst Instance=new A286976Inst();

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